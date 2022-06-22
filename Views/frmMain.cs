using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
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

        private Data _d = new Data();
      
        /// <summary>
        /// Costruttore
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SwVersion i = new SwVersion();                          // Application Info
            this.Text = i.getName() + " " + i.getVersion();         // Window Title

            CONTROLS_reset();
            BUTTONS_enable(true, false, false);

            // Enable keyboard event
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
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
            if (e.KeyCode == Keys.F7)
            {
                CMD_pause();
            }
            if (e.KeyCode == Keys.F8)
            {
                CMD_stop();
            }
            else
            {

            }
                //MessageBox.Show("No Function");
        }

        private void CONTROLS_reset()
        {
            QUANTITY_updown.Value = 10;
            QUANTITY_infinity.Checked = false;

            LENGTH_updown.Enabled = true;
            LENGTH_updown.Value = 500;
            LENGTH_um.SelectedIndex = 0;

            TYPE_doubleClick.Checked = false;
            TYPE_select.SelectedIndex = 0;
        }

        private void BUTTONS_enable(Boolean _start, Boolean _pause, Boolean _stop)
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

            btnPause.Enabled = _pause;
            if (_pause)
            {
                btnPause.Visible = true;
                btnPause.BackColor = Color.SteelBlue;
            }
            else
            {
                btnPause.Visible = false;
                btnPause.BackColor = Color.DimGray;
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

 

        #region COMMANDS
        private void CMD_start()
        {
            if (DATA_check())
            {
                BUTTONS_enable(false, true, true);

                _d.QUANTITY_cnt = _d.QUANTITY_value;
                TIMER_start(_d.INTERVAL_value);
            }
        }

        private void CMD_stop()
        {
            BUTTONS_enable(true, false, false);

            TIMER_stop();
        }

        private void CMD_pause()
        {
            if (btnPause.Text == "Pause")
            {
                BUTTONS_enable(false, true, false);
                btnPause.Text = "Resume";
                TIMER_pause();
            }
            else
            {
                BUTTONS_enable(false, true, true);
                btnPause.Text = "Pause";
                TIMER_start(_d.INTERVAL_value);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CMD_start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CMD_stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            CMD_pause();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MOUSE Commands
        /// <summary>
        /// Left mouse button
        /// </summary>
        private void Click_sx()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        /// <summary>
        /// Middle mouse button
        /// </summary>
        private void Click_middle()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
        }

        /// <summary>
        /// Right mouse button
        /// </summary>
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
                    if (_d.TYPE_doubleclick) { Click_sx(); }
                    Click_sx();
                    break;
                case 1:
                    if (_d.TYPE_doubleclick) { Click_middle(); }
                    Click_middle();
                    break;
                case 2:
                    if (_d.TYPE_doubleclick) { Click_dx(); }
                    Click_dx();
                    break;
            }
        }
        #endregion
        #endregion


        #region SETTINGS
        #region Set Quantity
        private void QUANTITY_updown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void QUANTITY_infinity_CheckedChanged(object sender, EventArgs e)
        {
            QUANTITY_updown.Enabled = !QUANTITY_infinity.Checked;
        }
        #endregion

        #region Set Timing
        private void LENGTH_updown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LENGTH_um_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region Set Type
        private void TYPE_select_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TYPE_doubleClick_CheckedChanged(object sender, EventArgs e)
        {
        }
        #endregion

        private Boolean DATA_check()
        {
            Boolean bOK = true;
            int iTmp = 0;

            // QUANTITY
            iTmp = Convert.ToInt32(QUANTITY_updown.Value);
            if (iTmp < 1)
            {
                MessageBox.Show("Click quantity must be > 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bOK = false;
            }
            else
            {
                _d.QUANTITY_value    = iTmp;
                _d.QUANTITY_infinity = QUANTITY_infinity.Checked;
            }

            // INTERVAL
            iTmp = Convert.ToInt32(LENGTH_updown.Value);
            if (iTmp < 1)
            {
                MessageBox.Show("Interval must be > 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bOK = false;
            }
            else
            {
                _d.INTERVAL_type = Convert.ToInt32(LENGTH_um.SelectedIndex);
                switch (_d.INTERVAL_type)
                {
                    case 0:
                        _d.INTERVAL_value = iTmp;
                        break;
                    case 1:
                        _d.INTERVAL_value = iTmp * 1000;
                        break;
                    case 2:
                        _d.INTERVAL_value = iTmp * 60000;
                        break;
                    case 3:
                        _d.INTERVAL_value = iTmp * 3600000;
                        break;
                    default:
                        _d.INTERVAL_value = iTmp;
                        break;
                }
            }

            _d.TYPE_doubleclick = TYPE_doubleClick.Checked;
            _d.TYPE_value = TYPE_select.SelectedIndex;
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

            if (_d.QUANTITY_infinity)
            {
                Click_run(_d.TYPE_value);
            }
            else
            {
                if (_d.QUANTITY_cnt != 0)
                {
                    Click_run(_d.TYPE_value);

                    _d.QUANTITY_cnt --;
                }
                else
                {
                    CMD_stop();
                }
            }
        }
        #endregion
    }
}
