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

    public partial class questions_control : UserControl
    {

        public questions_control(int Qno, string Question)
        {
            InitializeComponent();
            question_label.Text = Question;
            Qno_label.Text = (Qno + 1).ToString()+"." ;
        }

    }
}

