namespace quiz_system
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.app_minimize_button = new MetroFramework.Controls.MetroButton();
            this.app_close_button = new MetroFramework.Controls.MetroButton();
            this.student_data_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERCENTAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTSIGNEDIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_OF_TESTS_GIVEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.admin_profile_panel = new System.Windows.Forms.Panel();
            this.No_Of_testsCreate_label = new System.Windows.Forms.Label();
            this.Last_Signed_Label = new System.Windows.Forms.Label();
            this.rank_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.admin_create_panel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Create_quiz_button = new MetroFramework.Controls.MetroButton();
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
            this.Dashboard_button = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.admin_panel.SuspendLayout();
            this.student_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.admin_profile_panel.SuspendLayout();
            this.admin_create_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.slider_dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.admin_panel);
            this.panel1.Controls.Add(this.slider_dashboard_panel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // admin_panel
            // 
            resources.ApplyResources(this.admin_panel, "admin_panel");
            this.admin_panel.BackColor = System.Drawing.Color.Black;
            this.admin_panel.BackgroundImage = global::quiz_system.Properties.Resources.gradient_wallpaper_18;
            this.admin_panel.CausesValidation = false;
            this.admin_panel.Controls.Add(this.app_minimize_button);
            this.admin_panel.Controls.Add(this.app_close_button);
            this.admin_panel.Controls.Add(this.student_data_panel);
            this.admin_panel.Controls.Add(this.admin_profile_panel);
            this.admin_panel.Controls.Add(this.title_label);
            this.admin_panel.Controls.Add(this.admin_create_panel);
            this.admin_panel.ForeColor = System.Drawing.Color.Silver;
            this.admin_panel.Name = "admin_panel";
            // 
            // app_minimize_button
            // 
            this.app_minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.app_minimize_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_minimize_window_24__2_;
            resources.ApplyResources(this.app_minimize_button, "app_minimize_button");
            this.app_minimize_button.Name = "app_minimize_button";
            this.app_minimize_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.app_minimize_button.UseCustomBackColor = true;
            this.app_minimize_button.UseSelectable = true;
            this.app_minimize_button.Click += new System.EventHandler(this.app_minimize_button_Click);
            // 
            // app_close_button
            // 
            this.app_close_button.BackColor = System.Drawing.Color.Transparent;
            this.app_close_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_cancel_filled_50;
            resources.ApplyResources(this.app_close_button, "app_close_button");
            this.app_close_button.Name = "app_close_button";
            this.app_close_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.app_close_button.UseCustomBackColor = true;
            this.app_close_button.UseSelectable = true;
            this.app_close_button.Click += new System.EventHandler(this.app_close_button_Click);
            // 
            // student_data_panel
            // 
            this.student_data_panel.BackColor = System.Drawing.Color.Transparent;
            this.student_data_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.student_data_panel.Controls.Add(this.dataGridView1);
            this.student_data_panel.Controls.Add(this.label20);
            resources.ApplyResources(this.student_data_panel, "student_data_panel");
            this.student_data_panel.Name = "student_data_panel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.GRADE,
            this.PERCENTAGE,
            this.LASTSIGNEDIN,
            this.NO_OF_TESTS_GIVEN});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // NAME
            // 
            resources.ApplyResources(this.NAME, "NAME");
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // GRADE
            // 
            resources.ApplyResources(this.GRADE, "GRADE");
            this.GRADE.Name = "GRADE";
            this.GRADE.ReadOnly = true;
            // 
            // PERCENTAGE
            // 
            resources.ApplyResources(this.PERCENTAGE, "PERCENTAGE");
            this.PERCENTAGE.Name = "PERCENTAGE";
            this.PERCENTAGE.ReadOnly = true;
            // 
            // LASTSIGNEDIN
            // 
            resources.ApplyResources(this.LASTSIGNEDIN, "LASTSIGNEDIN");
            this.LASTSIGNEDIN.Name = "LASTSIGNEDIN";
            this.LASTSIGNEDIN.ReadOnly = true;
            // 
            // NO_OF_TESTS_GIVEN
            // 
            resources.ApplyResources(this.NO_OF_TESTS_GIVEN, "NO_OF_TESTS_GIVEN");
            this.NO_OF_TESTS_GIVEN.Name = "NO_OF_TESTS_GIVEN";
            this.NO_OF_TESTS_GIVEN.ReadOnly = true;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Name = "label20";
            // 
            // admin_profile_panel
            // 
            this.admin_profile_panel.BackColor = System.Drawing.Color.Transparent;
            this.admin_profile_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.admin_profile_panel.Controls.Add(this.No_Of_testsCreate_label);
            this.admin_profile_panel.Controls.Add(this.Last_Signed_Label);
            this.admin_profile_panel.Controls.Add(this.rank_label);
            this.admin_profile_panel.Controls.Add(this.label15);
            this.admin_profile_panel.Controls.Add(this.label14);
            this.admin_profile_panel.Controls.Add(this.label13);
            this.admin_profile_panel.Controls.Add(this.label10);
            resources.ApplyResources(this.admin_profile_panel, "admin_profile_panel");
            this.admin_profile_panel.Name = "admin_profile_panel";
            // 
            // No_Of_testsCreate_label
            // 
            resources.ApplyResources(this.No_Of_testsCreate_label, "No_Of_testsCreate_label");
            this.No_Of_testsCreate_label.BackColor = System.Drawing.Color.Transparent;
            this.No_Of_testsCreate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.No_Of_testsCreate_label.Name = "No_Of_testsCreate_label";
            // 
            // Last_Signed_Label
            // 
            resources.ApplyResources(this.Last_Signed_Label, "Last_Signed_Label");
            this.Last_Signed_Label.BackColor = System.Drawing.Color.Transparent;
            this.Last_Signed_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Last_Signed_Label.Name = "Last_Signed_Label";
            // 
            // rank_label
            // 
            resources.ApplyResources(this.rank_label, "rank_label");
            this.rank_label.BackColor = System.Drawing.Color.Transparent;
            this.rank_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rank_label.Name = "rank_label";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Name = "label10";
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title_label, "title_label");
            this.title_label.ForeColor = System.Drawing.Color.Silver;
            this.title_label.Name = "title_label";
            // 
            // admin_create_panel
            // 
            this.admin_create_panel.BackColor = System.Drawing.Color.Transparent;
            this.admin_create_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.admin_create_panel.Controls.Add(this.textBox1);
            this.admin_create_panel.Controls.Add(this.label23);
            this.admin_create_panel.Controls.Add(this.pictureBox4);
            this.admin_create_panel.Controls.Add(this.label18);
            this.admin_create_panel.Controls.Add(this.Create_quiz_button);
            this.admin_create_panel.Controls.Add(this.pictureBox3);
            this.admin_create_panel.Controls.Add(this.label17);
            resources.ApplyResources(this.admin_create_panel, "admin_create_panel");
            this.admin_create_panel.Name = "admin_create_panel";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.Name = "label23";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::quiz_system.Properties.Resources.results;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // Create_quiz_button
            // 
            this.Create_quiz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.Create_quiz_button, "Create_quiz_button");
            this.Create_quiz_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Create_quiz_button.ForeColor = System.Drawing.Color.White;
            this.Create_quiz_button.Name = "Create_quiz_button";
            this.Create_quiz_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Create_quiz_button.UseSelectable = true;
            this.Create_quiz_button.Click += new System.EventHandler(this.Create_quiz_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::quiz_system.Properties.Resources.Build_exams;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Name = "label17";
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
            this.slider_dashboard_panel.Controls.Add(this.Dashboard_button);
            this.slider_dashboard_panel.Controls.Add(this.label2);
            this.slider_dashboard_panel.Controls.Add(this.label3);
            this.slider_dashboard_panel.Controls.Add(this.label1);
            this.slider_dashboard_panel.Controls.Add(this.pictureBox2);
            this.slider_dashboard_panel.Controls.Add(this.metroButton3);
            this.slider_dashboard_panel.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.slider_dashboard_panel, "slider_dashboard_panel");
            this.slider_dashboard_panel.Name = "slider_dashboard_panel";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // name_label
            // 
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.name_label, "name_label");
            this.name_label.Name = "name_label";
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroButton6.BackgroundImage = global::quiz_system.Properties.Resources.icons8_settings_filled_32;
            resources.ApplyResources(this.metroButton6, "metroButton6");
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.ForeColor = System.Drawing.Color.White;
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Transparent;
            this.metroButton5.BackgroundImage = global::quiz_system.Properties.Resources.icons8_about_filled_32;
            resources.ApplyResources(this.metroButton5, "metroButton5");
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.ForeColor = System.Drawing.Color.White;
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.logout_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_logout_rounded_left_filled_32;
            resources.ApplyResources(this.logout_button, "logout_button");
            this.logout_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Name = "logout_button";
            this.logout_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logout_button.UseCustomBackColor = true;
            this.logout_button.UseSelectable = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Dashboard_button
            // 
            this.Dashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Dashboard_button.BackgroundImage = global::quiz_system.Properties.Resources.icons8_speed_filled_32;
            resources.ApplyResources(this.Dashboard_button, "Dashboard_button");
            this.Dashboard_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Dashboard_button.ForeColor = System.Drawing.Color.White;
            this.Dashboard_button.Name = "Dashboard_button";
            this.Dashboard_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Dashboard_button.UseSelectable = true;
            this.Dashboard_button.Click += new System.EventHandler(this.Dashboard_button_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quiz_system.Properties.Resources.zjHl2lgef9cYrQL0JFa7kzbw2vuErRVKnh3K0zd9OXdE9g5shnN1i__;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.metroButton3.BackgroundImage = global::quiz_system.Properties.Resources.icons8_menu_32;
            resources.ApplyResources(this.metroButton3, "metroButton3");
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pictureBox1.BackgroundImage = global::quiz_system.Properties.Resources.Untitled;
            this.pictureBox1.Image = global::quiz_system.Properties.Resources.unk;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Admin_Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Admin_Dashboard";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.panel1.ResumeLayout(false);
            this.admin_panel.ResumeLayout(false);
            this.student_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.admin_profile_panel.ResumeLayout(false);
            this.admin_profile_panel.PerformLayout();
            this.admin_create_panel.ResumeLayout(false);
            this.admin_create_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.slider_dashboard_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel admin_panel;
        private MetroFramework.Controls.MetroButton app_minimize_button;
        private MetroFramework.Controls.MetroButton app_close_button;
        private System.Windows.Forms.Panel student_data_panel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel admin_profile_panel;
        private System.Windows.Forms.Label No_Of_testsCreate_label;
        private System.Windows.Forms.Label Last_Signed_Label;
        private System.Windows.Forms.Label rank_label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel admin_create_panel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label18;
        public MetroFramework.Controls.MetroButton Create_quiz_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel slider_dashboard_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label name_label;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton logout_button;
        protected MetroFramework.Controls.MetroButton Dashboard_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERCENTAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTSIGNEDIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_OF_TESTS_GIVEN;
        private System.Windows.Forms.TextBox textBox1;
    }
}