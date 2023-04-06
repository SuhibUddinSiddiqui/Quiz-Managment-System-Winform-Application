using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_system
{
    public partial class Admin_Dashboard : MetroFramework.Forms.MetroForm
    {
        string username;
        public Admin_Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Create_quiz_button_Click(object sender, EventArgs e)
        {
            admin_profile_panel.Hide();
            admin_create_panel.Hide();
            student_data_panel.Hide();
            Create_quiz.question_no=int.Parse(textBox1.Text) ;
            Create_quiz.Create_quiz_panel(admin_panel);
        }

        private void app_close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "", "ARE YOU SURE YOU WANT TO EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult.Yes == dr)
            {
                Application.Exit();
            }

        }

        private void app_minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login l = new login();
            l.Show();
        }

        private void Dashboard_button_Click(object sender, EventArgs e)
        {
            Create_quiz.dispose();
            admin_profile_panel.Show();
            admin_create_panel.Show();
            student_data_panel.Show();
        }
    }
}
