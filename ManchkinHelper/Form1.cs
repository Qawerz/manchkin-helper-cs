using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManchkinHelper
{
    public partial class Form1 : Form
    {

        static int steps = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            steps++;
            int p1 = Convert.ToInt32(numericUpDown1.Value);
            int p2 = Convert.ToInt32(numericUpDown2.Value);
            int p3 = Convert.ToInt32(numericUpDown3.Value);
            int p4 = Convert.ToInt32(numericUpDown4.Value);
            int p5 = Convert.ToInt32(numericUpDown5.Value);
            int p6 = Convert.ToInt32(numericUpDown6.Value);
            int p7 = Convert.ToInt32(numericUpDown14.Value);

            chart1.Series[0].Points.AddXY(steps, p1);
            chart1.Series[1].Points.AddXY(steps, p2);
            chart1.Series[2].Points.AddXY(steps, p3);
            chart1.Series[3].Points.AddXY(steps, p4);
            chart1.Series[4].Points.AddXY(steps, p5);
            chart1.Series[5].Points.AddXY(steps, p6);
            chart1.Series[6].Points.AddXY(steps, p7);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

            button3.Visible = false;
            button2.Enabled = true;

            chart1.Series.Add(textBox1.Text);
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox2.Text);
            chart1.Series[1].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox3.Text);
            chart1.Series[2].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox4.Text);
            chart1.Series[3].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox5.Text);
            chart1.Series[4].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox6.Text);
            chart1.Series[5].ChartType = SeriesChartType.Spline;
            chart1.Series.Add(textBox7.Text);
            chart1.Series[6].ChartType = SeriesChartType.Spline;


            chart1.Series[0].Points.AddXY(steps, 1);
            chart1.Series[1].Points.AddXY(steps, 1);
            chart1.Series[2].Points.AddXY(steps, 1);
            chart1.Series[3].Points.AddXY(steps, 1);
            chart1.Series[4].Points.AddXY(steps, 1);
            chart1.Series[5].Points.AddXY(steps, 1);
            chart1.Series[6].Points.AddXY(steps, 1);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 1;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) + Convert.ToInt32(numericUpDown7.Value));
            if (Convert.ToInt32(textBox8.Text) >= 1000)
            {
                textBox8.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) - 1000);
                numericUpDown1.Value+=1;
            }

            textBox9.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) + Convert.ToInt32(numericUpDown8.Value));
            if (Convert.ToInt32(textBox9.Text) >= 1000)
            {
                textBox9.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) - 1000);
                numericUpDown2.Value += 1;
            }

            textBox10.Text = Convert.ToString(Convert.ToInt32(textBox10.Text) + Convert.ToInt32(numericUpDown9.Value));
            if (Convert.ToInt32(textBox10.Text) >= 1000)
            {
                textBox10.Text = Convert.ToString(Convert.ToInt32(textBox10.Text) - 1000);
                numericUpDown3.Value += 1;
            }
            textBox11.Text = Convert.ToString(Convert.ToInt32(textBox11.Text) + Convert.ToInt32(numericUpDown10.Value));
            if (Convert.ToInt32(textBox11.Text) >= 1000)
            {
                textBox11.Text = Convert.ToString(Convert.ToInt32(textBox11.Text) - 1000);
                numericUpDown4.Value += 1;
            }
            textBox12.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) + Convert.ToInt32(numericUpDown11.Value));
            if (Convert.ToInt32(textBox12.Text) >= 1000)
            {
                textBox12.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) - 1000);
                numericUpDown5.Value += 1;
            }
            textBox13.Text = Convert.ToString(Convert.ToInt32(textBox13.Text) + Convert.ToInt32(numericUpDown12.Value));
            if (Convert.ToInt32(textBox13.Text) >= 1000)
            {
                textBox13.Text = Convert.ToString(Convert.ToInt32(textBox13.Text) - 1000);
                numericUpDown6.Value += 1;
            }
            textBox14.Text = Convert.ToString(Convert.ToInt32(textBox14.Text) + Convert.ToInt32(numericUpDown13.Value));
            if (Convert.ToInt32(textBox14.Text) >= 1000)
            {
                textBox14.Text = Convert.ToString(Convert.ToInt32(textBox14.Text) - 1000);
                numericUpDown14.Value += 1;
            }

            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
        }
    }
}
