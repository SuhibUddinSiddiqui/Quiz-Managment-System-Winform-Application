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
   static class Create_quiz
    {
       static public Panel Cquiz_panel;
       static public int question_no;
       static public createQuiz_control[] CreateQuiz = new createQuiz_control[10];
       static public MetroFramework.Controls.MetroButton save = new MetroFramework.Controls.MetroButton();
       static int height=5,code=0;


        static public void Create_quiz_panel(Panel panel)
        {
            Cquiz_panel = new Panel();
            Cquiz_panel.Width = 780;
            Cquiz_panel.Height = 475;
            Cquiz_panel.Location = new Point(12, 55);
            Cquiz_panel.BackgroundImage = Image.FromFile("bdg.jpg");
            Cquiz_panel.BackgroundImageLayout = ImageLayout.Stretch;
            Cquiz_panel.BorderStyle = BorderStyle.Fixed3D;
            Cquiz_panel.AutoScroll = true;
            create_quiz_control(Cquiz_panel,question_no);
            
            panel.Controls.Add(Cquiz_panel);
            

        }

        static public void create_quiz_control(Panel panel,int questions)
        {
            for (int i = 0; i < questions; i++,height+=105)
            {
                CreateQuiz[i] = new createQuiz_control((i+1).ToString());
                CreateQuiz[i].Location = new Point(2,height);
                
                panel.Controls.Add(CreateQuiz[i]);
            }
            save = new MetroFramework.Controls.MetroButton();
            save.Width = 759;
            save.Height = 34;
            save.Theme = MetroFramework.MetroThemeStyle.Dark;
            save.Location = new Point(0, height);
            save.Text = "DISMISS";
            save.Click += new EventHandler(Save_button_click);
            save.Enabled = true;
            panel.Controls.Add(save);
        }

        static public void Save_button_click(object sender, EventArgs e)
        {
            
                Random r = new Random();
                code = r.Next(10000, 99999);

                StreamWriter sw = new StreamWriter(code + ".txt");
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(CreateQuiz[i].question_textbox.Text + ",");
                   
                }
                sw.Close();
                MetroFramework.MetroMessageBox.Show(Admin_Dashboard.ActiveForm, "Quiz Code is:"+code, "QUIZ CREATED SUCCESSFULLY");
            
        }
        static public void dispose()
        {
            Cquiz_panel.Dispose();
            
        }

    }
}
