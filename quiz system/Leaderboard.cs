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
    static class Leaderboard
    {
        static public Chart leader_board;
        static string[] data;

        static public void Create_chart(Panel panel)
        {
            leader_board = new Chart();
            leader_board.Width = 761;
            leader_board.Height = 471;
            leader_board.Location = new Point(18, 55);
            Fill();
            panel.Controls.Add(leader_board);
        }
        static void Fill()
        {
            GetData();
            leader_board.Series.Add("Overall");
            for (int i = 0; i < data.Length - 1; i += 8)
            {
                if (data[i] == "student")
                {
                    leader_board.Series["Overall"].Points.AddXY(data[i+1],data[i+5]);
                }
            }
         
            leader_board.Titles.Add("Percentage Comparison");
            leader_board.Legends.Add("courses");
            leader_board.Legends["courses"].Title = "Course Names";
            leader_board.ChartAreas.Add("ChartArea1");
            leader_board.ChartAreas["ChartArea1"].AxisX.Title = "Students";
            leader_board.ChartAreas["ChartArea1"].AxisY.Title = "Percentage";
            leader_board.ChartAreas["ChartArea1"].AxisY.TextOrientation = TextOrientation.Rotated270;
            leader_board.Series["Overall"].Color = Color.DimGray;
            leader_board.ChartAreas["ChartArea1"].AxisY.Maximum = 100;
            leader_board.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            leader_board.ChartAreas["ChartArea1"].AxisY.Interval = 10;
            leader_board.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            leader_board.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            leader_board.Series["Overall"].ChartType = SeriesChartType.Column;
            

        }
        static void GetData()
        {
            StreamReader sr = new StreamReader("userdata.txt");
            data = sr.ReadToEnd().Replace("\r\n", "").Split(',');
            sr.Close();
        }
        static public void Dispose()
        {
            leader_board.Dispose();
        }
    }
}
