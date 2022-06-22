namespace VirtualMouse.Views
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblVersione = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.btbExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.SetColumnSpan(this.panelTop, 2);
            this.panelTop.Controls.Add(this.lblLink);
            this.panelTop.Controls.Add(this.lblAuthor);
            this.panelTop.Controls.Add(this.lblVersione);
            this.panelTop.Controls.Add(this.lblNome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(365, 70);
            this.panelTop.TabIndex = 0;
            // 
            // lblLink
            // 
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLink.Location = new System.Drawing.Point(163, 45);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(71, 23);
            this.lblLink.TabIndex = 5;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Repository";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAuthor.Location = new System.Drawing.Point(10, 45);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(147, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author : Roberto Dal Borgo";
            // 
            // lblVersione
            // 
            this.lblVersione.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersione.Location = new System.Drawing.Point(10, 30);
            this.lblVersione.Name = "lblVersione";
            this.lblVersione.Size = new System.Drawing.Size(164, 13);
            this.lblVersione.TabIndex = 2;
            this.lblVersione.Text = "Version : ";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNome.Size = new System.Drawing.Size(186, 30);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "VirtualMouse";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescrizione.Location = new System.Drawing.Point(3, 73);
            this.lblDescrizione.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Padding = new System.Windows.Forms.Padding(5);
            this.lblDescrizione.Size = new System.Drawing.Size(176, 152);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Utility to simulate the functionality of the mouse";
            // 
            // btbExit
            // 
            this.btbExit.AccessibleName = "Cerrar";
            this.btbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbExit.FlatAppearance.BorderSize = 0;
            this.btbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btbExit.ForeColor = System.Drawing.Color.White;
            this.btbExit.Image = global::VirtualMouse.Properties.Resources.outline_cancel_white_24dp;
            this.btbExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btbExit.Location = new System.Drawing.Point(258, 230);
            this.btbExit.Margin = new System.Windows.Forms.Padding(2);
            this.btbExit.Name = "btbExit";
            this.btbExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btbExit.Size = new System.Drawing.Size(105, 36);
            this.btbExit.TabIndex = 4;
            this.btbExit.UseVisualStyleBackColor = false;
            this.btbExit.Click += new System.EventHandler(this.btbExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btbExit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescrizione, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 268);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(185, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 152);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "F6 : Start\nF7 : Pause/Resume\nF8 : Stop";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_FormClosing);
            this.Load += new System.EventHandler(this.FORM_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblVersione;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Button btbExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblAuthor;
    }
}