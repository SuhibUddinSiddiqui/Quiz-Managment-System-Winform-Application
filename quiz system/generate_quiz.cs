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

namespace quiz_system
{
    static class generate_quiz
    {
        static public string subject, difficulty, grade, temp;
        static public int score=0, percentage, ii,code;
        static public Panel quiz_panel,p_temp,p1_temp,p2_temp;
        static public List<string> correct_answer = new List<string>(), Checked_answers = new List<string>();
        static public MetroFramework.Controls.MetroProgressBar Time_Spinner;
        static public questions_control[] q;
        static public int check_count = 0;
        static public MetroFramework.Controls.MetroButton abort_quiz_button,dismiss_button;
        static public Timer t;
        static public Label subject_label, subject_label1, difficulty_label, difficulty_label1;
        static string[] users_data;
        static MetroFramework.Controls.MetroButton l_show_button, d_show_button;

        static public void Get_Users_data(ref string[] user_data, int i)
        {
            ii = i;
            users_data = user_data;
        }

        static public void setup_quiz_panel(Panel panel)
        {
            quiz_panel = new Panel();
            quiz_panel.Width = 780;
            quiz_panel.Height = 380;
            quiz_panel.Location = new Point(12, 150);
            quiz_panel.BackgroundImage = Image.FromFile("bdg.jpg");
            quiz_panel.BackgroundImageLayout = ImageLayout.Stretch;
            quiz_panel.BorderStyle = BorderStyle.Fixed3D;
            quiz_panel.AutoScroll = true;
            generate_questions(quiz_panel);
            panel.Controls.Add(quiz_panel);

            t = new Timer();
            t.Interval = 1000;
            t.Tick += new System.EventHandler(Quiz_Time_Counter);
            t.Start();

            Generate_Quiz_Labels(panel);
        }

        static public void generate_questions(Panel panel)
        {
            StreamReader sr;
            int loc_height = 2;
            q = new questions_control[10];
            if (code!=0)
            {
                q = new questions_control[10];
                sr=new StreamReader((code.ToString())+".txt");
            }
            else
            {
                q = new questions_control[5];
            sr = new StreamReader(Subject_difficulty_check()+".txt");
            }
            string[] sub = sr.ReadToEnd().Replace("\r\n", "").Split(',');
            for (int i = 0, j = 0; j < q.Length; i += 5, j++)
            {
                q[j] = new questions_control(j, sub[i]);
                q[j].Location = new Point(2, loc_height);
                q[j].BackColor = Color.Transparent;
                loc_height += 150;
                panel.Controls.Add(q[j]);
            }
            sr.Close();
            q[0].Enabled = true;
        }

        static public void Generate_Quiz_Labels(Panel panel)
        {
            abort_quiz_button = new MetroFramework.Controls.MetroButton();
            abort_quiz_button.Width = 100;
            abort_quiz_button.Height = 34;
            abort_quiz_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            abort_quiz_button.Location = new Point(690, 100);
            abort_quiz_button.Text = "ABORT QUIZ";
            abort_quiz_button.Click += new EventHandler(ABORT_button_click);
            abort_quiz_button.Enabled = true;
            panel.Controls.Add(abort_quiz_button);

            Time_Spinner = new MetroFramework.Controls.MetroProgressBar();
            Time_Spinner.Value = 0;
            Time_Spinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            Time_Spinner.UseStyleColors = true;
            Time_Spinner.Style = MetroFramework.MetroColorStyle.Silver;
            Time_Spinner.Maximum = 300;
            Time_Spinner.Width = 780;
            Time_Spinner.Location = new Point(12, 140);
            panel.Controls.Add(Time_Spinner);

            subject_label = new Label();
            subject_label.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            subject_label.ForeColor = Color.Silver;
            subject_label.AutoSize = true;
            subject_label.Location = new Point(12, 60);
            subject_label.BackColor = Color.Transparent;
            subject_label.Text = "SUBJECT:";
            panel.Controls.Add(subject_label);

            subject_label1 = new Label();
            subject_label1.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            subject_label1.ForeColor = Color.Silver;
            subject_label1.AutoSize = true;
            subject_label1.Location = new Point(90, 60);
            subject_label1.BackColor = Color.Transparent;
            subject_label1.Text = subject;
            panel.Controls.Add(subject_label1);

            difficulty_label= new Label();
            difficulty_label.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            difficulty_label.ForeColor = Color.Silver;
            difficulty_label.AutoSize = true;
            difficulty_label.Location = new Point(12, 100);
            difficulty_label.BackColor = Color.Transparent;
            difficulty_label.Text = "DIFFICULTY LEVEL:";
            panel.Controls.Add(difficulty_label);

            difficulty_label1 = new Label();
            difficulty_label1.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            difficulty_label1.ForeColor = Color.Silver;
            difficulty_label1.AutoSize = true;
            difficulty_label1.Location = new Point(160, 100);
            difficulty_label1.BackColor = Color.Transparent;
            difficulty_label1.Text = difficulty;
            panel.Controls.Add(difficulty_label1);
        }

        static public void Quiz_Time_Counter(object sender, EventArgs e)
        {
            if (Time_Spinner.Value == Time_Spinner.Maximum)
            {
                t.Stop();
                MessageBox.Show("QUIZ ENDED");
                END_Quiz(quiz_panel);
            }
            else
            {
                Time_Spinner.Value += 1;
                
            }
        }

        static public void ABORT_button_click(object sender, EventArgs e)
        {
            //student_dashboard sw = ;
            DialogResult dr = MetroFramework.MetroMessageBox.Show(student_dashboard.ActiveForm, "Your Current Points will be saved as your result", "ARE YOU SURE YOU WANT TO QUIT?",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (dr==DialogResult.Yes)
            {
                END_Quiz(quiz_panel);
                t.Stop();    
            }
            
        }

        static public int Set_percentage(double total_percentage, double total_no_ofTests)
        {
            double total_obt_marks = (total_percentage / 100) * ((total_no_ofTests) * 10);
            total_obt_marks = total_obt_marks + score;
            total_no_ofTests++;
            double total_marks =(total_obt_marks/total_no_ofTests) * 10;
            int temp = Convert.ToInt32(total_marks);
            if (temp>100)
            {
                temp = 100;
            }
            else if (temp<0)
            {
                temp = 0;
            }
            return temp;
        }

        static public string Set_Grade(int percentage)
        {
            string grade = "";
            if (percentage < 40)
            {
                grade = "F";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                grade = "D";
            }
            else if (percentage >= 50 && percentage < 60)
            {
                grade = "C";
            }
            else if (percentage >= 60 && percentage < 70)
            {
                grade = "B";
            }
            else if (percentage >= 70 && percentage < 85)
            {
                grade = "A";
            }
            else if (percentage >= 85)
            {
                grade = "A+";
            }
            return grade;
        }

        static public void END_Quiz(Panel panel)
        {
            panel.Controls.Clear();
            Label display = new Label();
            display.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            display.ForeColor = Color.Silver;
            display.AutoSize = true;
            display.Location = new Point(21, 28);
            display.BackColor = Color.Transparent;
            display.Text = "YOUR ANSWERS:";
            panel.Controls.Add(display);

            Label display1 = new Label();
            display1.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            display1.ForeColor = Color.Silver;
            display1.AutoSize = true;
            display1.Location = new Point(477, 28);
            display1.BackColor = Color.Transparent;
            display1.Text = "CORRECT ANSWERS:";
            panel.Controls.Add(display1);

            Label[] checked_answers = new Label[10];
            Label[] Correct_answers = new Label[10];


            for (int i = 0, height = 78; i < Checked_answers.Count; i++, height += 37)
            {
                checked_answers[i] = new Label();
                checked_answers[i].Font = new Font("Century Gothic", 10, FontStyle.Regular);
                checked_answers[i].ForeColor = Color.Silver;
                checked_answers[i].AutoSize = true;
                checked_answers[i].Location = new Point(21, height);
                checked_answers[i].BackColor = Color.Transparent;
                checked_answers[i].Text = (i + 1) + ". " + Checked_answers[i];
                panel.Controls.Add(checked_answers[i]);

                Correct_answers[i] = new Label();
                Correct_answers[i].Font = new Font("Century Gothic", 10, FontStyle.Regular);
                Correct_answers[i].ForeColor = Color.Silver;
                Correct_answers[i].AutoSize = true;
                Correct_answers[i].Location = new Point(477, height);
                Correct_answers[i].BackColor = Color.Transparent;
                Correct_answers[i].Text = (i + 1) + ". " + correct_answer[i];
                panel.Controls.Add(Correct_answers[i]);
            }

            dismiss_button = new MetroFramework.Controls.MetroButton();
            dismiss_button.Width = 780;
            dismiss_button.Height = 34;
            dismiss_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            dismiss_button.Location = new Point(0, 320);
            dismiss_button.Text = "DISMISS";
            dismiss_button.Click += new EventHandler(Dispose);
            dismiss_button.Enabled = true;
            panel.Controls.Add(dismiss_button);
            users_data[ii + 5] = (generate_quiz.Set_percentage(int.Parse(users_data[ii + 5]), int.Parse(users_data[ii + 7]))).ToString();
            users_data[ii + 7] = (Convert.ToInt32(users_data[ii + 7]) + 1).ToString();
        }
        static public string Subject_difficulty_check()
        {
            if (subject == "pf")
            {
                if (difficulty == "novice")
                {
                    return "pf(novice)";
                }
                else
                {
                    return "pf(pro)";
                }
            }
            else if (subject == "oop")
            {
                if (difficulty == "novice")
                {
                    return "oop(novice)";
                }
                else
                {
                    return "oop(pro)";
                }
            }
            else if (subject == "ds")
            {
                if (difficulty == "novice")
                {
                    return "ds(novice)";
                }
                else
                {
                    return "ds(pro)";
                }
            }
            else
            {
                return "";
            }
        }
        
        static public void Dispose(object sender,EventArgs e)
        {
            quiz_panel.Dispose();
            Time_Spinner.Dispose();
            subject_label.Dispose();
            subject_label1.Dispose();
            difficulty_label.Dispose();
            difficulty_label1.Dispose();
            abort_quiz_button.Dispose();
            p_temp.Show();
            p1_temp.Show();
            p2_temp.Show();
            l_show_button.Enabled = true;
            d_show_button.Enabled = true;
            code = 0;
        }

        static public void dashboard_show(ref Panel p, ref Panel p1, ref Panel p2, ref MetroFramework.Controls.MetroButton b, ref MetroFramework.Controls.MetroButton b2)
        {
             p_temp = p; 
             p1_temp = p1; 
             p2_temp = p2;
             l_show_button = b;
             d_show_button = b2;
            
        }

    }
}
