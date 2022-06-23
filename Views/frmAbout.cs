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
            String s = VERSION_value.Text;
            s += " ";
            s += SC.getVersion();

            VERSION_value.Text = s;
        }

        #region COMANDI
        /// <summary>
        /// Open github repository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void REPOS_value_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/robbidb/VirtualMouse.git");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

