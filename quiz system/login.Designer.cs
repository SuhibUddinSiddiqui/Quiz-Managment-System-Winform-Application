namespace quiz_system
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.app_minimize_button = new MetroFramework.Controls.MetroButton();
            this.app_close_button = new MetroFramework.Controls.MetroButton();
            this.loadergif = new System.Windows.Forms.PictureBox();
            this.registerpanel = new System.Windows.Forms.Panel();
            this.uploadimage_button = new MetroFramework.Controls.MetroButton();
            this.register_retype_pass_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_pass_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.register_acc_button = new MetroFramework.Controls.MetroButton();
            this.register_email_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_name_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.login_rememberme_checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.login_acc_button = new MetroFramework.Controls.MetroButton();
            this.login_password_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username_textbox = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerpanel_show_button = new MetroFramework.Controls.MetroButton();
            this.loginpanel_show_button = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loader_reg = new System.Windows.Forms.Timer(this.components);
            this.loader_login = new System.Windows.Forms.Timer(this.components);
            this.student_radiobutton = new MetroFramework.Controls.MetroRadioButton();
            this.teacher_radiobutton = new MetroFramework.Controls.MetroRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadergif)).BeginInit();
            this.registerpanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.app_minimize_button);
            this.panel1.Controls.Add(this.app_close_button);
            this.panel1.Controls.Add(this.loadergif);
            this.panel1.Controls.Add(this.registerpanel);
            this.panel1.Controls.Add(this.loginpanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 492);
            this.panel1.TabIndex = 0;
            // 
            // app_minimize_button
            // 
            this.app_minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.app_minimize_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_minimize_window_24__2_;
            this.app_minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_minimize_button.Location = new System.Drawing.Point(507, 3);
            this.app_minimize_button.Name = "app_minimize_button";
            this.app_minimize_button.Size = new System.Drawing.Size(21, 23);
            this.app_minimize_button.TabIndex = 11;
            this.app_minimize_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.app_minimize_button.UseCustomBackColor = true;
            this.app_minimize_button.UseSelectable = true;
            this.app_minimize_button.Click += new System.EventHandler(this.app_minimize_button_Click);
            // 
            // app_close_button
            // 
            this.app_close_button.BackColor = System.Drawing.Color.Transparent;
            this.app_close_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_cancel_filled_50;
            this.app_close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_close_button.Location = new System.Drawing.Point(528, 3);
            this.app_close_button.Name = "app_close_button";
            this.app_close_button.Size = new System.Drawing.Size(21, 23);
            this.app_close_button.TabIndex = 10;
            this.app_close_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.app_close_button.UseCustomBackColor = true;
            this.app_close_button.UseSelectable = true;
            this.app_close_button.Click += new System.EventHandler(this.app_close_button_Click);
            // 
            // loadergif
            // 
            this.loadergif.Image = global::quiz_system.Properties.Resources.zjHl2lgef9cYrQL0JFa7kzbw2vuErRVKnh3K0zd9OXdE9g5shnN1i;
            this.loadergif.Location = new System.Drawing.Point(515, 458);
            this.loadergif.Name = "loadergif";
            this.loadergif.Size = new System.Drawing.Size(37, 34);
            this.loadergif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadergif.TabIndex = 9;
            this.loadergif.TabStop = false;
            this.loadergif.Visible = false;
            // 
            // registerpanel
            // 
            this.registerpanel.Controls.Add(this.teacher_radiobutton);
            this.registerpanel.Controls.Add(this.student_radiobutton);
            this.registerpanel.Controls.Add(this.uploadimage_button);
            this.registerpanel.Controls.Add(this.register_retype_pass_txtbox);
            this.registerpanel.Controls.Add(this.label7);
            this.registerpanel.Controls.Add(this.register_pass_txtbox);
            this.registerpanel.Controls.Add(this.label8);
            this.registerpanel.Controls.Add(this.register_acc_button);
            this.registerpanel.Controls.Add(this.register_email_txtbox);
            this.registerpanel.Controls.Add(this.label4);
            this.registerpanel.Controls.Add(this.register_name_txtbox);
            this.registerpanel.Controls.Add(this.label5);
            this.registerpanel.Controls.Add(this.label6);
            this.registerpanel.Location = new System.Drawing.Point(279, 102);
            this.registerpanel.Name = "registerpanel";
            this.registerpanel.Size = new System.Drawing.Size(270, 297);
            this.registerpanel.TabIndex = 8;
            this.registerpanel.Visible = false;
            // 
            // uploadimage_button
            // 
            this.uploadimage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.uploadimage_button.Location = new System.Drawing.Point(113, 239);
            this.uploadimage_button.Name = "uploadimage_button";
            this.uploadimage_button.Size = new System.Drawing.Size(80, 23);
            this.uploadimage_button.TabIndex = 5;
            this.uploadimage_button.Text = "Upload Image";
            this.uploadimage_button.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uploadimage_button.UseSelectable = true;
            this.uploadimage_button.Click += new System.EventHandler(this.uploadimage_button_Click);
            // 
            // register_retype_pass_txtbox
            // 
            // 
            // 
            // 
            this.register_retype_pass_txtbox.CustomButton.Image = null;
            this.register_retype_pass_txtbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.register_retype_pass_txtbox.CustomButton.Name = "";
            this.register_retype_pass_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.register_retype_pass_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_retype_pass_txtbox.CustomButton.TabIndex = 1;
            this.register_retype_pass_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.register_retype_pass_txtbox.CustomButton.UseSelectable = true;
            this.register_retype_pass_txtbox.CustomButton.Visible = false;
            this.register_retype_pass_txtbox.Lines = new string[0];
            this.register_retype_pass_txtbox.Location = new System.Drawing.Point(113, 210);
            this.register_retype_pass_txtbox.MaxLength = 32767;
            this.register_retype_pass_txtbox.Name = "register_retype_pass_txtbox";
            this.register_retype_pass_txtbox.PasswordChar = '*';
            this.register_retype_pass_txtbox.PromptText = "*****";
            this.register_retype_pass_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.register_retype_pass_txtbox.SelectedText = "";
            this.register_retype_pass_txtbox.SelectionLength = 0;
            this.register_retype_pass_txtbox.SelectionStart = 0;
            this.register_retype_pass_txtbox.ShortcutsEnabled = true;
            this.register_retype_pass_txtbox.Size = new System.Drawing.Size(142, 23);
            this.register_retype_pass_txtbox.TabIndex = 4;
            this.register_retype_pass_txtbox.UseSelectable = true;
            this.register_retype_pass_txtbox.WaterMark = "*****";
            this.register_retype_pass_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.register_retype_pass_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(4, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "RE-TYPE \r\nPASSWORD:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // register_pass_txtbox
            // 
            // 
            // 
            // 
            this.register_pass_txtbox.CustomButton.Image = null;
            this.register_pass_txtbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.register_pass_txtbox.CustomButton.Name = "";
            this.register_pass_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.register_pass_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_pass_txtbox.CustomButton.TabIndex = 1;
            this.register_pass_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.register_pass_txtbox.CustomButton.UseSelectable = true;
            this.register_pass_txtbox.CustomButton.Visible = false;
            this.register_pass_txtbox.Lines = new string[0];
            this.register_pass_txtbox.Location = new System.Drawing.Point(113, 154);
            this.register_pass_txtbox.MaxLength = 32767;
            this.register_pass_txtbox.Name = "register_pass_txtbox";
            this.register_pass_txtbox.PasswordChar = '*';
            this.register_pass_txtbox.PromptText = "*****";
            this.register_pass_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.register_pass_txtbox.SelectedText = "";
            this.register_pass_txtbox.SelectionLength = 0;
            this.register_pass_txtbox.SelectionStart = 0;
            this.register_pass_txtbox.ShortcutsEnabled = true;
            this.register_pass_txtbox.Size = new System.Drawing.Size(142, 23);
            this.register_pass_txtbox.TabIndex = 3;
            this.register_pass_txtbox.UseSelectable = true;
            this.register_pass_txtbox.WaterMark = "*****";
            this.register_pass_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.register_pass_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "PASSWORD:";
            // 
            // register_acc_button
            // 
            this.register_acc_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.register_acc_button.Location = new System.Drawing.Point(162, 271);
            this.register_acc_button.Name = "register_acc_button";
            this.register_acc_button.Size = new System.Drawing.Size(93, 23);
            this.register_acc_button.TabIndex = 6;
            this.register_acc_button.Text = "REGISTER";
            this.register_acc_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.register_acc_button.UseCustomBackColor = true;
            this.register_acc_button.UseSelectable = true;
            this.register_acc_button.Click += new System.EventHandler(this.register_acc_button_Click);
            // 
            // register_email_txtbox
            // 
            // 
            // 
            // 
            this.register_email_txtbox.CustomButton.Image = null;
            this.register_email_txtbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.register_email_txtbox.CustomButton.Name = "";
            this.register_email_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.register_email_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_email_txtbox.CustomButton.TabIndex = 1;
            this.register_email_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.register_email_txtbox.CustomButton.UseSelectable = true;
            this.register_email_txtbox.CustomButton.Visible = false;
            this.register_email_txtbox.Lines = new string[0];
            this.register_email_txtbox.Location = new System.Drawing.Point(113, 115);
            this.register_email_txtbox.MaxLength = 32767;
            this.register_email_txtbox.Name = "register_email_txtbox";
            this.register_email_txtbox.PasswordChar = '\0';
            this.register_email_txtbox.PromptText = "abcxyz@example.com";
            this.register_email_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.register_email_txtbox.SelectedText = "";
            this.register_email_txtbox.SelectionLength = 0;
            this.register_email_txtbox.SelectionStart = 0;
            this.register_email_txtbox.ShortcutsEnabled = true;
            this.register_email_txtbox.Size = new System.Drawing.Size(142, 23);
            this.register_email_txtbox.TabIndex = 2;
            this.register_email_txtbox.UseSelectable = true;
            this.register_email_txtbox.WaterMark = "abcxyz@example.com";
            this.register_email_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.register_email_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(41, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "EMAIL:";
            // 
            // register_name_txtbox
            // 
            // 
            // 
            // 
            this.register_name_txtbox.CustomButton.Image = null;
            this.register_name_txtbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.register_name_txtbox.CustomButton.Name = "";
            this.register_name_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.register_name_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_name_txtbox.CustomButton.TabIndex = 1;
            this.register_name_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.register_name_txtbox.CustomButton.UseSelectable = true;
            this.register_name_txtbox.CustomButton.Visible = false;
            this.register_name_txtbox.Lines = new string[0];
            this.register_name_txtbox.Location = new System.Drawing.Point(113, 76);
            this.register_name_txtbox.MaxLength = 32767;
            this.register_name_txtbox.Name = "register_name_txtbox";
            this.register_name_txtbox.PasswordChar = '\0';
            this.register_name_txtbox.PromptText = "abcxyz";
            this.register_name_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.register_name_txtbox.SelectedText = "";
            this.register_name_txtbox.SelectionLength = 0;
            this.register_name_txtbox.SelectionStart = 0;
            this.register_name_txtbox.ShortcutsEnabled = true;
            this.register_name_txtbox.Size = new System.Drawing.Size(142, 23);
            this.register_name_txtbox.TabIndex = 1;
            this.register_name_txtbox.UseSelectable = true;
            this.register_name_txtbox.WaterMark = "abcxyz";
            this.register_name_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.register_name_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(44, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "NAME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "REGISTER";
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.login_rememberme_checkbox);
            this.loginpanel.Controls.Add(this.login_acc_button);
            this.loginpanel.Controls.Add(this.login_password_txtbox);
            this.loginpanel.Controls.Add(this.label3);
            this.loginpanel.Controls.Add(this.login_username_textbox);
            this.loginpanel.Controls.Add(this.label2);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Location = new System.Drawing.Point(279, 117);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(270, 187);
            this.loginpanel.TabIndex = 7;
            // 
            // login_rememberme_checkbox
            // 
            this.login_rememberme_checkbox.AutoSize = true;
            this.login_rememberme_checkbox.Location = new System.Drawing.Point(118, 130);
            this.login_rememberme_checkbox.Name = "login_rememberme_checkbox";
            this.login_rememberme_checkbox.Size = new System.Drawing.Size(101, 15);
            this.login_rememberme_checkbox.TabIndex = 3;
            this.login_rememberme_checkbox.Text = "Remember Me";
            this.login_rememberme_checkbox.UseSelectable = true;
            // 
            // login_acc_button
            // 
            this.login_acc_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.login_acc_button.Location = new System.Drawing.Point(167, 151);
            this.login_acc_button.Name = "login_acc_button";
            this.login_acc_button.Size = new System.Drawing.Size(93, 23);
            this.login_acc_button.TabIndex = 4;
            this.login_acc_button.Text = "LOGIN";
            this.login_acc_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.login_acc_button.UseCustomBackColor = true;
            this.login_acc_button.UseSelectable = true;
            this.login_acc_button.Click += new System.EventHandler(this.login_acc_button_Click);
            // 
            // login_password_txtbox
            // 
            // 
            // 
            // 
            this.login_password_txtbox.CustomButton.Image = null;
            this.login_password_txtbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.login_password_txtbox.CustomButton.Name = "";
            this.login_password_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_password_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_password_txtbox.CustomButton.TabIndex = 1;
            this.login_password_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_password_txtbox.CustomButton.UseSelectable = true;
            this.login_password_txtbox.CustomButton.Visible = false;
            this.login_password_txtbox.Lines = new string[0];
            this.login_password_txtbox.Location = new System.Drawing.Point(118, 98);
            this.login_password_txtbox.MaxLength = 32767;
            this.login_password_txtbox.Name = "login_password_txtbox";
            this.login_password_txtbox.PasswordChar = '*';
            this.login_password_txtbox.PromptText = "*****";
            this.login_password_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_password_txtbox.SelectedText = "";
            this.login_password_txtbox.SelectionLength = 0;
            this.login_password_txtbox.SelectionStart = 0;
            this.login_password_txtbox.ShortcutsEnabled = true;
            this.login_password_txtbox.Size = new System.Drawing.Size(142, 23);
            this.login_password_txtbox.TabIndex = 2;
            this.login_password_txtbox.UseSelectable = true;
            this.login_password_txtbox.WaterMark = "*****";
            this.login_password_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_password_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "PASSWORD:";
            // 
            // login_username_textbox
            // 
            // 
            // 
            // 
            this.login_username_textbox.CustomButton.Image = null;
            this.login_username_textbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.login_username_textbox.CustomButton.Name = "";
            this.login_username_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_username_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_username_textbox.CustomButton.TabIndex = 1;
            this.login_username_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_username_textbox.CustomButton.UseSelectable = true;
            this.login_username_textbox.CustomButton.Visible = false;
            this.login_username_textbox.Lines = new string[0];
            this.login_username_textbox.Location = new System.Drawing.Point(118, 59);
            this.login_username_textbox.MaxLength = 32767;
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.PasswordChar = '\0';
            this.login_username_textbox.PromptText = "abcxyz@example.com";
            this.login_username_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_username_textbox.SelectedText = "";
            this.login_username_textbox.SelectionLength = 0;
            this.login_username_textbox.SelectionStart = 0;
            this.login_username_textbox.ShortcutsEnabled = true;
            this.login_username_textbox.Size = new System.Drawing.Size(142, 23);
            this.login_username_textbox.TabIndex = 1;
            this.login_username_textbox.UseSelectable = true;
            this.login_username_textbox.WaterMark = "abcxyz@example.com";
            this.login_username_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_username_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "USERNAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::quiz_system.Properties.Resources.images;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.registerpanel_show_button);
            this.panel2.Controls.Add(this.loginpanel_show_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 492);
            this.panel2.TabIndex = 0;
            // 
            // registerpanel_show_button
            // 
            this.registerpanel_show_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.registerpanel_show_button.Location = new System.Drawing.Point(84, 322);
            this.registerpanel_show_button.Name = "registerpanel_show_button";
            this.registerpanel_show_button.Size = new System.Drawing.Size(93, 23);
            this.registerpanel_show_button.TabIndex = 0;
            this.registerpanel_show_button.TabStop = false;
            this.registerpanel_show_button.Text = "REGISTER";
            this.registerpanel_show_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.registerpanel_show_button.UseCustomBackColor = true;
            this.registerpanel_show_button.UseSelectable = true;
            this.registerpanel_show_button.Click += new System.EventHandler(this.registerpanel_show_button_Click);
            // 
            // loginpanel_show_button
            // 
            this.loginpanel_show_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.loginpanel_show_button.Location = new System.Drawing.Point(84, 293);
            this.loginpanel_show_button.Name = "loginpanel_show_button";
            this.loginpanel_show_button.Size = new System.Drawing.Size(93, 23);
            this.loginpanel_show_button.TabIndex = 0;
            this.loginpanel_show_button.TabStop = false;
            this.loginpanel_show_button.Text = "LOGIN";
            this.loginpanel_show_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginpanel_show_button.UseCustomBackColor = true;
            this.loginpanel_show_button.UseSelectable = true;
            this.loginpanel_show_button.Click += new System.EventHandler(this.loginpanel_show_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::quiz_system.Properties.Resources.zjHl2lgef9cYrQL0JFa7kzbw2vuErRVKnh3K0zd9OXdE9g5shnN1i__;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loader_reg
            // 
            this.loader_reg.Interval = 500;
            this.loader_reg.Tick += new System.EventHandler(this.loader_Tick);
            // 
            // loader_login
            // 
            this.loader_login.Interval = 500;
            this.loader_login.Tick += new System.EventHandler(this.loader_login_Tick);
            // 
            // student_radiobutton
            // 
            this.student_radiobutton.AutoSize = true;
            this.student_radiobutton.Location = new System.Drawing.Point(8, 279);
            this.student_radiobutton.Name = "student_radiobutton";
            this.student_radiobutton.Size = new System.Drawing.Size(93, 15);
            this.student_radiobutton.TabIndex = 9;
            this.student_radiobutton.Text = "I\'m a Student";
            this.student_radiobutton.UseSelectable = true;
            // 
            // teacher_radiobutton
            // 
            this.teacher_radiobutton.AutoSize = true;
            this.teacher_radiobutton.Location = new System.Drawing.Point(8, 258);
            this.teacher_radiobutton.Name = "teacher_radiobutton";
            this.teacher_radiobutton.Size = new System.Drawing.Size(93, 15);
            this.teacher_radiobutton.TabIndex = 10;
            this.teacher_radiobutton.Text = "I\'m a Teacher";
            this.teacher_radiobutton.UseSelectable = true;
            this.teacher_radiobutton.CheckedChanged += new System.EventHandler(this.teacher_radiobutton_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(551, 496);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadergif)).EndInit();
            this.registerpanel.ResumeLayout(false);
            this.registerpanel.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton registerpanel_show_button;
        private MetroFramework.Controls.MetroButton loginpanel_show_button;
        private System.Windows.Forms.Panel loginpanel;
        private MetroFramework.Controls.MetroCheckBox login_rememberme_checkbox;
        private MetroFramework.Controls.MetroButton login_acc_button;
        private MetroFramework.Controls.MetroTextBox login_password_txtbox;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox login_username_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel registerpanel;
        private MetroFramework.Controls.MetroTextBox register_retype_pass_txtbox;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroButton register_acc_button;
        private MetroFramework.Controls.MetroTextBox register_email_txtbox;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox register_name_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton uploadimage_button;
        private MetroFramework.Controls.MetroTextBox register_pass_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox loadergif;
        private System.Windows.Forms.Timer loader_reg;
        private System.Windows.Forms.Timer loader_login;
        private MetroFramework.Controls.MetroButton app_minimize_button;
        private MetroFramework.Controls.MetroButton app_close_button;
        private MetroFramework.Controls.MetroRadioButton teacher_radiobutton;
        private MetroFramework.Controls.MetroRadioButton student_radiobutton;
    }
}

