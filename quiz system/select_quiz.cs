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
    public partial class select_quiz : MetroFramework.Forms.MetroForm
    {
      
        public select_quiz()
        {
            InitializeComponent();
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void difficulty_novice_Click(object sender, EventArgs e)
        {
            generate_quiz.difficulty = "novice";
            this.Hide();
            

        }

        private void difficulty_pro_Click(object sender, EventArgs e)
        {
            generate_quiz.difficulty = "pro";
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            generate_quiz.subject = "pf";
            metroButton6.Visible = false;
            metroButton5.Visible = true;
            metroButton7.Visible = true;
            metroButton12.Visible = true;
            metroButton13.Visible = true;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            generate_quiz.subject = "oop";
            metroButton6.Visible = true;
            metroButton5.Visible = false;
            metroButton7.Visible = true;
            metroButton12.Visible = true;
            metroButton13.Visible = true;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            generate_quiz.subject = "ds";
            metroButton6.Visible = true;
            metroButton5.Visible = true;
            metroButton7.Visible = false;
            metroButton12.Visible = true;
            metroButton13.Visible = true;
        }
    }
}
