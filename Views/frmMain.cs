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
            BUTTONS_enable(true, false);

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
            // Click Interval
            CLICKINTERVAL_settime.Checked = true;
            CLICKINTERVAL_random.Checked = false;

            CLICKINTERVAL_settime_hours_value.Text = "0";
            CLICKINTERVAL_settime_mins_value.Text = "0";
            CLICKINTERVAL_settime_secs_value.Text = "1";
            CLICKINTERVAL_settime_millis_value.Text = "0";
            CLICKINTERVAL_random_minValue.Text = "0.1";
            CLICKINTERVAL_random_maxValue.Text = "60";

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

 

        #region COMMANDS
        private void CMD_start()
        {
            if (DATA_check())
            {
                BUTTONS_enable(false, true);

                _d.REPEAT_cnt = _d.REPEAT_value;
                TIMER_start(_d.INTERVAL_value);
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
        #region Click Repeat
        private void CLICKREPEAT_value_ValueChanged(object sender, EventArgs e)
        {
        }

        private void CLICKREPEAT_rb_CheckedChanged(object sender, EventArgs e)
        {
            CLICKREPEAT_value.Enabled = !CLICKREPEAT_rb_nolimits.Checked;
        }
        #endregion

        #region Click Interval
        private void CLICKINTERVAL_set_CheckedChanged(object sender, EventArgs e)
        {
            if (CLICKINTERVAL_settime.Checked)
            {
                _d.INTERVAL_type = _d.INTERVAL_TYPE_FIXED;

                CLICKINTERVAL_settime_hours_value.Enabled = true;
                CLICKINTERVAL_settime_mins_value.Enabled = true;
                CLICKINTERVAL_settime_secs_value.Enabled = true;
                CLICKINTERVAL_settime_millis_value.Enabled = true;

                CLICKINTERVAL_random_minValue.Enabled = false;
                CLICKINTERVAL_random_maxValue.Enabled = false;
            }
            else
            {
                _d.INTERVAL_type = _d.INTERVAL_TYPE_RANDOM;

                CLICKINTERVAL_settime_hours_value.Enabled = false;
                CLICKINTERVAL_settime_mins_value.Enabled = false;
                CLICKINTERVAL_settime_secs_value.Enabled = false;
                CLICKINTERVAL_settime_millis_value.Enabled = false;

                CLICKINTERVAL_random_minValue.Enabled = true;
                CLICKINTERVAL_random_maxValue.Enabled = true;
            }
        }
        private void CLICKINTERVAL_settime_value_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Click Options
        private void CLICKOPTIONS_BUTTON_CheckedChanged(object sender, EventArgs e)
        {
            if (CLICKOPTIONS_BUTTON_left.Checked)
            {
                _d.TYPE_value = 0;
            }
            if (CLICKOPTIONS_BUTTON_middle.Checked)
            {
                _d.TYPE_value = 1;
            }
            if (CLICKOPTIONS_BUTTON_right.Checked)
            {
                _d.TYPE_value = 2;
            }
        }

        private void CLICKOPTIONS_TYPE_CheckedChanged(object sender, EventArgs e)
        {
            if (CLICKOPTIONS_TYPE_double.Checked)
            {
                _d.TYPE_doubleclick = true;
            }
            else
            {
                _d.TYPE_doubleclick = false;
            }
        }
        #endregion

        private Boolean DATA_check()
        {
            Boolean bOK = true;
            int iTmp = 0;

            #region Click Interval
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_millis_value.Text);
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_secs_value.Text) * 1000;
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_mins_value.Text) * 60000;
            iTmp += Convert.ToInt32(CLICKINTERVAL_settime_hours_value.Text) * 3600000;
            _d.INTERVAL_value = iTmp;
            #endregion

            #region Click Repeat
            iTmp = Convert.ToInt32(CLICKREPEAT_value.Value);
            if (iTmp < 1)
            {
                MessageBox.Show("Click quantity must be > 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bOK = false;
            }
            else
            {
                _d.REPEAT_value = iTmp;
                _d.REPEAT_infinity = CLICKREPEAT_rb_nolimits.Checked;
            }
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

            if (_d.REPEAT_infinity)
            {
                bContinue = true;
                Click_run(_d.TYPE_value);
            }
            else
            {
                if (_d.REPEAT_cnt != 0)
                {
                    bContinue = true;

                    _d.REPEAT_cnt--;
                }
            }

            if (bContinue)
            {
                Click_run(_d.TYPE_value);
            }
            else
            {
                CMD_stop();
            }
        }

        #endregion
    }
}
