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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        int count;
        Bitmap b = new Bitmap("unk.png");
        bool temp, temp1;
       
        public login()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("remembermedata.txt");
            string[] rem_me;

            try
            {
                rem_me = sr.ReadLine().Split(',');

                if (rem_me[0] == "1")
                {
                    login_username_textbox.Text = rem_me[1];
                    login_password_txtbox.Text = rem_me[2];
                   login_rememberme_checkbox.Checked = true;
                }
            }
            catch (NullReferenceException)
            {


            }
            sr.Close();
        }

        private void loginpanel_show_button_Click(object sender, EventArgs e)
        {
            loginpanel.Visible = true;
            registerpanel.Visible = false;
        }

        private void registerpanel_show_button_Click(object sender, EventArgs e)
        {
            loginpanel.Visible = false;
            registerpanel.Visible = true;

        }

        private void uploadimage_button_Click(object sender, EventArgs e)
        {
            //open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                b = new Bitmap(open.FileName);
            }

        }

        private void register_acc_button_Click(object sender, EventArgs e)
        {
            loader_reg.Start();
            loadergif.Visible = true;
        }

        private void loader_Tick(object sender, EventArgs e)
        {
            count++;
            if (count==4)
            {
                loadergif.Visible = false;
                temp1 = login_register.valid_emailcheck(register_email_txtbox.Text);
                if (temp1)
                {
                    if (register_pass_txtbox.Text == register_retype_pass_txtbox.Text)
                    {
                        if (student_radiobutton.Checked)
                        {
                            temp = login_register.accountcreate("student",register_name_txtbox.Text, register_email_txtbox.Text, register_pass_txtbox.Text);
                            if (temp)
                            {
                                loader_reg.Stop(); count = 0;
                                MetroFramework.MetroMessageBox.Show(this, "", "success");
                                b.Save(Application.StartupPath+"\\images\\" + register_email_txtbox.Text + ".jpg");
                            }
                            else
                            {
                                loader_reg.Stop(); count = 0;
                                MetroFramework.MetroMessageBox.Show(this, "", "failed");

                            }    
                        }
                        else if (teacher_radiobutton.Checked)
                        {
                            temp = login_register.accountcreate("teacher",register_name_txtbox.Text, register_email_txtbox.Text, register_pass_txtbox.Text);
                            if (temp)
                            {
                                loader_reg.Stop(); count = 0;
                                MetroFramework.MetroMessageBox.Show(this, "", "success");
                                b.Save(Application.StartupPath+"\\images\\" + register_email_txtbox.Text + ".jpg");
                                
                            }
                            else
                            {
                                loader_reg.Stop(); count = 0;
                                MetroFramework.MetroMessageBox.Show(this, "", "failed");

                            }    
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "", "CATEGORY NOT SELECTED:");
                        }
                        
                    }
                    else
                    {
                        loader_reg.Stop(); count = 0;
                        MetroFramework.MetroMessageBox.Show(this, "", "passwords doesnt match");

                    }
                }
                else
                {
                    loader_reg.Stop(); count = 0;
                    MetroFramework.MetroMessageBox.Show(this, "", "email problem");

                }
                
            }

        }

        private void login_acc_button_Click(object sender, EventArgs e)
        {

            loader_login.Start();
            loadergif.Visible = true;
        }

        private void loader_login_Tick(object sender, EventArgs e)
        {
            count++;
            if (count==4)
            {
               string  temp=login_register.logincheck(login_username_textbox.Text, login_password_txtbox.Text);
                if (temp=="student")
                {
                    if (login_rememberme_checkbox.Checked)
                    {
                        StreamWriter sw = new StreamWriter("remembermedata.txt");
                        sw.Write("1" + "," + login_username_textbox.Text + "," + login_password_txtbox.Text);//if checkbox=checked it will remember the current username and password(if valid)  
                        sw.Close();
                        
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter("remembermedata.txt");//if checbox!=checked it will not remember
                        sw.Write("0");
                        sw.Close();
                        
                    }

                    loadergif.Visible = false;
                    loader_login.Stop(); count = 0;
                    MetroFramework.MetroMessageBox.Show(this,"","logged in");
                    student_dashboard s = new student_dashboard(login_username_textbox.Text);
                    s.Show();
                    this.Hide();
 
                }
                else if (temp=="teacher")
                {
                    if (login_rememberme_checkbox.Checked)
                    {
                        StreamWriter sw = new StreamWriter("remembermedata.txt");
                        sw.Write("1" + "," + login_username_textbox.Text + "," + login_password_txtbox.Text);//if checkbox=checked it will remember the current username and password(if valid)  
                        sw.Close();
                        
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter("remembermedata.txt");//if checbox!=checked it will not remember
                        sw.Write("0");
                        sw.Close();
                            
                    }

                    loadergif.Visible = false;
                    loader_login.Stop(); count = 0;
                    MetroFramework.MetroMessageBox.Show(this, "", "logged in");
                    Admin_Dashboard ad = new Admin_Dashboard(login_username_textbox.Text);
                    ad.Show();
                    this.Hide();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "", "login failed");
                    loadergif.Visible = false;
                    loader_login.Stop(); count = 0;
                }
            }
        }

        private void app_close_button_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "", "EXIT?", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (DialogResult.Yes==d)
            {
                Application.Exit();
            }
        }

        private void app_minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void teacher_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}