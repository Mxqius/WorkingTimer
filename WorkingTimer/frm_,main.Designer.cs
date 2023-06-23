namespace WorkingTimer
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            this.bf_form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_action = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_minute = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_second = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bf_form
            // 
            this.bf_form.AnimateWindow = true;
            this.bf_form.BorderRadius = 15;
            this.bf_form.ContainerControl = this;
            this.bf_form.DockForm = false;
            this.bf_form.DockIndicatorTransparencyValue = 0.6D;
            this.bf_form.ResizeForm = false;
            this.bf_form.TransparentWhileDrag = true;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(47, 47);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(106, 34);
            this.lbl_timer.TabIndex = 1;
            this.lbl_timer.Text = "03:00";
            this.lbl_timer.DoubleClick += new System.EventHandler(this.lbl_timer_DoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_stop
            // 
            this.btn_stop.BorderThickness = 2;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stop.FillColor = System.Drawing.Color.Transparent;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = global::WorkingTimer.Properties.Resources.stop;
            this.btn_stop.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_stop.Location = new System.Drawing.Point(249, 43);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_stop.Size = new System.Drawing.Size(52, 47);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_action
            // 
            this.btn_action.BorderThickness = 2;
            this.btn_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_action.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_action.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_action.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_action.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_action.FillColor = System.Drawing.Color.Transparent;
            this.btn_action.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_action.ForeColor = System.Drawing.Color.White;
            this.btn_action.Image = global::WorkingTimer.Properties.Resources.start;
            this.btn_action.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_action.Location = new System.Drawing.Point(191, 43);
            this.btn_action.Name = "btn_action";
            this.btn_action.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_action.Size = new System.Drawing.Size(52, 47);
            this.btn_action.TabIndex = 2;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // txt_minute
            // 
            this.txt_minute.BorderRadius = 5;
            this.txt_minute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_minute.DefaultText = "";
            this.txt_minute.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_minute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_minute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_minute.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_minute.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_minute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_minute.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_minute.Location = new System.Drawing.Point(41, 42);
            this.txt_minute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_minute.MaxLength = 2;
            this.txt_minute.Name = "txt_minute";
            this.txt_minute.PasswordChar = '\0';
            this.txt_minute.PlaceholderText = "M";
            this.txt_minute.SelectedText = "";
            this.txt_minute.Size = new System.Drawing.Size(50, 48);
            this.txt_minute.TabIndex = 3;
            this.txt_minute.Visible = false;
            this.txt_minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_second_KeyPress);
            // 
            // txt_second
            // 
            this.txt_second.BorderRadius = 5;
            this.txt_second.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_second.DefaultText = "";
            this.txt_second.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_second.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_second.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_second.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_second.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_second.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_second.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_second.Location = new System.Drawing.Point(105, 42);
            this.txt_second.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_second.MaxLength = 2;
            this.txt_second.Name = "txt_second";
            this.txt_second.PasswordChar = '\0';
            this.txt_second.PlaceholderText = "S";
            this.txt_second.SelectedText = "";
            this.txt_second.Size = new System.Drawing.Size(50, 48);
            this.txt_second.TabIndex = 3;
            this.txt_second.Visible = false;
            this.txt_second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_second_KeyPress);
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_confirm.Location = new System.Drawing.Point(66, 103);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(68, 16);
            this.lbl_confirm.TabIndex = 4;
            this.lbl_confirm.Text = "CONFIRM";
            this.lbl_confirm.Visible = false;
            this.lbl_confirm.Click += new System.EventHandler(this.lbl_confirm_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(327, 131);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_minute);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.lbl_timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bf_form;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2CircleButton btn_action;
        private Guna.UI2.WinForms.Guna2CircleButton btn_stop;
        private Guna.UI2.WinForms.Guna2TextBox txt_minute;
        private Guna.UI2.WinForms.Guna2TextBox txt_second;
        private System.Windows.Forms.Label lbl_confirm;
    }
}

