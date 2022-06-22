namespace VirtualMouse.Views
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.QUANTITY_updown = new System.Windows.Forms.NumericUpDown();
            this.QUANTITY_label = new System.Windows.Forms.Label();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.QUANTITY_infinity = new System.Windows.Forms.CheckBox();
            this.LENGTH_um = new System.Windows.Forms.ComboBox();
            this.TYPE_doubleClick = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LENGTH_panel = new System.Windows.Forms.Panel();
            this.LENGTH_label = new System.Windows.Forms.Label();
            this.LENGTH_updown = new System.Windows.Forms.NumericUpDown();
            this.Quantity_panel = new System.Windows.Forms.Panel();
            this.TYPE_panel = new System.Windows.Forms.Panel();
            this.TYPE_label = new System.Windows.Forms.Label();
            this.TYPE_select = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.QUANTITY_updown)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.LENGTH_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LENGTH_updown)).BeginInit();
            this.Quantity_panel.SuspendLayout();
            this.TYPE_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(2, 2);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPause.Enabled = false;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(190, 2);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(105, 36);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(373, 2);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 36);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // QUANTITY_updown
            // 
            this.QUANTITY_updown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QUANTITY_updown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY_updown.Location = new System.Drawing.Point(82, 7);
            this.QUANTITY_updown.Margin = new System.Windows.Forms.Padding(0);
            this.QUANTITY_updown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.QUANTITY_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QUANTITY_updown.Name = "QUANTITY_updown";
            this.QUANTITY_updown.Size = new System.Drawing.Size(58, 27);
            this.QUANTITY_updown.TabIndex = 4;
            this.QUANTITY_updown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.QUANTITY_updown.ValueChanged += new System.EventHandler(this.QUANTITY_updown_ValueChanged);
            // 
            // QUANTITY_label
            // 
            this.QUANTITY_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QUANTITY_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY_label.Location = new System.Drawing.Point(0, 2);
            this.QUANTITY_label.Margin = new System.Windows.Forms.Padding(0);
            this.QUANTITY_label.Name = "QUANTITY_label";
            this.QUANTITY_label.Size = new System.Drawing.Size(78, 37);
            this.QUANTITY_label.TabIndex = 6;
            this.QUANTITY_label.Text = "Quantity";
            this.QUANTITY_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TIMER
            // 
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // QUANTITY_infinity
            // 
            this.QUANTITY_infinity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QUANTITY_infinity.Font = new System.Drawing.Font("Calibri", 12F);
            this.QUANTITY_infinity.Location = new System.Drawing.Point(168, 2);
            this.QUANTITY_infinity.Margin = new System.Windows.Forms.Padding(0);
            this.QUANTITY_infinity.Name = "QUANTITY_infinity";
            this.QUANTITY_infinity.Size = new System.Drawing.Size(119, 37);
            this.QUANTITY_infinity.TabIndex = 11;
            this.QUANTITY_infinity.Text = "No Limits";
            this.QUANTITY_infinity.UseVisualStyleBackColor = true;
            this.QUANTITY_infinity.CheckedChanged += new System.EventHandler(this.QUANTITY_infinity_CheckedChanged);
            // 
            // LENGTH_um
            // 
            this.LENGTH_um.BackColor = System.Drawing.Color.White;
            this.LENGTH_um.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LENGTH_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LENGTH_um.Font = new System.Drawing.Font("Calibri", 12F);
            this.LENGTH_um.ForeColor = System.Drawing.Color.Black;
            this.LENGTH_um.FormattingEnabled = true;
            this.LENGTH_um.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds",
            "Minutes",
            "Hours"});
            this.LENGTH_um.Location = new System.Drawing.Point(168, 7);
            this.LENGTH_um.Margin = new System.Windows.Forms.Padding(0);
            this.LENGTH_um.Name = "LENGTH_um";
            this.LENGTH_um.Size = new System.Drawing.Size(144, 27);
            this.LENGTH_um.TabIndex = 10;
            this.LENGTH_um.Tag = "";
            this.LENGTH_um.SelectedIndexChanged += new System.EventHandler(this.LENGTH_um_SelectedIndexChanged);
            // 
            // TYPE_doubleClick
            // 
            this.TYPE_doubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TYPE_doubleClick.Font = new System.Drawing.Font("Calibri", 12F);
            this.TYPE_doubleClick.Location = new System.Drawing.Point(240, 2);
            this.TYPE_doubleClick.Margin = new System.Windows.Forms.Padding(0);
            this.TYPE_doubleClick.Name = "TYPE_doubleClick";
            this.TYPE_doubleClick.Size = new System.Drawing.Size(107, 37);
            this.TYPE_doubleClick.TabIndex = 13;
            this.TYPE_doubleClick.Text = "Double click";
            this.TYPE_doubleClick.UseVisualStyleBackColor = true;
            this.TYPE_doubleClick.CheckedChanged += new System.EventHandler(this.TYPE_doubleClick_CheckedChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.btnHelp, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.btnExit, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.LENGTH_panel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.Quantity_panel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.TYPE_panel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(484, 261);
            this.tableLayoutPanel.TabIndex = 14;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::VirtualMouse.Properties.Resources.outline_info_white_24dp;
            this.btnHelp.Location = new System.Drawing.Point(4, 221);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(105, 36);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::VirtualMouse.Properties.Resources.outline_cancel_white_24dp;
            this.btnExit.Location = new System.Drawing.Point(375, 221);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LENGTH_panel
            // 
            this.LENGTH_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel.SetColumnSpan(this.LENGTH_panel, 3);
            this.LENGTH_panel.Controls.Add(this.LENGTH_label);
            this.LENGTH_panel.Controls.Add(this.LENGTH_updown);
            this.LENGTH_panel.Controls.Add(this.LENGTH_um);
            this.LENGTH_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LENGTH_panel.Location = new System.Drawing.Point(4, 49);
            this.LENGTH_panel.Margin = new System.Windows.Forms.Padding(2);
            this.LENGTH_panel.Name = "LENGTH_panel";
            this.LENGTH_panel.Size = new System.Drawing.Size(476, 41);
            this.LENGTH_panel.TabIndex = 12;
            // 
            // LENGTH_label
            // 
            this.LENGTH_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.LENGTH_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LENGTH_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LENGTH_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LENGTH_label.Location = new System.Drawing.Point(0, 0);
            this.LENGTH_label.Margin = new System.Windows.Forms.Padding(0);
            this.LENGTH_label.Name = "LENGTH_label";
            this.LENGTH_label.Size = new System.Drawing.Size(78, 41);
            this.LENGTH_label.TabIndex = 6;
            this.LENGTH_label.Text = "Length";
            this.LENGTH_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LENGTH_updown
            // 
            this.LENGTH_updown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LENGTH_updown.Font = new System.Drawing.Font("Calibri", 12F);
            this.LENGTH_updown.Location = new System.Drawing.Point(82, 7);
            this.LENGTH_updown.Margin = new System.Windows.Forms.Padding(0);
            this.LENGTH_updown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LENGTH_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LENGTH_updown.Name = "LENGTH_updown";
            this.LENGTH_updown.Size = new System.Drawing.Size(58, 27);
            this.LENGTH_updown.TabIndex = 4;
            this.LENGTH_updown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LENGTH_updown.ValueChanged += new System.EventHandler(this.LENGTH_updown_ValueChanged);
            // 
            // Quantity_panel
            // 
            this.Quantity_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel.SetColumnSpan(this.Quantity_panel, 3);
            this.Quantity_panel.Controls.Add(this.QUANTITY_label);
            this.Quantity_panel.Controls.Add(this.QUANTITY_updown);
            this.Quantity_panel.Controls.Add(this.QUANTITY_infinity);
            this.Quantity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Quantity_panel.Location = new System.Drawing.Point(4, 4);
            this.Quantity_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity_panel.Name = "Quantity_panel";
            this.Quantity_panel.Size = new System.Drawing.Size(476, 41);
            this.Quantity_panel.TabIndex = 6;
            // 
            // TYPE_panel
            // 
            this.TYPE_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel.SetColumnSpan(this.TYPE_panel, 3);
            this.TYPE_panel.Controls.Add(this.TYPE_label);
            this.TYPE_panel.Controls.Add(this.TYPE_doubleClick);
            this.TYPE_panel.Controls.Add(this.TYPE_select);
            this.TYPE_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TYPE_panel.ForeColor = System.Drawing.Color.Black;
            this.TYPE_panel.Location = new System.Drawing.Point(4, 94);
            this.TYPE_panel.Margin = new System.Windows.Forms.Padding(2);
            this.TYPE_panel.Name = "TYPE_panel";
            this.TYPE_panel.Size = new System.Drawing.Size(476, 41);
            this.TYPE_panel.TabIndex = 13;
            // 
            // TYPE_label
            // 
            this.TYPE_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.TYPE_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TYPE_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TYPE_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TYPE_label.Location = new System.Drawing.Point(0, 0);
            this.TYPE_label.Margin = new System.Windows.Forms.Padding(0);
            this.TYPE_label.Name = "TYPE_label";
            this.TYPE_label.Size = new System.Drawing.Size(78, 41);
            this.TYPE_label.TabIndex = 6;
            this.TYPE_label.Text = "Type";
            this.TYPE_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TYPE_select
            // 
            this.TYPE_select.BackColor = System.Drawing.Color.White;
            this.TYPE_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TYPE_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TYPE_select.Font = new System.Drawing.Font("Calibri", 12F);
            this.TYPE_select.ForeColor = System.Drawing.Color.Black;
            this.TYPE_select.FormattingEnabled = true;
            this.TYPE_select.Items.AddRange(new object[] {
            "Left",
            "Central",
            "Right"});
            this.TYPE_select.Location = new System.Drawing.Point(82, 7);
            this.TYPE_select.Margin = new System.Windows.Forms.Padding(0);
            this.TYPE_select.Name = "TYPE_select";
            this.TYPE_select.Size = new System.Drawing.Size(144, 27);
            this.TYPE_select.TabIndex = 10;
            this.TYPE_select.Tag = "";
            this.TYPE_select.SelectedIndexChanged += new System.EventHandler(this.TYPE_select_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 40);
            this.panel1.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.Text = "VirtualMouse";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANTITY_updown)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.LENGTH_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LENGTH_updown)).EndInit();
            this.Quantity_panel.ResumeLayout(false);
            this.TYPE_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_file;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_exit;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_help;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown QUANTITY_updown;
        private System.Windows.Forms.Label QUANTITY_label;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.CheckBox QUANTITY_infinity;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_about;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_repository;
        //private System.Windows.Forms.ToolStripSeparator Separator_help;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_window;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_AlwaysVisible;
        private System.Windows.Forms.ComboBox LENGTH_um;
        private System.Windows.Forms.CheckBox TYPE_doubleClick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel Quantity_panel;
        private System.Windows.Forms.Panel LENGTH_panel;
        private System.Windows.Forms.Label LENGTH_label;
        private System.Windows.Forms.NumericUpDown LENGTH_updown;
        private System.Windows.Forms.Panel TYPE_panel;
        private System.Windows.Forms.Label TYPE_label;
        private System.Windows.Forms.ComboBox TYPE_select;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.ToolStripMenuItem MenuItem_commands;
        //private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem resetValuesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        //private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

