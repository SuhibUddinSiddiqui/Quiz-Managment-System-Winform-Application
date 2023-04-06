using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace quiz_system
{
    public partial class student_dashboard : MetroFramework.Forms.MetroForm
    {
        string username;
        Bitmap bit;
        int panelWidth;
        bool Hidden, test_generate_check;
        string[] users_data, test_history;
        int i;



        public student_dashboard(string username)
        {
            InitializeComponent();
            generate_quiz.temp = username;
            this.username = username;
            panelWidth = 211;
            Hidden = true;

            string[] files = Directory.GetFiles(Application.StartupPath + "\\images");

            for (int i = 0; i < files.Length; i++)
            {
                if (Application.StartupPath + "\\images\\" + username + ".jpg" == files[i])
                {
                    bit = new Bitmap(files[i]);
                }
            }

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Region = new Region(path);
            pictureBox1.Image = bit;
            slider_dashboard_panel.Controls.Add(pictureBox1);

            StreamReader sr = new StreamReader("userdata.txt");
            StreamReader sr1 = new StreamReader("userhistory.txt");

            users_data = sr.ReadToEnd().Replace("\r\n", "").Split(',');


            test_history = sr1.ReadToEnd().Replace("\r\n", "").Split(',');
            for (i = 0; i < users_data.Length - 1; i += 8)
            {
                if (username == users_data[i + 2])
                {
                    name_label.Text = users_data[i + 1].ToUpper();
                    Last_Signed_Label.Text = users_data[i + 6];
                    No_Of_tests_label.Text = users_data[i + 7];
                    Percentage_Label.Text = users_data[i + 5];
                    Grade_label.Text = generate_quiz.Set_Grade(Convert.ToInt32(users_data[i + 5]));

                    for (int j = 0; j < test_history.Length - 1; j += 5)
                    {
                        if (test_history[j] == username)
                        {
                            test_history_gridview.Rows.Add(test_history[j + 1], test_history[j + 2], test_history[j + 3], test_history[j + 4]);
                            break;
                        }
                    }
                    break;
                }
            }
            sr.Close();

            generate_quiz.Get_Users_data(ref users_data, i);

            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                slider_dashboard_panel.Width = slider_dashboard_panel.Width + 10;
                if (slider_dashboard_panel.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                slider_dashboard_panel.Width = slider_dashboard_panel.Width - 10;
                if (slider_dashboard_panel.Width <= 52)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void app_close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "", "ARE YOU SURE YOU WANT TO EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult.Yes == dr)
            {
                if (username == users_data[i + 2])
                {
                    users_data[i + 6] = DateTime.Now.Date.ToShortDateString();

                    StreamWriter sw = new StreamWriter("userdata.txt");
                    for (int j = 0; j < users_data.Length - 1; j += 8)
                    {
                        sw.WriteLine(users_data[i] + "," + users_data[j + 1] + "," + users_data[j + 2] + "," + users_data[j + 3] + "," + users_data[j + 4] + "," + users_data[j + 5] + "," + users_data[j + 6] + "," + users_data[j + 7] + ",");
                    }
                    sw.Close();
                }
                Application.Exit();
            }

        }

        private void app_minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            select_quiz sq = new select_quiz();
            sq.Show();
        }

        private void Start_quiz_button_Click(object sender, EventArgs e)
        {
            generate_quiz.dashboard_show(ref user_quiz_panel, ref user_profile_panel, ref user_history_panel, ref leaderboard_button, ref Dashboard_button);
            user_quiz_panel.Hide(); user_profile_panel.Hide(); user_history_panel.Hide();
            generate_quiz.setup_quiz_panel(user_panel);

            title_label.Text = "PRACTICE QUIZ";

            Dashboard_button.Enabled = false;
            leaderboard_button.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (generate_quiz.difficulty != null || generate_quiz.subject != null)
                {
                    Start_quiz_button.Visible = true;
                    changesubject_linkLabel1.Visible = true;

                    Select_quiz_button.Visible = false;
                    timer2.Stop();
                }
            }
            catch (Exception)
            {
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            select_quiz sq = new select_quiz();
            sq.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (username == users_data[i + 2])
            {
                users_data[i + 6] = DateTime.Now.Date.ToShortDateString();
                StreamWriter sw = new StreamWriter("userdata.txt");
                for (int j = 0; j < users_data.Length - 1; j += 8)
                {
                    sw.WriteLine(users_data[i] + "," + users_data[j + 1] + "," + users_data[j + 2] + "," + users_data[j + 3] + "," + users_data[j + 4] + "," + users_data[j + 5] + "," + users_data[j + 6] + "," + users_data[j + 7] + ",");
                }
                sw.Close();
            }

            login logout = new login();
            logout.Show();
            this.Dispose();

        }

        private void teacher_quiz_button_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Application.StartupPath);


            if (files.Contains(Application.StartupPath + "\\" + quiz_code_txtbox.Text + ".txt"))
            {

                MetroFramework.MetroMessageBox.Show(this, "", "CODE ACCEPTED");
                generate_quiz.code = int.Parse(quiz_code_txtbox.Text);
                generate_quiz.setup_quiz_panel(user_panel);

                this.user_history_panel.Hide();
                this.user_profile_panel.Hide();
                this.user_quiz_panel.Hide();
                title_label.Text = "TEACHER'S QUIZ:";
                generate_quiz.dashboard_show(ref user_quiz_panel, ref user_profile_panel, ref user_history_panel, ref leaderboard_button, ref Dashboard_button);

                Dashboard_button.Enabled = false;
                leaderboard_button.Enabled = false;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "", "INVALID CODE");
            }
        }

        private void leaderboard_button_Click(object sender, EventArgs e)
        {
            Leaderboard.Create_chart(user_panel);
            user_profile_panel.Hide();
            user_quiz_panel.Hide();
            user_history_panel.Hide();
            title_label.Text = "LEADERBOARD";

        }

        private void Dashboard_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "STUDENT DASHBOARD";
            user_quiz_panel.Show();
            user_profile_panel.Show();
            user_history_panel.Show();
            try
            {
                Leaderboard.Dispose();
            }
            catch (Exception)
            {

            }
        }
    }
}
