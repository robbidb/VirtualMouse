using System;
using System.Windows.Forms;
using VirtualMouse.Utility;

namespace VirtualMouse.Views
{
    /// <summary>
    /// HELP - About window
    /// </summary>
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_Load(object sender, EventArgs e)
        {
            FORM_init();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
        }

        /// <summary>
        /// Initial operations
        /// </summary>
        private void FORM_init()
        {
            SwVersion SC = new SwVersion();
            String s = lblVersione.Text;
            s += " ";
            s += SC.getVersion();

            lblVersione.Text = s;
        }

        #region COMANDI
        /// <summary>
        /// Open github repository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/robbidb/VirtualMouse.git");
        }

        /// <summary>
        /// Exit Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}

