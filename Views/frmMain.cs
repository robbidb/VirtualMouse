using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

using VirtualMouse.Utility;

namespace VirtualMouse.Views
{
    public partial class frmMain : Form
    {
        #region Mouse Events
        private const int MOUSEEVENTF_LEFTDOWN = 0X0002;
        private const int MOUSEEVENTF_LEFTUP = 0X0004;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0X0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0X0040;
        private const int MOUSEEVENTF_RIGHTDOWN = 0X0008;
        private const int MOUSEEVENTF_RIGHTUP = 0X00010;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        #endregion

        String APP_nomeExe = string.Empty;
        String APP_path = string.Empty;
        String APP_configFile = string.Empty;

        private MouseData _md = new MouseData();

        public int LISTPOSITIONS_count = 0;                 // listview items number
        public int LISTPOSITIONS_current = 0;               // Current item from listview

        #region FORM
        /// <summary>
        /// Costruttore
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FORM_init();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FORM_end();
            base.OnClosing(e);
        }

        private void FORM_init()
        {
            SwVersion i = new SwVersion();                          // Application Info
            this.Text = i.getName() + " " + i.getVersion();         // Window Title

            // Enable keyboard event
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);

            APP_nomeExe = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            APP_path = Path.GetDirectoryName(Application.ExecutablePath);
            APP_configFile = APP_path + "\\" + APP_nomeExe + ".xml";

            // Configuration Data
            _md = _md.XMLDSerialize(APP_configFile);
            if (_md == null)
            {
                MessageBox.Show("[ERROR] file :  [" + APP_configFile + "] not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CONTROLS_set();
            CMD_StartStop_enable(true, false);
        }

        private void FORM_end()
        {
            // Configuration Data
            _md.XMLSerialize(APP_configFile, _md);
        }

        /// <summary>
        /// Keyup Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                CMD_start();
            }
            else if (e.KeyCode == Keys.F8)
            {
                CMD_stop();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnAddPosition_Click(null, null);
            }
            else
            {

            }
        }
        #endregion


        #region MENU
        private void MenuItem_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog _Dialog = new OpenFileDialog
            {
                InitialDirectory = APP_path,
                Title = "Browse Configuration Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (_Dialog.ShowDialog() == DialogResult.OK)
            {
                String sNomeFile = _Dialog.FileName;

                _md = _md.XMLDSerialize(sNomeFile);
                CONTROLS_set();
            }
        }

        private void MenuItem_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog _Dialog = new SaveFileDialog
            {
                InitialDirectory = APP_path,
                Title = "Save Configuration File",
                CheckPathExists = true,
                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xnl|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (_Dialog.ShowDialog() == DialogResult.OK)
            {
                String sNomeFile = _Dialog.FileName;

                // Configuration Data
                _md.XMLSerialize(sNomeFile, _md);
            }
        }

        private void MenuItem_exit_Click(object sender, EventArgs e)
        {
            FORM_end();
            Close();
        }

        private void MenuItem_about_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }
        #endregion


        #region COMMANDS
        private void CONTROLS_set()
        {
            // Click Interval
            CLICKINTERVAL_settime_hours_value.Text = _md.INTERVAL_hours.ToString();
            CLICKINTERVAL_settime_mins_value.Text = _md.INTERVAL_mins.ToString();
            CLICKINTERVAL_settime_secs_value.Text = _md.INTERVAL_secs.ToString();
            CLICKINTERVAL_settime_millis_value.Text = _md.INTERVAL_millis.ToString();

            // Click Repeat
            CLICKREPEAT_value.Value = _md.REPEAT_value;

            CLICKREPEAT_rb_repeat.Checked = !_md.REPEAT_infinity;
            CLICKREPEAT_rb_nolimits.Checked = _md.REPEAT_infinity;

            // Click Options
            CLICKOPTIONS_BUTTON_left.Checked = false;
            CLICKOPTIONS_BUTTON_middle.Checked = false;
            CLICKOPTIONS_BUTTON_right.Checked = false;
            switch (_md.TYPE_value)
            {
                case 0:
                    CLICKOPTIONS_BUTTON_left.Checked = true;
                    break;
                case 1:
                    CLICKOPTIONS_BUTTON_middle.Checked = true;
                    break;
                case 2:
                    CLICKOPTIONS_BUTTON_right.Checked = true;
                    break;
            }

            CLICKOPTIONS_TYPE_single.Checked = !_md.TYPE_doubleclick;
            CLICKOPTIONS_TYPE_double.Checked = _md.TYPE_doubleclick;

            POSITIONS_current.Checked = !_md.POSITIONS_isQueued;
            POSITIONS_queued.Checked = _md.POSITIONS_isQueued;
            POSITIONS_ListView.Items.Clear();

            foreach (Point p in _md.PointList)
            {
                ListViewItem item = new ListViewItem((POSITIONS_ListView.Items.Count + 1).ToString());

                item.SubItems.Add(p.X.ToString());
                item.SubItems.Add(p.Y.ToString());

                POSITIONS_ListView.Items.Add(item);
            }
        }

        private void CMD_start()
        {
            if (DATA_check())
            {
                CMD_StartStop_enable(false, true);

                if ( _md.POSITIONS_isQueued)
                {
                    LISTPOSITIONS_count   = POSITIONS_ListView.Items.Count-1;
                    LISTPOSITIONS_current = 0;
                    if (LISTPOSITIONS_count > 0)
                    {
                        _md.PointList.Clear();
                        foreach (ListViewItem item in POSITIONS_ListView.Items)
                        {
                            int x = Convert.ToInt32(item.SubItems[1].Text); //x coordinate
                            int y = Convert.ToInt32(item.SubItems[2].Text); //y coordinate
                            Point p = new Point(x, y);
                            _md.PointList.Add(p);
                        }
                    }
                }

                _md.REPEAT_cnt = _md.REPEAT_value;
                TIMER_start(_md.INTERVAL_value);
            }
        }

        private void CMD_stop()
        {
            CMD_StartStop_enable(true, false);

            TIMER_stop();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_start"></param>
        /// <param name="_stop"></param>
        private void CMD_StartStop_enable(Boolean _start, Boolean _stop)
        {
            bool _visible;
            Color _backColor;

            if (_start) { _backColor = Color.Green; }
            else { _backColor = Color.DimGray; }
            _visible = _start;
            btnStart.Invoke((EventHandler)delegate { btnStart.Enabled = _start; });
            btnStart.Invoke((EventHandler)delegate { btnStart.Visible = _visible; });
            btnStart.Invoke((EventHandler)delegate { btnStart.BackColor = _backColor; });

            if (_stop) { _backColor = Color.Red; }
            else { _backColor = Color.DimGray; }
            _visible = _stop;
            btnStop.Invoke((EventHandler)delegate { btnStop.Enabled = _stop; });
            btnStop.Invoke((EventHandler)delegate { btnStop.Visible = _visible; });
            btnStop.Invoke((EventHandler)delegate { btnStop.BackColor = _backColor; });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CMD_start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CMD_stop();
        }

        private void Click_run(int _x, int _y, int _type)
        {
            int Up = 0;
            int Down = 0;

            switch (_type)
            {
                case 0:
                    // Left
                    Up   = MOUSEEVENTF_LEFTUP;
                    Down = MOUSEEVENTF_LEFTDOWN;
                    break;

                case 1:
                    // Middle
                    Up   = MOUSEEVENTF_MIDDLEUP;
                    Down = MOUSEEVENTF_MIDDLEDOWN;
                    break;

                case 2:
                    Up   = MOUSEEVENTF_RIGHTUP;
                    Down = MOUSEEVENTF_RIGHTDOWN;
                    break;
            }

            if (_md.TYPE_doubleclick)
            {
                mouse_event(Down | Up, _x, _y, 0, 0);
            }
            mouse_event(Down | Up, _x, _y, 0, 0);
        }

        /// <summary>
        /// Set the current position of the cursor to the coordinates held in point
        /// </summary>
        /// <param name="point">Coordinates to set the cursor to</param>
        private void SetCursorPosition(Point point)
        {
            Cursor.Position = point;
        }
        #endregion


        #region SETTINGS
        // Click Repeat
        private void CLICKREPEAT_value_ValueChanged(object sender, EventArgs e)
        {
            _md.REPEAT_value = Convert.ToInt32(CLICKREPEAT_value.Value);
        }
        private void CLICKREPEAT_rb_CheckedChanged(object sender, EventArgs e)
        {
            _md.REPEAT_infinity = CLICKREPEAT_rb_nolimits.Checked;
            CLICKREPEAT_value.Enabled = !CLICKREPEAT_rb_nolimits.Checked;
        }

        // Click Interval
        private void CLICKINTERVAL_settime_hours_TextChanged(object sender, EventArgs e)
        {
            if (CLICKINTERVAL_settime_hours_value.Text.Length > 0)
                _md.INTERVAL_hours = Convert.ToInt32(CLICKINTERVAL_settime_hours_value.Text);
        }
        private void CLICKINTERVAL_settime_mins_TextChanged(object sender, EventArgs e)
        {
            if (CLICKINTERVAL_settime_mins_value.Text.Length > 0)
                _md.INTERVAL_mins = Convert.ToInt32(CLICKINTERVAL_settime_mins_value.Text);
        }
        private void CLICKINTERVAL_settime_secs_TextChanged(object sender, EventArgs e)
        {
            if (CLICKINTERVAL_settime_secs_value.Text.Length > 0)
                _md.INTERVAL_secs = Convert.ToInt32(CLICKINTERVAL_settime_secs_value.Text);
        }
        private void CLICKINTERVAL_settime_millis_TextChanged(object sender, EventArgs e)
        {
            if (CLICKINTERVAL_settime_millis_value.Text.Length > 0)
                _md.INTERVAL_millis = Convert.ToInt32(CLICKINTERVAL_settime_millis_value.Text);
        }

        // Click Options
        private void CLICKOPTIONS_BUTTON_CheckedChanged(object sender, EventArgs e)
        {
            if (CLICKOPTIONS_BUTTON_left.Checked)
            {
                _md.TYPE_value = 0;
            }
            if (CLICKOPTIONS_BUTTON_middle.Checked)
            {
                _md.TYPE_value = 1;
            }
            if (CLICKOPTIONS_BUTTON_right.Checked)
            {
                _md.TYPE_value = 2;
            }
        }
        private void CLICKOPTIONS_TYPE_CheckedChanged(object sender, EventArgs e)
        {
            if (CLICKOPTIONS_TYPE_double.Checked)
            {
                _md.TYPE_doubleclick = true;
            }
            else
            {
                _md.TYPE_doubleclick = false;
            }
        }

        private Boolean DATA_check()
        {
            Boolean bOK = true;
            int iTmp = 0;

            #region Click Interval
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_millis_value.Text);
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_secs_value.Text) * 1000;
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_mins_value.Text) * 60000;
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_hours_value.Text) * 3600000;
            _md.INTERVAL_value = iTmp;
            #endregion

            return bOK;
        }

        // Queued positions
        private void POSITIONS_current_CheckedChanged(object sender, EventArgs e)
        {
            _md.POSITIONS_isQueued = POSITIONS_queued.Checked;
        }

        private void POSITIONS_readFromCursor_CheckedChanged(object sender, EventArgs e)
        {
            if (POSITIONS_readFromCursor.Checked)
            {
                TIMER_currentPosition.Start();
            }
            else
            {
                TIMER_currentPosition.Stop();
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            if (POSITION_IsValid(POSITIONS_x.Text, POSITIONS_y.Text))
            {

                ListViewItem item = new ListViewItem((POSITIONS_ListView.Items.Count + 1).ToString());

                item.SubItems.Add(POSITIONS_x.Text);
                item.SubItems.Add(POSITIONS_y.Text);

                POSITIONS_ListView.Items.Add(item);
            }
        }

        private void btnClearListPositions_Click(object sender, EventArgs e)
        {
            POSITIONS_ListView.Items.Clear();
        }

        private bool POSITION_IsValid(string _x, string _y)
        {
            return true;
        }
        #endregion


        #region TIMERS
        /// <summary>
        /// Run timer
        /// </summary>
        /// <param name="_interval"> Timer length</param>
        private void TIMER_start(int _interval)
        {
            TIMER.Interval = _interval;
            TIMER.Start();
        }

        /// <summary>
        /// Stop timer
        /// </summary>
        private void TIMER_stop()
        {
            TIMER.Dispose();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            Boolean bContinue = false;

            if (_md.REPEAT_infinity)
            {
                bContinue = true;
            }
            else
            {
                if (_md.REPEAT_cnt != 0)
                {
                    bContinue = true;
                    _md.REPEAT_cnt--;
                }
            }

            if (bContinue)
            {
                if (_md.POSITIONS_isQueued)
                {
                    if (LISTPOSITIONS_count > 0)
                    {
                        // Move pointer
                        SetCursorPosition(_md.PointList[LISTPOSITIONS_current]);
                        

                        LISTPOSITIONS_current ++;
                        if (LISTPOSITIONS_current > LISTPOSITIONS_count)
                        {
                            LISTPOSITIONS_current = 0;
                        }
                    }
                    else
                    {
                    }
                }
                Click_run(Cursor.Position.X, Cursor.Position.Y, _md.TYPE_value);
            }
            else
            {
                CMD_stop();
            }
        }


        /// <summary>
        /// Read the current position of the mouse cursor on screen on each interval of the timer
        /// </summary>
        private void TIMER_currentPosition_Tick(object sender, EventArgs e)
        {
            POSITIONS_x.Invoke((EventHandler)delegate { POSITIONS_x.Text = Cursor.Position.X.ToString(); });
            POSITIONS_y.Invoke((EventHandler)delegate { POSITIONS_y.Text = Cursor.Position.Y.ToString(); });
        }
        #endregion
    }
}
