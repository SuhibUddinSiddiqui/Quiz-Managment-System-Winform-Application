using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_system
{
    public partial class createQuiz_control : UserControl
    {
        public createQuiz_control(string Sno)
        {
            InitializeComponent();
            Sno_label.Text = Sno+".";
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void createQuiz_control_Load(object sender, EventArgs e)
        {

        }
    }
}
