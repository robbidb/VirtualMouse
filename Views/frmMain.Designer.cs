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
            this.btnStop = new System.Windows.Forms.Button();
            this.CLICKREPEAT_value = new System.Windows.Forms.NumericUpDown();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.CLICKOPTIONS_title = new System.Windows.Forms.Label();
            this.CLICKOPTIONS_panel = new System.Windows.Forms.Panel();
            this.CLICKOPTIONS_BUTTON_group = new System.Windows.Forms.GroupBox();
            this.CLICKOPTIONS_BUTTON_right = new System.Windows.Forms.RadioButton();
            this.CLICKOPTIONS_BUTTON_middle = new System.Windows.Forms.RadioButton();
            this.CLICKOPTIONS_BUTTON_left = new System.Windows.Forms.RadioButton();
            this.CLICKOPTIONS_TYPE_group = new System.Windows.Forms.GroupBox();
            this.CLICKOPTIONS_TYPE_double = new System.Windows.Forms.RadioButton();
            this.CLICKOPTIONS_TYPE_single = new System.Windows.Forms.RadioButton();
            this.CLICKREPEAT_panel = new System.Windows.Forms.Panel();
            this.CLICKREPEAT_rb_nolimits = new System.Windows.Forms.RadioButton();
            this.CLICKREPEAT_rb_repeat = new System.Windows.Forms.RadioButton();
            this.CLICKREPEAT_title = new System.Windows.Forms.Label();
            this.CLICKINTERVAL_panel = new System.Windows.Forms.Panel();
            this.CLICKINTERVAL_settime_mins_value = new System.Windows.Forms.TextBox();
            this.CLICKINTERVAL_settime_secs_value = new System.Windows.Forms.TextBox();
            this.CLICKINTERVAL_settime_millis_value = new System.Windows.Forms.TextBox();
            this.CLICKINTERVAL_settime_millis_label = new System.Windows.Forms.Label();
            this.CLICKINTERVAL_settime_secs_label = new System.Windows.Forms.Label();
            this.CLICKINTERVAL_settime_mins_label = new System.Windows.Forms.Label();
            this.CLICKINTERVAL_settime_hours_label = new System.Windows.Forms.Label();
            this.CLICKINTERVAL_settime_hours_value = new System.Windows.Forms.TextBox();
            this.CLICKINTERVAL_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CLICKREPEAT_value)).BeginInit();
            this.CLICKOPTIONS_panel.SuspendLayout();
            this.CLICKOPTIONS_BUTTON_group.SuspendLayout();
            this.CLICKOPTIONS_TYPE_group.SuspendLayout();
            this.CLICKREPEAT_panel.SuspendLayout();
            this.CLICKINTERVAL_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(170, 333);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(250, 333);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 36);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // CLICKREPEAT_value
            // 
            this.CLICKREPEAT_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLICKREPEAT_value.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKREPEAT_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKREPEAT_value.Location = new System.Drawing.Point(99, 32);
            this.CLICKREPEAT_value.Margin = new System.Windows.Forms.Padding(0);
            this.CLICKREPEAT_value.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CLICKREPEAT_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CLICKREPEAT_value.Name = "CLICKREPEAT_value";
            this.CLICKREPEAT_value.Size = new System.Drawing.Size(88, 27);
            this.CLICKREPEAT_value.TabIndex = 4;
            this.CLICKREPEAT_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CLICKREPEAT_value.ValueChanged += new System.EventHandler(this.CLICKREPEAT_value_ValueChanged);
            // 
            // TIMER
            // 
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(8, 333);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 36);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(401, 333);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CLICKOPTIONS_title
            // 
            this.CLICKOPTIONS_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.CLICKOPTIONS_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKOPTIONS_title.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_title.Location = new System.Drawing.Point(0, 0);
            this.CLICKOPTIONS_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CLICKOPTIONS_title.Name = "CLICKOPTIONS_title";
            this.CLICKOPTIONS_title.Size = new System.Drawing.Size(475, 24);
            this.CLICKOPTIONS_title.TabIndex = 679;
            this.CLICKOPTIONS_title.Text = "Click Options";
            this.CLICKOPTIONS_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLICKOPTIONS_panel
            // 
            this.CLICKOPTIONS_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLICKOPTIONS_panel.Controls.Add(this.CLICKOPTIONS_BUTTON_group);
            this.CLICKOPTIONS_panel.Controls.Add(this.CLICKOPTIONS_TYPE_group);
            this.CLICKOPTIONS_panel.Controls.Add(this.CLICKOPTIONS_title);
            this.CLICKOPTIONS_panel.Location = new System.Drawing.Point(4, 111);
            this.CLICKOPTIONS_panel.Name = "CLICKOPTIONS_panel";
            this.CLICKOPTIONS_panel.Size = new System.Drawing.Size(477, 95);
            this.CLICKOPTIONS_panel.TabIndex = 680;
            // 
            // CLICKOPTIONS_BUTTON_group
            // 
            this.CLICKOPTIONS_BUTTON_group.Controls.Add(this.CLICKOPTIONS_BUTTON_right);
            this.CLICKOPTIONS_BUTTON_group.Controls.Add(this.CLICKOPTIONS_BUTTON_middle);
            this.CLICKOPTIONS_BUTTON_group.Controls.Add(this.CLICKOPTIONS_BUTTON_left);
            this.CLICKOPTIONS_BUTTON_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_BUTTON_group.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CLICKOPTIONS_BUTTON_group.Location = new System.Drawing.Point(9, 27);
            this.CLICKOPTIONS_BUTTON_group.Name = "CLICKOPTIONS_BUTTON_group";
            this.CLICKOPTIONS_BUTTON_group.Size = new System.Drawing.Size(240, 55);
            this.CLICKOPTIONS_BUTTON_group.TabIndex = 681;
            this.CLICKOPTIONS_BUTTON_group.TabStop = false;
            this.CLICKOPTIONS_BUTTON_group.Text = "Mouse Button";
            // 
            // CLICKOPTIONS_BUTTON_right
            // 
            this.CLICKOPTIONS_BUTTON_right.Appearance = System.Windows.Forms.Appearance.Button;
            this.CLICKOPTIONS_BUTTON_right.BackColor = System.Drawing.Color.Silver;
            this.CLICKOPTIONS_BUTTON_right.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKOPTIONS_BUTTON_right.FlatAppearance.BorderSize = 0;
            this.CLICKOPTIONS_BUTTON_right.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_BUTTON_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKOPTIONS_BUTTON_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_BUTTON_right.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.CLICKOPTIONS_BUTTON_right.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_BUTTON_right.Location = new System.Drawing.Point(165, 20);
            this.CLICKOPTIONS_BUTTON_right.Name = "CLICKOPTIONS_BUTTON_right";
            this.CLICKOPTIONS_BUTTON_right.Size = new System.Drawing.Size(70, 28);
            this.CLICKOPTIONS_BUTTON_right.TabIndex = 2;
            this.CLICKOPTIONS_BUTTON_right.TabStop = true;
            this.CLICKOPTIONS_BUTTON_right.Text = "Right";
            this.CLICKOPTIONS_BUTTON_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLICKOPTIONS_BUTTON_right.UseVisualStyleBackColor = false;
            this.CLICKOPTIONS_BUTTON_right.CheckedChanged += new System.EventHandler(this.CLICKOPTIONS_BUTTON_CheckedChanged);
            // 
            // CLICKOPTIONS_BUTTON_middle
            // 
            this.CLICKOPTIONS_BUTTON_middle.Appearance = System.Windows.Forms.Appearance.Button;
            this.CLICKOPTIONS_BUTTON_middle.BackColor = System.Drawing.Color.Silver;
            this.CLICKOPTIONS_BUTTON_middle.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKOPTIONS_BUTTON_middle.FlatAppearance.BorderSize = 0;
            this.CLICKOPTIONS_BUTTON_middle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_BUTTON_middle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKOPTIONS_BUTTON_middle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_BUTTON_middle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.CLICKOPTIONS_BUTTON_middle.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_BUTTON_middle.Location = new System.Drawing.Point(85, 20);
            this.CLICKOPTIONS_BUTTON_middle.Name = "CLICKOPTIONS_BUTTON_middle";
            this.CLICKOPTIONS_BUTTON_middle.Size = new System.Drawing.Size(70, 28);
            this.CLICKOPTIONS_BUTTON_middle.TabIndex = 1;
            this.CLICKOPTIONS_BUTTON_middle.TabStop = true;
            this.CLICKOPTIONS_BUTTON_middle.Text = "Middle";
            this.CLICKOPTIONS_BUTTON_middle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLICKOPTIONS_BUTTON_middle.UseVisualStyleBackColor = false;
            this.CLICKOPTIONS_BUTTON_middle.CheckedChanged += new System.EventHandler(this.CLICKOPTIONS_BUTTON_CheckedChanged);
            // 
            // CLICKOPTIONS_BUTTON_left
            // 
            this.CLICKOPTIONS_BUTTON_left.Appearance = System.Windows.Forms.Appearance.Button;
            this.CLICKOPTIONS_BUTTON_left.BackColor = System.Drawing.Color.Silver;
            this.CLICKOPTIONS_BUTTON_left.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKOPTIONS_BUTTON_left.FlatAppearance.BorderSize = 0;
            this.CLICKOPTIONS_BUTTON_left.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_BUTTON_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKOPTIONS_BUTTON_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_BUTTON_left.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKOPTIONS_BUTTON_left.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_BUTTON_left.Location = new System.Drawing.Point(5, 20);
            this.CLICKOPTIONS_BUTTON_left.Margin = new System.Windows.Forms.Padding(0);
            this.CLICKOPTIONS_BUTTON_left.Name = "CLICKOPTIONS_BUTTON_left";
            this.CLICKOPTIONS_BUTTON_left.Size = new System.Drawing.Size(70, 28);
            this.CLICKOPTIONS_BUTTON_left.TabIndex = 0;
            this.CLICKOPTIONS_BUTTON_left.TabStop = true;
            this.CLICKOPTIONS_BUTTON_left.Text = "Left";
            this.CLICKOPTIONS_BUTTON_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLICKOPTIONS_BUTTON_left.UseVisualStyleBackColor = false;
            this.CLICKOPTIONS_BUTTON_left.CheckedChanged += new System.EventHandler(this.CLICKOPTIONS_BUTTON_CheckedChanged);
            // 
            // CLICKOPTIONS_TYPE_group
            // 
            this.CLICKOPTIONS_TYPE_group.Controls.Add(this.CLICKOPTIONS_TYPE_double);
            this.CLICKOPTIONS_TYPE_group.Controls.Add(this.CLICKOPTIONS_TYPE_single);
            this.CLICKOPTIONS_TYPE_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_TYPE_group.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CLICKOPTIONS_TYPE_group.Location = new System.Drawing.Point(284, 27);
            this.CLICKOPTIONS_TYPE_group.Name = "CLICKOPTIONS_TYPE_group";
            this.CLICKOPTIONS_TYPE_group.Size = new System.Drawing.Size(161, 55);
            this.CLICKOPTIONS_TYPE_group.TabIndex = 680;
            this.CLICKOPTIONS_TYPE_group.TabStop = false;
            this.CLICKOPTIONS_TYPE_group.Text = "Click Type";
            // 
            // CLICKOPTIONS_TYPE_double
            // 
            this.CLICKOPTIONS_TYPE_double.Appearance = System.Windows.Forms.Appearance.Button;
            this.CLICKOPTIONS_TYPE_double.BackColor = System.Drawing.Color.Silver;
            this.CLICKOPTIONS_TYPE_double.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKOPTIONS_TYPE_double.FlatAppearance.BorderSize = 0;
            this.CLICKOPTIONS_TYPE_double.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_TYPE_double.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKOPTIONS_TYPE_double.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_TYPE_double.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.CLICKOPTIONS_TYPE_double.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_TYPE_double.Location = new System.Drawing.Point(85, 20);
            this.CLICKOPTIONS_TYPE_double.Name = "CLICKOPTIONS_TYPE_double";
            this.CLICKOPTIONS_TYPE_double.Size = new System.Drawing.Size(70, 28);
            this.CLICKOPTIONS_TYPE_double.TabIndex = 1;
            this.CLICKOPTIONS_TYPE_double.TabStop = true;
            this.CLICKOPTIONS_TYPE_double.Text = "Double";
            this.CLICKOPTIONS_TYPE_double.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLICKOPTIONS_TYPE_double.UseVisualStyleBackColor = false;
            this.CLICKOPTIONS_TYPE_double.CheckedChanged += new System.EventHandler(this.CLICKOPTIONS_TYPE_CheckedChanged);
            // 
            // CLICKOPTIONS_TYPE_single
            // 
            this.CLICKOPTIONS_TYPE_single.Appearance = System.Windows.Forms.Appearance.Button;
            this.CLICKOPTIONS_TYPE_single.BackColor = System.Drawing.Color.Silver;
            this.CLICKOPTIONS_TYPE_single.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKOPTIONS_TYPE_single.FlatAppearance.BorderSize = 0;
            this.CLICKOPTIONS_TYPE_single.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKOPTIONS_TYPE_single.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKOPTIONS_TYPE_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLICKOPTIONS_TYPE_single.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKOPTIONS_TYPE_single.ForeColor = System.Drawing.Color.White;
            this.CLICKOPTIONS_TYPE_single.Location = new System.Drawing.Point(5, 20);
            this.CLICKOPTIONS_TYPE_single.Margin = new System.Windows.Forms.Padding(0);
            this.CLICKOPTIONS_TYPE_single.Name = "CLICKOPTIONS_TYPE_single";
            this.CLICKOPTIONS_TYPE_single.Size = new System.Drawing.Size(70, 28);
            this.CLICKOPTIONS_TYPE_single.TabIndex = 0;
            this.CLICKOPTIONS_TYPE_single.TabStop = true;
            this.CLICKOPTIONS_TYPE_single.Text = "Single";
            this.CLICKOPTIONS_TYPE_single.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLICKOPTIONS_TYPE_single.UseVisualStyleBackColor = false;
            this.CLICKOPTIONS_TYPE_single.CheckedChanged += new System.EventHandler(this.CLICKOPTIONS_TYPE_CheckedChanged);
            // 
            // CLICKREPEAT_panel
            // 
            this.CLICKREPEAT_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLICKREPEAT_panel.Controls.Add(this.CLICKREPEAT_rb_nolimits);
            this.CLICKREPEAT_panel.Controls.Add(this.CLICKREPEAT_value);
            this.CLICKREPEAT_panel.Controls.Add(this.CLICKREPEAT_rb_repeat);
            this.CLICKREPEAT_panel.Controls.Add(this.CLICKREPEAT_title);
            this.CLICKREPEAT_panel.Location = new System.Drawing.Point(279, 8);
            this.CLICKREPEAT_panel.Name = "CLICKREPEAT_panel";
            this.CLICKREPEAT_panel.Size = new System.Drawing.Size(202, 97);
            this.CLICKREPEAT_panel.TabIndex = 681;
            // 
            // CLICKREPEAT_rb_nolimits
            // 
            this.CLICKREPEAT_rb_nolimits.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKREPEAT_rb_nolimits.FlatAppearance.BorderSize = 0;
            this.CLICKREPEAT_rb_nolimits.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKREPEAT_rb_nolimits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKREPEAT_rb_nolimits.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CLICKREPEAT_rb_nolimits.ForeColor = System.Drawing.Color.Black;
            this.CLICKREPEAT_rb_nolimits.Location = new System.Drawing.Point(9, 61);
            this.CLICKREPEAT_rb_nolimits.Name = "CLICKREPEAT_rb_nolimits";
            this.CLICKREPEAT_rb_nolimits.Size = new System.Drawing.Size(90, 28);
            this.CLICKREPEAT_rb_nolimits.TabIndex = 1;
            this.CLICKREPEAT_rb_nolimits.TabStop = true;
            this.CLICKREPEAT_rb_nolimits.Text = "No Limits";
            this.CLICKREPEAT_rb_nolimits.UseVisualStyleBackColor = false;
            this.CLICKREPEAT_rb_nolimits.CheckedChanged += new System.EventHandler(this.CLICKREPEAT_rb_CheckedChanged);
            // 
            // CLICKREPEAT_rb_repeat
            // 
            this.CLICKREPEAT_rb_repeat.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKREPEAT_rb_repeat.FlatAppearance.BorderSize = 0;
            this.CLICKREPEAT_rb_repeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKREPEAT_rb_repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLICKREPEAT_rb_repeat.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CLICKREPEAT_rb_repeat.ForeColor = System.Drawing.Color.Black;
            this.CLICKREPEAT_rb_repeat.Location = new System.Drawing.Point(9, 30);
            this.CLICKREPEAT_rb_repeat.Margin = new System.Windows.Forms.Padding(0);
            this.CLICKREPEAT_rb_repeat.Name = "CLICKREPEAT_rb_repeat";
            this.CLICKREPEAT_rb_repeat.Size = new System.Drawing.Size(90, 28);
            this.CLICKREPEAT_rb_repeat.TabIndex = 0;
            this.CLICKREPEAT_rb_repeat.TabStop = true;
            this.CLICKREPEAT_rb_repeat.Text = "Repeat";
            this.CLICKREPEAT_rb_repeat.UseVisualStyleBackColor = false;
            this.CLICKREPEAT_rb_repeat.CheckedChanged += new System.EventHandler(this.CLICKREPEAT_rb_CheckedChanged);
            // 
            // CLICKREPEAT_title
            // 
            this.CLICKREPEAT_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKREPEAT_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.CLICKREPEAT_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKREPEAT_title.ForeColor = System.Drawing.Color.White;
            this.CLICKREPEAT_title.Location = new System.Drawing.Point(0, 0);
            this.CLICKREPEAT_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CLICKREPEAT_title.Name = "CLICKREPEAT_title";
            this.CLICKREPEAT_title.Size = new System.Drawing.Size(200, 24);
            this.CLICKREPEAT_title.TabIndex = 679;
            this.CLICKREPEAT_title.Text = "Click Repeat";
            this.CLICKREPEAT_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLICKINTERVAL_panel
            // 
            this.CLICKINTERVAL_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_mins_value);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_secs_value);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_millis_value);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_millis_label);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_secs_label);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_mins_label);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_hours_label);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_settime_hours_value);
            this.CLICKINTERVAL_panel.Controls.Add(this.CLICKINTERVAL_title);
            this.CLICKINTERVAL_panel.Location = new System.Drawing.Point(4, 8);
            this.CLICKINTERVAL_panel.Name = "CLICKINTERVAL_panel";
            this.CLICKINTERVAL_panel.Size = new System.Drawing.Size(260, 97);
            this.CLICKINTERVAL_panel.TabIndex = 682;
            // 
            // CLICKINTERVAL_settime_mins_value
            // 
            this.CLICKINTERVAL_settime_mins_value.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_mins_value.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_mins_value.Location = new System.Drawing.Point(74, 27);
            this.CLICKINTERVAL_settime_mins_value.MaxLength = 60;
            this.CLICKINTERVAL_settime_mins_value.Name = "CLICKINTERVAL_settime_mins_value";
            this.CLICKINTERVAL_settime_mins_value.Size = new System.Drawing.Size(50, 27);
            this.CLICKINTERVAL_settime_mins_value.TabIndex = 687;
            this.CLICKINTERVAL_settime_mins_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLICKINTERVAL_settime_mins_value.TextChanged += new System.EventHandler(this.CLICKINTERVAL_settime_mins_TextChanged);
            // 
            // CLICKINTERVAL_settime_secs_value
            // 
            this.CLICKINTERVAL_settime_secs_value.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_secs_value.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_secs_value.Location = new System.Drawing.Point(134, 27);
            this.CLICKINTERVAL_settime_secs_value.MaxLength = 60;
            this.CLICKINTERVAL_settime_secs_value.Name = "CLICKINTERVAL_settime_secs_value";
            this.CLICKINTERVAL_settime_secs_value.Size = new System.Drawing.Size(50, 27);
            this.CLICKINTERVAL_settime_secs_value.TabIndex = 686;
            this.CLICKINTERVAL_settime_secs_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLICKINTERVAL_settime_secs_value.TextChanged += new System.EventHandler(this.CLICKINTERVAL_settime_secs_TextChanged);
            // 
            // CLICKINTERVAL_settime_millis_value
            // 
            this.CLICKINTERVAL_settime_millis_value.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_millis_value.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_millis_value.Location = new System.Drawing.Point(194, 27);
            this.CLICKINTERVAL_settime_millis_value.MaxLength = 1000;
            this.CLICKINTERVAL_settime_millis_value.Name = "CLICKINTERVAL_settime_millis_value";
            this.CLICKINTERVAL_settime_millis_value.Size = new System.Drawing.Size(50, 27);
            this.CLICKINTERVAL_settime_millis_value.TabIndex = 685;
            this.CLICKINTERVAL_settime_millis_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLICKINTERVAL_settime_millis_value.TextChanged += new System.EventHandler(this.CLICKINTERVAL_settime_millis_TextChanged);
            // 
            // CLICKINTERVAL_settime_millis_label
            // 
            this.CLICKINTERVAL_settime_millis_label.AutoSize = true;
            this.CLICKINTERVAL_settime_millis_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_millis_label.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_millis_label.Location = new System.Drawing.Point(195, 57);
            this.CLICKINTERVAL_settime_millis_label.Name = "CLICKINTERVAL_settime_millis_label";
            this.CLICKINTERVAL_settime_millis_label.Size = new System.Drawing.Size(49, 19);
            this.CLICKINTERVAL_settime_millis_label.TabIndex = 684;
            this.CLICKINTERVAL_settime_millis_label.Text = "Millis.";
            // 
            // CLICKINTERVAL_settime_secs_label
            // 
            this.CLICKINTERVAL_settime_secs_label.AutoSize = true;
            this.CLICKINTERVAL_settime_secs_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_secs_label.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_secs_label.Location = new System.Drawing.Point(138, 57);
            this.CLICKINTERVAL_settime_secs_label.Name = "CLICKINTERVAL_settime_secs_label";
            this.CLICKINTERVAL_settime_secs_label.Size = new System.Drawing.Size(42, 19);
            this.CLICKINTERVAL_settime_secs_label.TabIndex = 683;
            this.CLICKINTERVAL_settime_secs_label.Text = "Secs.";
            // 
            // CLICKINTERVAL_settime_mins_label
            // 
            this.CLICKINTERVAL_settime_mins_label.AutoSize = true;
            this.CLICKINTERVAL_settime_mins_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_mins_label.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_mins_label.Location = new System.Drawing.Point(75, 57);
            this.CLICKINTERVAL_settime_mins_label.Name = "CLICKINTERVAL_settime_mins_label";
            this.CLICKINTERVAL_settime_mins_label.Size = new System.Drawing.Size(45, 19);
            this.CLICKINTERVAL_settime_mins_label.TabIndex = 682;
            this.CLICKINTERVAL_settime_mins_label.Text = "Mins.";
            // 
            // CLICKINTERVAL_settime_hours_label
            // 
            this.CLICKINTERVAL_settime_hours_label.AutoSize = true;
            this.CLICKINTERVAL_settime_hours_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_hours_label.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_hours_label.Location = new System.Drawing.Point(16, 57);
            this.CLICKINTERVAL_settime_hours_label.Name = "CLICKINTERVAL_settime_hours_label";
            this.CLICKINTERVAL_settime_hours_label.Size = new System.Drawing.Size(47, 19);
            this.CLICKINTERVAL_settime_hours_label.TabIndex = 681;
            this.CLICKINTERVAL_settime_hours_label.Text = "Hours";
            // 
            // CLICKINTERVAL_settime_hours_value
            // 
            this.CLICKINTERVAL_settime_hours_value.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLICKINTERVAL_settime_hours_value.Font = new System.Drawing.Font("Calibri", 12F);
            this.CLICKINTERVAL_settime_hours_value.Location = new System.Drawing.Point(14, 27);
            this.CLICKINTERVAL_settime_hours_value.Name = "CLICKINTERVAL_settime_hours_value";
            this.CLICKINTERVAL_settime_hours_value.Size = new System.Drawing.Size(50, 27);
            this.CLICKINTERVAL_settime_hours_value.TabIndex = 680;
            this.CLICKINTERVAL_settime_hours_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLICKINTERVAL_settime_hours_value.TextChanged += new System.EventHandler(this.CLICKINTERVAL_settime_hours_TextChanged);
            // 
            // CLICKINTERVAL_title
            // 
            this.CLICKINTERVAL_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(252)))));
            this.CLICKINTERVAL_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.CLICKINTERVAL_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLICKINTERVAL_title.ForeColor = System.Drawing.Color.White;
            this.CLICKINTERVAL_title.Location = new System.Drawing.Point(0, 0);
            this.CLICKINTERVAL_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CLICKINTERVAL_title.Name = "CLICKINTERVAL_title";
            this.CLICKINTERVAL_title.Size = new System.Drawing.Size(258, 24);
            this.CLICKINTERVAL_title.TabIndex = 679;
            this.CLICKINTERVAL_title.Text = "Click Interval";
            this.CLICKINTERVAL_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 377);
            this.Controls.Add(this.CLICKINTERVAL_panel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.CLICKREPEAT_panel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.CLICKOPTIONS_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.Text = "VirtualMouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLICKREPEAT_value)).EndInit();
            this.CLICKOPTIONS_panel.ResumeLayout(false);
            this.CLICKOPTIONS_BUTTON_group.ResumeLayout(false);
            this.CLICKOPTIONS_TYPE_group.ResumeLayout(false);
            this.CLICKREPEAT_panel.ResumeLayout(false);
            this.CLICKINTERVAL_panel.ResumeLayout(false);
            this.CLICKINTERVAL_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown CLICKREPEAT_value;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label CLICKOPTIONS_title;
        private System.Windows.Forms.Panel CLICKOPTIONS_panel;
        private System.Windows.Forms.GroupBox CLICKOPTIONS_BUTTON_group;
        private System.Windows.Forms.RadioButton CLICKOPTIONS_BUTTON_right;
        private System.Windows.Forms.RadioButton CLICKOPTIONS_BUTTON_middle;
        private System.Windows.Forms.RadioButton CLICKOPTIONS_BUTTON_left;
        private System.Windows.Forms.GroupBox CLICKOPTIONS_TYPE_group;
        private System.Windows.Forms.RadioButton CLICKOPTIONS_TYPE_double;
        private System.Windows.Forms.RadioButton CLICKOPTIONS_TYPE_single;
        private System.Windows.Forms.Panel CLICKREPEAT_panel;
        private System.Windows.Forms.RadioButton CLICKREPEAT_rb_nolimits;
        private System.Windows.Forms.RadioButton CLICKREPEAT_rb_repeat;
        private System.Windows.Forms.Label CLICKREPEAT_title;
        private System.Windows.Forms.Panel CLICKINTERVAL_panel;
        private System.Windows.Forms.Label CLICKINTERVAL_title;
        private System.Windows.Forms.Label CLICKINTERVAL_settime_millis_label;
        private System.Windows.Forms.Label CLICKINTERVAL_settime_secs_label;
        private System.Windows.Forms.Label CLICKINTERVAL_settime_mins_label;
        private System.Windows.Forms.Label CLICKINTERVAL_settime_hours_label;
        private System.Windows.Forms.TextBox CLICKINTERVAL_settime_hours_value;
        private System.Windows.Forms.TextBox CLICKINTERVAL_settime_mins_value;
        private System.Windows.Forms.TextBox CLICKINTERVAL_settime_secs_value;
        private System.Windows.Forms.TextBox CLICKINTERVAL_settime_millis_value;
    }
}

