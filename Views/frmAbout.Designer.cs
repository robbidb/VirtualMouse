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
            this.REPOS_value = new System.Windows.Forms.LinkLabel();
            this.VERSION_value = new System.Windows.Forms.Label();
            this.TITLE = new System.Windows.Forms.Label();
            this.AUTHOR_label = new System.Windows.Forms.Label();
            this.DESCRIPTION = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.AUTHOR_value = new System.Windows.Forms.Label();
            this.REPOS_label = new System.Windows.Forms.Label();
            this.VERSION_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // REPOS_value
            // 
            this.REPOS_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPOS_value.Location = new System.Drawing.Point(170, 180);
            this.REPOS_value.Margin = new System.Windows.Forms.Padding(0);
            this.REPOS_value.Name = "REPOS_value";
            this.REPOS_value.Size = new System.Drawing.Size(160, 25);
            this.REPOS_value.TabIndex = 5;
            this.REPOS_value.TabStop = true;
            this.REPOS_value.Text = "Github";
            this.REPOS_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.REPOS_value.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.REPOS_value_LinkClicked);
            // 
            // VERSION_value
            // 
            this.VERSION_value.Font = new System.Drawing.Font("Calibri", 12F);
            this.VERSION_value.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VERSION_value.Location = new System.Drawing.Point(170, 120);
            this.VERSION_value.Margin = new System.Windows.Forms.Padding(0);
            this.VERSION_value.Name = "VERSION_value";
            this.VERSION_value.Size = new System.Drawing.Size(160, 25);
            this.VERSION_value.TabIndex = 2;
            this.VERSION_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TITLE
            // 
            this.TITLE.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.Location = new System.Drawing.Point(80, 20);
            this.TITLE.Margin = new System.Windows.Forms.Padding(0);
            this.TITLE.Name = "TITLE";
            this.TITLE.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TITLE.Size = new System.Drawing.Size(200, 50);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "VirtualMouse";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AUTHOR_label
            // 
            this.AUTHOR_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTHOR_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AUTHOR_label.Location = new System.Drawing.Point(0, 150);
            this.AUTHOR_label.Margin = new System.Windows.Forms.Padding(0);
            this.AUTHOR_label.Name = "AUTHOR_label";
            this.AUTHOR_label.Size = new System.Drawing.Size(160, 25);
            this.AUTHOR_label.TabIndex = 3;
            this.AUTHOR_label.Text = "Author";
            this.AUTHOR_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Location = new System.Drawing.Point(0, 90);
            this.DESCRIPTION.Margin = new System.Windows.Forms.Padding(0);
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Size = new System.Drawing.Size(360, 23);
            this.DESCRIPTION.TabIndex = 1;
            this.DESCRIPTION.Text = "An utility to simulate the functionality of the mouse";
            this.DESCRIPTION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Ok";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AUTHOR_value
            // 
            this.AUTHOR_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTHOR_value.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AUTHOR_value.Location = new System.Drawing.Point(170, 150);
            this.AUTHOR_value.Margin = new System.Windows.Forms.Padding(0);
            this.AUTHOR_value.Name = "AUTHOR_value";
            this.AUTHOR_value.Size = new System.Drawing.Size(160, 25);
            this.AUTHOR_value.TabIndex = 10;
            this.AUTHOR_value.Text = "Roberto Dal Borgo";
            this.AUTHOR_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // REPOS_label
            // 
            this.REPOS_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPOS_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.REPOS_label.Location = new System.Drawing.Point(0, 180);
            this.REPOS_label.Margin = new System.Windows.Forms.Padding(0);
            this.REPOS_label.Name = "REPOS_label";
            this.REPOS_label.Size = new System.Drawing.Size(160, 25);
            this.REPOS_label.TabIndex = 11;
            this.REPOS_label.Text = "Repository";
            this.REPOS_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VERSION_label
            // 
            this.VERSION_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VERSION_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VERSION_label.Location = new System.Drawing.Point(0, 120);
            this.VERSION_label.Margin = new System.Windows.Forms.Padding(0);
            this.VERSION_label.Name = "VERSION_label";
            this.VERSION_label.Size = new System.Drawing.Size(160, 25);
            this.VERSION_label.TabIndex = 12;
            this.VERSION_label.Text = "Version";
            this.VERSION_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 272);
            this.Controls.Add(this.VERSION_label);
            this.Controls.Add(this.DESCRIPTION);
            this.Controls.Add(this.VERSION_value);
            this.Controls.Add(this.REPOS_label);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.REPOS_value);
            this.Controls.Add(this.AUTHOR_value);
            this.Controls.Add(this.AUTHOR_label);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_FormClosing);
            this.Load += new System.EventHandler(this.FORM_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label VERSION_value;
        private System.Windows.Forms.Label DESCRIPTION;
        private System.Windows.Forms.LinkLabel REPOS_value;
        private System.Windows.Forms.Label AUTHOR_label;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label AUTHOR_value;
        private System.Windows.Forms.Label REPOS_label;
        private System.Windows.Forms.Label VERSION_label;
    }
}