namespace Presentacion1.UI_User.Login
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowUserAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSingIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccesUser = new Guna.UI2.WinForms.Guna2Button();
            this.tbShowPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtPassUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.guna2ShadowPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 549);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.btnShowUserAdmin);
            this.guna2ShadowPanel1.Controls.Add(this.btnSingIn);
            this.guna2ShadowPanel1.Controls.Add(this.btnAccesUser);
            this.guna2ShadowPanel1.Controls.Add(this.tbShowPass);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassUser);
            this.guna2ShadowPanel1.Controls.Add(this.txtUser);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(65, 172);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(286, 351);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            // 
            // btnShowUserAdmin
            // 
            this.btnShowUserAdmin.Animated = true;
            this.btnShowUserAdmin.AutoRoundedCorners = true;
            this.btnShowUserAdmin.BorderRadius = 12;
            this.btnShowUserAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUserAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUserAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowUserAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowUserAdmin.FillColor = System.Drawing.Color.Navy;
            this.btnShowUserAdmin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowUserAdmin.ForeColor = System.Drawing.Color.White;
            this.btnShowUserAdmin.IndicateFocus = true;
            this.btnShowUserAdmin.Location = new System.Drawing.Point(154, 311);
            this.btnShowUserAdmin.Name = "btnShowUserAdmin";
            this.btnShowUserAdmin.Size = new System.Drawing.Size(75, 26);
            this.btnShowUserAdmin.TabIndex = 5;
            this.btnShowUserAdmin.Text = "Admin";
            this.btnShowUserAdmin.UseTransparentBackground = true;
            this.btnShowUserAdmin.Click += new System.EventHandler(this.btnShowUserAdmin_Click);
            // 
            // btnSingIn
            // 
            this.btnSingIn.Animated = true;
            this.btnSingIn.AutoRoundedCorners = true;
            this.btnSingIn.BorderRadius = 15;
            this.btnSingIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSingIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSingIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSingIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSingIn.FillColor = System.Drawing.Color.Red;
            this.btnSingIn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSingIn.ForeColor = System.Drawing.Color.White;
            this.btnSingIn.IndicateFocus = true;
            this.btnSingIn.Location = new System.Drawing.Point(59, 273);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(170, 32);
            this.btnSingIn.TabIndex = 4;
            this.btnSingIn.Text = "Sing-In";
            this.btnSingIn.UseTransparentBackground = true;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // btnAccesUser
            // 
            this.btnAccesUser.Animated = true;
            this.btnAccesUser.AutoRoundedCorners = true;
            this.btnAccesUser.BorderRadius = 15;
            this.btnAccesUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccesUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccesUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccesUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccesUser.FillColor = System.Drawing.Color.Red;
            this.btnAccesUser.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAccesUser.ForeColor = System.Drawing.Color.White;
            this.btnAccesUser.IndicateFocus = true;
            this.btnAccesUser.Location = new System.Drawing.Point(59, 235);
            this.btnAccesUser.Name = "btnAccesUser";
            this.btnAccesUser.Size = new System.Drawing.Size(170, 32);
            this.btnAccesUser.TabIndex = 3;
            this.btnAccesUser.Text = "Access";
            this.btnAccesUser.UseTransparentBackground = true;
            this.btnAccesUser.Click += new System.EventHandler(this.btnAccesUser_Click);
            // 
            // tbShowPass
            // 
            this.tbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShowPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tbShowPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tbShowPass.Location = new System.Drawing.Point(33, 171);
            this.tbShowPass.Name = "tbShowPass";
            this.tbShowPass.Size = new System.Drawing.Size(59, 27);
            this.tbShowPass.TabIndex = 2;
            this.tbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbShowPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tbShowPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tbShowPass.CheckedChanged += new System.EventHandler(this.tbShowPass_CheckedChanged);
            // 
            // txtPassUser
            // 
            this.txtPassUser.BorderColor = System.Drawing.Color.White;
            this.txtPassUser.BorderRadius = 15;
            this.txtPassUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassUser.DefaultText = "";
            this.txtPassUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassUser.FillColor = System.Drawing.Color.Transparent;
            this.txtPassUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassUser.ForeColor = System.Drawing.Color.Silver;
            this.txtPassUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassUser.Location = new System.Drawing.Point(19, 121);
            this.txtPassUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.PasswordChar = '*';
            this.txtPassUser.PlaceholderText = "";
            this.txtPassUser.SelectedText = "";
            this.txtPassUser.Size = new System.Drawing.Size(250, 32);
            this.txtPassUser.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BorderRadius = 15;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.Transparent;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(19, 49);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(250, 32);
            this.txtUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUser";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnShowUserAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSingIn;
        private Guna.UI2.WinForms.Guna2Button btnAccesUser;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tbShowPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassUser;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}