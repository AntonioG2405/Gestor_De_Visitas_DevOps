namespace Presentacion1.UI_Admin.Login
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowUserLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccesAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.tbShowPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtPassAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(392, 548);
            this.guna2Panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.btnShowUserLogin);
            this.guna2ShadowPanel1.Controls.Add(this.btnAccesAdmin);
            this.guna2ShadowPanel1.Controls.Add(this.tbShowPass);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassAdmin);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserAdmin);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(55, 175);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(286, 351);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // btnShowUserLogin
            // 
            this.btnShowUserLogin.Animated = true;
            this.btnShowUserLogin.AutoRoundedCorners = true;
            this.btnShowUserLogin.BorderRadius = 12;
            this.btnShowUserLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUserLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUserLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowUserLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowUserLogin.FillColor = System.Drawing.Color.Red;
            this.btnShowUserLogin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowUserLogin.ForeColor = System.Drawing.Color.White;
            this.btnShowUserLogin.IndicateFocus = true;
            this.btnShowUserLogin.Location = new System.Drawing.Point(151, 297);
            this.btnShowUserLogin.Name = "btnShowUserLogin";
            this.btnShowUserLogin.Size = new System.Drawing.Size(75, 26);
            this.btnShowUserLogin.TabIndex = 5;
            this.btnShowUserLogin.Text = "Admin";
            this.btnShowUserLogin.UseTransparentBackground = true;
            this.btnShowUserLogin.Click += new System.EventHandler(this.btnShowUserLogin_Click);
            // 
            // btnAccesAdmin
            // 
            this.btnAccesAdmin.Animated = true;
            this.btnAccesAdmin.AutoRoundedCorners = true;
            this.btnAccesAdmin.BorderRadius = 15;
            this.btnAccesAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccesAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccesAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccesAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccesAdmin.FillColor = System.Drawing.Color.Navy;
            this.btnAccesAdmin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAccesAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAccesAdmin.IndicateFocus = true;
            this.btnAccesAdmin.Location = new System.Drawing.Point(56, 259);
            this.btnAccesAdmin.Name = "btnAccesAdmin";
            this.btnAccesAdmin.Size = new System.Drawing.Size(170, 32);
            this.btnAccesAdmin.TabIndex = 3;
            this.btnAccesAdmin.Text = "Access";
            this.btnAccesAdmin.UseTransparentBackground = true;
            this.btnAccesAdmin.Click += new System.EventHandler(this.btnAccesAdmin_Click);
            // 
            // tbShowPass
            // 
            this.tbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShowPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tbShowPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tbShowPass.Location = new System.Drawing.Point(31, 196);
            this.tbShowPass.Name = "tbShowPass";
            this.tbShowPass.Size = new System.Drawing.Size(59, 27);
            this.tbShowPass.TabIndex = 2;
            this.tbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbShowPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tbShowPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tbShowPass.CheckedChanged += new System.EventHandler(this.tbShowPass_CheckedChanged);
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.BorderColor = System.Drawing.Color.White;
            this.txtPassAdmin.BorderRadius = 15;
            this.txtPassAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassAdmin.DefaultText = "";
            this.txtPassAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassAdmin.FillColor = System.Drawing.Color.Transparent;
            this.txtPassAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAdmin.ForeColor = System.Drawing.Color.Silver;
            this.txtPassAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassAdmin.Location = new System.Drawing.Point(17, 146);
            this.txtPassAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '*';
            this.txtPassAdmin.PlaceholderText = "";
            this.txtPassAdmin.SelectedText = "";
            this.txtPassAdmin.Size = new System.Drawing.Size(250, 32);
            this.txtPassAdmin.TabIndex = 1;
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.BorderRadius = 15;
            this.txtUserAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserAdmin.DefaultText = "";
            this.txtUserAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAdmin.FillColor = System.Drawing.Color.Transparent;
            this.txtUserAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdmin.ForeColor = System.Drawing.Color.Silver;
            this.txtUserAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAdmin.Location = new System.Drawing.Point(17, 70);
            this.txtUserAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.PasswordChar = '\0';
            this.txtUserAdmin.PlaceholderText = "";
            this.txtUserAdmin.SelectedText = "";
            this.txtUserAdmin.Size = new System.Drawing.Size(250, 32);
            this.txtUserAdmin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 548);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnShowUserLogin;
        private Guna.UI2.WinForms.Guna2Button btnAccesAdmin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tbShowPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}