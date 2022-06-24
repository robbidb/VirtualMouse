using System;
using System.Drawing;
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
            base.OnClosing(e);
        }

        private void FORM_init()
        {
            SwVersion i = new SwVersion();                          // Application Info
            this.Text = i.getName() + " " + i.getVersion();         // Window Title

            // Enable keyboard event
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);

            APP_nomeExe = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            APP_path    = Path.GetDirectoryName(Application.ExecutablePath);
            APP_configFile = APP_path + "\\" + APP_nomeExe + ".xml";

            // Configuration Data
            _md = _md.XMLDSerialize(APP_configFile);
            if (_md == null)
            {
                MessageBox.Show("[ERROR] file :  [" + APP_configFile + "] not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CONTROLS_set();
            BUTTONS_enable(true, false);

        }

        private void FORM_end()
        {
            // Configuration Data
            _md.XMLSerialize(APP_configFile, _md);
        }
        #endregion

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
            if (e.KeyCode == Keys.F8)
            {
                CMD_stop();
            }
            else
            {

            }
        }

        private void CONTROLS_set()
        {
            // Click Interval
            CLICKINTERVAL_settime_hours_value.Text  = _md.INTERVAL_hours.ToString();
            CLICKINTERVAL_settime_mins_value.Text   = _md.INTERVAL_mins.ToString();
            CLICKINTERVAL_settime_secs_value.Text   = _md.INTERVAL_secs.ToString();
            CLICKINTERVAL_settime_millis_value.Text = _md.INTERVAL_millis.ToString();

            // Click Repeat
            CLICKREPEAT_value.Value = _md.REPEAT_value;

            CLICKREPEAT_rb_repeat.Checked   = !_md.REPEAT_infinity;
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
        }

        private void CONTROLS_reset()
        {
            // Click Interval
            CLICKINTERVAL_settime_hours_value.Text = "0";
            CLICKINTERVAL_settime_mins_value.Text = "0";
            CLICKINTERVAL_settime_secs_value.Text = "1";
            CLICKINTERVAL_settime_millis_value.Text = "0";

            // Click Repeat
            CLICKREPEAT_value.Value = 10;
            CLICKREPEAT_rb_repeat.Checked = true;
            CLICKREPEAT_rb_nolimits.Checked = false;

            // Click Options
            CLICKOPTIONS_BUTTON_left.Checked = true;
            CLICKOPTIONS_BUTTON_middle.Checked = false;
            CLICKOPTIONS_BUTTON_right.Checked = false;
            CLICKOPTIONS_TYPE_single.Checked = true;
            CLICKOPTIONS_TYPE_double.Checked = false;
        }

        private void BUTTONS_enable(Boolean _start, Boolean _stop)
        {
            btnStart.Enabled = _start;
            if (_start)
            {
                btnStart.Visible = true;
                btnStart.BackColor = Color.Green;
            }
            else
            {
                btnStart.Visible = false;
                btnStart.BackColor = Color.DimGray;
            }

            btnStop.Enabled = _stop;
            if (_stop)
            {
                btnStop.Visible = true;
                btnStop.BackColor = Color.Red;
            }
            else
            {
                btnStop.Visible = false;
                btnStop.BackColor = Color.DimGray;
            }
        }


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
        private void CMD_start()
        {
            if (DATA_check())
            {
                BUTTONS_enable(false, true);

                _md.REPEAT_cnt = _md.REPEAT_value;
                TIMER_start(_md.INTERVAL_value);
            }
        }

        private void CMD_stop()
        {
            BUTTONS_enable(true, false);

            TIMER_stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CMD_start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CMD_stop();
        }

        private void Click_sx()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        private void Click_middle()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
        }
        private void Click_dx()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
        private void Click_run(int _type)
        {
            switch (_type)
            {
                case 0:
                    if (_md.TYPE_doubleclick) { Click_sx(); }
                    Click_sx();
                    break;
                case 1:
                    if (_md.TYPE_doubleclick) { Click_middle(); }
                    Click_middle();
                    break;
                case 2:
                    if (_md.TYPE_doubleclick) { Click_dx(); }
                    Click_dx();
                    break;
            }
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
            _md.INTERVAL_hours = Convert.ToInt32(CLICKINTERVAL_settime_hours_value.Text);
        }
        private void CLICKINTERVAL_settime_mins_TextChanged(object sender, EventArgs e)
        {
            _md.INTERVAL_mins = Convert.ToInt32(CLICKINTERVAL_settime_mins_value.Text);
        }
        private void CLICKINTERVAL_settime_secs_TextChanged(object sender, EventArgs e)
        {
            _md.INTERVAL_secs = Convert.ToInt32(CLICKINTERVAL_settime_secs_value.Text);
        }
        private void CLICKINTERVAL_settime_millis_TextChanged(object sender, EventArgs e)
        {
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
        #endregion

        #region TIMER
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

        private void TIMER_pause()
        {
            TIMER.Stop();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            Boolean bContinue = false;

            if (_md.REPEAT_infinity)
            {
                bContinue = true;
                Click_run(_md.TYPE_value);
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
                Click_run(_md.TYPE_value);
            }
            else
            {
                CMD_stop();
            }
        }
        #endregion
    }
}
