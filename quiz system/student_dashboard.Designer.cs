namespace quiz_system
{
    partial class student_dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_panel = new System.Windows.Forms.Panel();
            this.app_minimize_button = new MetroFramework.Controls.MetroButton();
            this.app_close_button = new MetroFramework.Controls.MetroButton();
            this.user_history_panel = new System.Windows.Forms.Panel();
            this.test_history_gridview = new System.Windows.Forms.DataGridView();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.user_profile_panel = new System.Windows.Forms.Panel();
            this.No_Of_tests_label = new System.Windows.Forms.Label();
            this.Last_Signed_Label = new System.Windows.Forms.Label();
            this.Percentage_Label = new System.Windows.Forms.Label();
            this.Grade_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.user_quiz_panel = new System.Windows.Forms.Panel();
            this.changesubject_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Start_quiz_button = new MetroFramework.Controls.MetroButton();
            this.quiz_code_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.teacher_quiz_button = new MetroFramework.Controls.MetroButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Select_quiz_button = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.slider_dashboard_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.logout_button = new MetroFramework.Controls.MetroButton();
            this.leaderboard_button = new MetroFramework.Controls.MetroButton();
            this.Dashboard_button = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.user_panel.SuspendLayout();
            this.user_history_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_history_gridview)).BeginInit();
            this.user_profile_panel.SuspendLayout();
            this.user_quiz_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.slider_dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.user_panel);
            this.panel1.Controls.Add(this.slider_dashboard_panel);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 548);
            this.panel1.TabIndex = 0;
            // 
            // user_panel
            // 
            this.user_panel.AutoScroll = true;
            this.user_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.user_panel.BackColor = System.Drawing.Color.Black;
            this.user_panel.BackgroundImage = global::quiz_system.Properties.Resources.gradient_wallpaper_18;
            this.user_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_panel.CausesValidation = false;
            this.user_panel.Controls.Add(this.app_minimize_button);
            this.user_panel.Controls.Add(this.app_close_button);
            this.user_panel.Controls.Add(this.user_history_panel);
            this.user_panel.Controls.Add(this.user_profile_panel);
            this.user_panel.Controls.Add(this.title_label);
            this.user_panel.Controls.Add(this.user_quiz_panel);
            this.user_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_panel.ForeColor = System.Drawing.Color.Silver;
            this.user_panel.Location = new System.Drawing.Point(52, 0);
            this.user_panel.Margin = new System.Windows.Forms.Padding(0);
            this.user_panel.Name = "user_panel";
            this.user_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_panel.Size = new System.Drawing.Size(800, 548);
            this.user_panel.TabIndex = 2;
            // 
            // app_minimize_button
            // 
            this.app_minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.app_minimize_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_minimize_window_24__2_;
            this.app_minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_minimize_button.Location = new System.Drawing.Point(755, 3);
            this.app_minimize_button.Name = "app_minimize_button";
            this.app_minimize_button.Size = new System.Drawing.Size(21, 23);
            this.app_minimize_button.TabIndex = 13;
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
            this.app_close_button.Location = new System.Drawing.Point(776, 3);
            this.app_close_button.Name = "app_close_button";
            this.app_close_button.Size = new System.Drawing.Size(21, 23);
            this.app_close_button.TabIndex = 12;
            this.app_close_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.app_close_button.UseCustomBackColor = true;
            this.app_close_button.UseSelectable = true;
            this.app_close_button.Click += new System.EventHandler(this.app_close_button_Click);
            // 
            // user_history_panel
            // 
            this.user_history_panel.BackColor = System.Drawing.Color.Transparent;
            this.user_history_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_history_panel.Controls.Add(this.test_history_gridview);
            this.user_history_panel.Controls.Add(this.label20);
            this.user_history_panel.Location = new System.Drawing.Point(12, 264);
            this.user_history_panel.Name = "user_history_panel";
            this.user_history_panel.Size = new System.Drawing.Size(774, 266);
            this.user_history_panel.TabIndex = 3;
            // 
            // test_history_gridview
            // 
            this.test_history_gridview.AllowUserToAddRows = false;
            this.test_history_gridview.AllowUserToDeleteRows = false;
            this.test_history_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.test_history_gridview.BackgroundColor = System.Drawing.Color.Black;
            this.test_history_gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.test_history_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.test_history_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.test_history_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE,
            this.TYPE,
            this.SUBJECT,
            this.MARKS});
            this.test_history_gridview.GridColor = System.Drawing.Color.Gray;
            this.test_history_gridview.Location = new System.Drawing.Point(3, 33);
            this.test_history_gridview.Name = "test_history_gridview";
            this.test_history_gridview.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.test_history_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gray;
            this.test_history_gridview.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.test_history_gridview.Size = new System.Drawing.Size(759, 226);
            this.test_history_gridview.TabIndex = 25;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE:";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TYPE:";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            // 
            // SUBJECT
            // 
            this.SUBJECT.HeaderText = "SUBJECT:";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.ReadOnly = true;
            // 
            // MARKS
            // 
            this.MARKS.HeaderText = "MARKS:";
            this.MARKS.Name = "MARKS";
            this.MARKS.ReadOnly = true;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(3, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 27);
            this.label20.TabIndex = 24;
            this.label20.Text = "HISTORY:";
            // 
            // user_profile_panel
            // 
            this.user_profile_panel.BackColor = System.Drawing.Color.Transparent;
            this.user_profile_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_profile_panel.Controls.Add(this.No_Of_tests_label);
            this.user_profile_panel.Controls.Add(this.Last_Signed_Label);
            this.user_profile_panel.Controls.Add(this.Percentage_Label);
            this.user_profile_panel.Controls.Add(this.Grade_label);
            this.user_profile_panel.Controls.Add(this.label15);
            this.user_profile_panel.Controls.Add(this.label14);
            this.user_profile_panel.Controls.Add(this.label13);
            this.user_profile_panel.Controls.Add(this.label11);
            this.user_profile_panel.Controls.Add(this.label10);
            this.user_profile_panel.Location = new System.Drawing.Point(535, 66);
            this.user_profile_panel.Name = "user_profile_panel";
            this.user_profile_panel.Size = new System.Drawing.Size(251, 192);
            this.user_profile_panel.TabIndex = 2;
            // 
            // No_Of_tests_label
            // 
            this.No_Of_tests_label.AutoSize = true;
            this.No_Of_tests_label.BackColor = System.Drawing.Color.Transparent;
            this.No_Of_tests_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Of_tests_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.No_Of_tests_label.Location = new System.Drawing.Point(177, 97);
            this.No_Of_tests_label.Name = "No_Of_tests_label";
            this.No_Of_tests_label.Size = new System.Drawing.Size(15, 16);
            this.No_Of_tests_label.TabIndex = 29;
            this.No_Of_tests_label.Text = "0";
            this.No_Of_tests_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Last_Signed_Label
            // 
            this.Last_Signed_Label.AutoSize = true;
            this.Last_Signed_Label.BackColor = System.Drawing.Color.Transparent;
            this.Last_Signed_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Signed_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Last_Signed_Label.Location = new System.Drawing.Point(177, 78);
            this.Last_Signed_Label.Name = "Last_Signed_Label";
            this.Last_Signed_Label.Size = new System.Drawing.Size(15, 16);
            this.Last_Signed_Label.TabIndex = 29;
            this.Last_Signed_Label.Text = "0";
            this.Last_Signed_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Percentage_Label
            // 
            this.Percentage_Label.AutoSize = true;
            this.Percentage_Label.BackColor = System.Drawing.Color.Transparent;
            this.Percentage_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Percentage_Label.Location = new System.Drawing.Point(177, 59);
            this.Percentage_Label.Name = "Percentage_Label";
            this.Percentage_Label.Size = new System.Drawing.Size(15, 16);
            this.Percentage_Label.TabIndex = 29;
            this.Percentage_Label.Text = "0";
            this.Percentage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grade_label
            // 
            this.Grade_label.AutoSize = true;
            this.Grade_label.BackColor = System.Drawing.Color.Transparent;
            this.Grade_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grade_label.Location = new System.Drawing.Point(177, 40);
            this.Grade_label.Name = "Grade_label";
            this.Grade_label.Size = new System.Drawing.Size(15, 16);
            this.Grade_label.TabIndex = 29;
            this.Grade_label.Text = "0";
            this.Grade_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(3, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 19);
            this.label15.TabIndex = 27;
            this.label15.Text = "NO. OF TESTS GIVEN:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(3, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "LAST SIGNED IN:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(3, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "GRADE:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(3, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "PERCENTAGE:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(1, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Profile Overview";
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.Silver;
            this.title_label.Location = new System.Drawing.Point(12, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(294, 41);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "STUDENT DASHBOARD";
            // 
            // user_quiz_panel
            // 
            this.user_quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.user_quiz_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_quiz_panel.Controls.Add(this.changesubject_linkLabel1);
            this.user_quiz_panel.Controls.Add(this.Start_quiz_button);
            this.user_quiz_panel.Controls.Add(this.quiz_code_txtbox);
            this.user_quiz_panel.Controls.Add(this.label24);
            this.user_quiz_panel.Controls.Add(this.label23);
            this.user_quiz_panel.Controls.Add(this.teacher_quiz_button);
            this.user_quiz_panel.Controls.Add(this.pictureBox4);
            this.user_quiz_panel.Controls.Add(this.label22);
            this.user_quiz_panel.Controls.Add(this.label21);
            this.user_quiz_panel.Controls.Add(this.label19);
            this.user_quiz_panel.Controls.Add(this.label18);
            this.user_quiz_panel.Controls.Add(this.Select_quiz_button);
            this.user_quiz_panel.Controls.Add(this.pictureBox3);
            this.user_quiz_panel.Controls.Add(this.label17);
            this.user_quiz_panel.Location = new System.Drawing.Point(12, 64);
            this.user_quiz_panel.Name = "user_quiz_panel";
            this.user_quiz_panel.Size = new System.Drawing.Size(517, 194);
            this.user_quiz_panel.TabIndex = 0;
            // 
            // changesubject_linkLabel1
            // 
            this.changesubject_linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.changesubject_linkLabel1.AutoSize = true;
            this.changesubject_linkLabel1.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changesubject_linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.changesubject_linkLabel1.Location = new System.Drawing.Point(71, 169);
            this.changesubject_linkLabel1.Name = "changesubject_linkLabel1";
            this.changesubject_linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.changesubject_linkLabel1.TabIndex = 23;
            this.changesubject_linkLabel1.TabStop = true;
            this.changesubject_linkLabel1.Text = "Change Subject?";
            this.changesubject_linkLabel1.Visible = false;
            this.changesubject_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Start_quiz_button
            // 
            this.Start_quiz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Start_quiz_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start_quiz_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Start_quiz_button.ForeColor = System.Drawing.Color.White;
            this.Start_quiz_button.Location = new System.Drawing.Point(32, 134);
            this.Start_quiz_button.Name = "Start_quiz_button";
            this.Start_quiz_button.Size = new System.Drawing.Size(164, 33);
            this.Start_quiz_button.TabIndex = 22;
            this.Start_quiz_button.Text = "START QUIZ";
            this.Start_quiz_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Start_quiz_button.UseSelectable = true;
            this.Start_quiz_button.Visible = false;
            this.Start_quiz_button.Click += new System.EventHandler(this.Start_quiz_button_Click);
            // 
            // quiz_code_txtbox
            // 
            // 
            // 
            // 
            this.quiz_code_txtbox.CustomButton.Image = null;
            this.quiz_code_txtbox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.quiz_code_txtbox.CustomButton.Name = "";
            this.quiz_code_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quiz_code_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quiz_code_txtbox.CustomButton.TabIndex = 1;
            this.quiz_code_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quiz_code_txtbox.CustomButton.UseSelectable = true;
            this.quiz_code_txtbox.CustomButton.Visible = false;
            this.quiz_code_txtbox.Lines = new string[0];
            this.quiz_code_txtbox.Location = new System.Drawing.Point(276, 158);
            this.quiz_code_txtbox.MaxLength = 5;
            this.quiz_code_txtbox.Name = "quiz_code_txtbox";
            this.quiz_code_txtbox.PasswordChar = '\0';
            this.quiz_code_txtbox.PromptText = "ENTER CODE";
            this.quiz_code_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quiz_code_txtbox.SelectedText = "";
            this.quiz_code_txtbox.SelectionLength = 0;
            this.quiz_code_txtbox.SelectionStart = 0;
            this.quiz_code_txtbox.ShortcutsEnabled = true;
            this.quiz_code_txtbox.Size = new System.Drawing.Size(132, 23);
            this.quiz_code_txtbox.TabIndex = 21;
            this.quiz_code_txtbox.UseSelectable = true;
            this.quiz_code_txtbox.WaterMark = "ENTER CODE";
            this.quiz_code_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quiz_code_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Silver;
            this.label24.Location = new System.Drawing.Point(247, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(222, 27);
            this.label24.TabIndex = 20;
            this.label24.Text = "Teacher Quiz:";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.Location = new System.Drawing.Point(308, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(161, 51);
            this.label23.TabIndex = 19;
            this.label23.Text = "Enter the code to enter the\r\nteacher based quizes";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacher_quiz_button
            // 
            this.teacher_quiz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.teacher_quiz_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.teacher_quiz_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.teacher_quiz_button.ForeColor = System.Drawing.Color.White;
            this.teacher_quiz_button.Location = new System.Drawing.Point(414, 151);
            this.teacher_quiz_button.Name = "teacher_quiz_button";
            this.teacher_quiz_button.Size = new System.Drawing.Size(79, 30);
            this.teacher_quiz_button.Style = MetroFramework.MetroColorStyle.Silver;
            this.teacher_quiz_button.TabIndex = 18;
            this.teacher_quiz_button.Text = "ENTER";
            this.teacher_quiz_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.teacher_quiz_button.UseSelectable = true;
            this.teacher_quiz_button.Click += new System.EventHandler(this.teacher_quiz_button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::quiz_system.Properties.Resources.get;
            this.pictureBox4.Location = new System.Drawing.Point(298, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(232, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 92);
            this.label22.TabIndex = 15;
            this.label22.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(232, -5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 77);
            this.label21.TabIndex = 14;
            this.label21.Text = "|\r\n|\r\n|\r\n|\r\n|";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(220, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 27);
            this.label19.TabIndex = 13;
            this.label19.Text = "OR";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(41, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 38);
            this.label18.TabIndex = 12;
            this.label18.Text = "Practice to enhance and\r\nbuild your skills";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Select_quiz_button
            // 
            this.Select_quiz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Select_quiz_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Select_quiz_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Select_quiz_button.ForeColor = System.Drawing.Color.White;
            this.Select_quiz_button.Location = new System.Drawing.Point(32, 135);
            this.Select_quiz_button.Name = "Select_quiz_button";
            this.Select_quiz_button.Size = new System.Drawing.Size(164, 44);
            this.Select_quiz_button.TabIndex = 11;
            this.Select_quiz_button.Text = "PRACTICE QUIZ";
            this.Select_quiz_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Select_quiz_button.UseSelectable = true;
            this.Select_quiz_button.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::quiz_system.Properties.Resources.Build_exams;
            this.pictureBox3.Location = new System.Drawing.Point(32, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 27);
            this.label17.TabIndex = 3;
            this.label17.Text = "Practice Quiz:";
            // 
            // slider_dashboard_panel
            // 
            this.slider_dashboard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.slider_dashboard_panel.Controls.Add(this.label8);
            this.slider_dashboard_panel.Controls.Add(this.name_label);
            this.slider_dashboard_panel.Controls.Add(this.metroButton6);
            this.slider_dashboard_panel.Controls.Add(this.label6);
            this.slider_dashboard_panel.Controls.Add(this.metroButton5);
            this.slider_dashboard_panel.Controls.Add(this.label5);
            this.slider_dashboard_panel.Controls.Add(this.logout_button);
            this.slider_dashboard_panel.Controls.Add(this.leaderboard_button);
            this.slider_dashboard_panel.Controls.Add(this.Dashboard_button);
            this.slider_dashboard_panel.Controls.Add(this.label2);
            this.slider_dashboard_panel.Controls.Add(this.label4);
            this.slider_dashboard_panel.Controls.Add(this.label3);
            this.slider_dashboard_panel.Controls.Add(this.label1);
            this.slider_dashboard_panel.Controls.Add(this.pictureBox2);
            this.slider_dashboard_panel.Controls.Add(this.metroButton3);
            this.slider_dashboard_panel.Controls.Add(this.pictureBox1);
            this.slider_dashboard_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider_dashboard_panel.Location = new System.Drawing.Point(0, 0);
            this.slider_dashboard_panel.Name = "slider_dashboard_panel";
            this.slider_dashboard_panel.Size = new System.Drawing.Size(52, 548);
            this.slider_dashboard_panel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(48, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 44);
            this.label8.TabIndex = 20;
            this.label8.Text = " WELCOME";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label
            // 
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.ForeColor = System.Drawing.Color.Gray;
            this.name_label.Location = new System.Drawing.Point(48, 55);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(163, 44);
            this.name_label.TabIndex = 19;
            this.name_label.Text = "  UNKNOWN";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroButton6.BackgroundImage = global::quiz_system.Properties.Resources.icons8_settings_filled_32;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.Enabled = false;
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.ForeColor = System.Drawing.Color.White;
            this.metroButton6.Location = new System.Drawing.Point(3, 501);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(44, 44);
            this.metroButton6.TabIndex = 17;
            this.metroButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(48, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 44);
            this.label6.TabIndex = 18;
            this.label6.Text = "SETTINGS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Transparent;
            this.metroButton5.BackgroundImage = global::quiz_system.Properties.Resources.icons8_about_filled_32;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.Enabled = false;
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.ForeColor = System.Drawing.Color.White;
            this.metroButton5.Location = new System.Drawing.Point(3, 451);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(44, 44);
            this.metroButton5.TabIndex = 15;
            this.metroButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(48, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 44);
            this.label5.TabIndex = 16;
            this.label5.Text = "ABOUT US";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.logout_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_logout_rounded_left_filled_32;
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logout_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Location = new System.Drawing.Point(3, 255);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(44, 44);
            this.logout_button.TabIndex = 11;
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logout_button.UseCustomBackColor = true;
            this.logout_button.UseSelectable = true;
            this.logout_button.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // leaderboard_button
            // 
            this.leaderboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.leaderboard_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_test_results_filled_32;
            this.leaderboard_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leaderboard_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.leaderboard_button.ForeColor = System.Drawing.Color.White;
            this.leaderboard_button.Location = new System.Drawing.Point(3, 205);
            this.leaderboard_button.Name = "leaderboard_button";
            this.leaderboard_button.Size = new System.Drawing.Size(44, 44);
            this.leaderboard_button.TabIndex = 11;
            this.leaderboard_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.leaderboard_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.leaderboard_button.UseCustomBackColor = true;
            this.leaderboard_button.UseSelectable = true;
            this.leaderboard_button.Click += new System.EventHandler(this.leaderboard_button_Click);
            // 
            // Dashboard_button
            // 
            this.Dashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Dashboard_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_speed_filled_32;
            this.Dashboard_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dashboard_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Dashboard_button.ForeColor = System.Drawing.Color.White;
            this.Dashboard_button.Location = new System.Drawing.Point(3, 155);
            this.Dashboard_button.Name = "Dashboard_button";
            this.Dashboard_button.Size = new System.Drawing.Size(44, 44);
            this.Dashboard_button.TabIndex = 10;
            this.Dashboard_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dashboard_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Dashboard_button.UseSelectable = true;
            this.Dashboard_button.Click += new System.EventHandler(this.Dashboard_button_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(48, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "DASHBOARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(48, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 44);
            this.label4.TabIndex = 14;
            this.label4.Text = "LEADERBOARD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "SHOW/HIDE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(48, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGOUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quiz_system.Properties.Resources.zjHl2lgef9cYrQL0JFa7kzbw2vuErRVKnh3K0zd9OXdE9g5shnN1i__;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.metroButton3.BackgroundImage = global::quiz_system.Properties.Resources.icons8_menu_32;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Location = new System.Drawing.Point(3, 105);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(44, 44);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pictureBox1.BackgroundImage = global::quiz_system.Properties.Resources.Untitled;
            this.pictureBox1.Image = global::quiz_system.Properties.Resources.unk;
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // student_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "student_dashboard";
            this.Padding = new System.Windows.Forms.Padding(33, 97, 33, 32);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.panel1.ResumeLayout(false);
            this.user_panel.ResumeLayout(false);
            this.user_history_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.test_history_gridview)).EndInit();
            this.user_profile_panel.ResumeLayout(false);
            this.user_profile_panel.PerformLayout();
            this.user_quiz_panel.ResumeLayout(false);
            this.user_quiz_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.slider_dashboard_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slider_dashboard_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton leaderboard_button;
        private MetroFramework.Controls.MetroButton logout_button;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel user_quiz_panel;
        private System.Windows.Forms.Panel user_history_panel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private MetroFramework.Controls.MetroButton app_minimize_button;
        private MetroFramework.Controls.MetroButton app_close_button;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton teacher_quiz_button;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private MetroFramework.Controls.MetroTextBox quiz_code_txtbox;
        public MetroFramework.Controls.MetroButton Select_quiz_button;
        public MetroFramework.Controls.MetroButton Start_quiz_button;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel changesubject_linkLabel1;
        public System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label No_Of_tests_label;
        private System.Windows.Forms.Label Last_Signed_Label;
        private System.Windows.Forms.Label Percentage_Label;
        private System.Windows.Forms.Label Grade_label;
        protected MetroFramework.Controls.MetroButton Dashboard_button;
        private System.Windows.Forms.DataGridView test_history_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKS;
        public System.Windows.Forms.Panel user_profile_panel;
    }
}