using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab1
{
    public partial class Form1 : Form
    {
        double v0;
        double m = 2;
        double angle = 0;
        double S = 1;
        int seriesnumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v0 = (double)InputSpeed.Value;
            m = (double)InputWeight.Value;
            angle = (double)InputAngle.Value * Math.PI / 180;
            S = (double)InputSize.Value;

            const double g = 9.8;
            double p = 1.29;
            double C = 0.15;
            double k = (C * S * p) / (2 * m);
            double x = 0;
            double y = 0;
            double v = 0;
            double vx = v0 * Math.Cos(angle);
            double vy = v0 * Math.Sin(angle);
            double t_step = (double)InputTStep.Value;

            
            seriesnumber += 1;
            Series newSeries = new Series("Series"+(seriesnumber).ToString());

            newSeries.ChartType = SeriesChartType.Line;
            newSeries.ChartArea = chart1.ChartAreas[0].Name;
            newSeries.Color = Color.Blue;
            newSeries.BorderWidth = 2;

            newSeries.Points.Clear();
            newSeries.Points.AddXY(0, 0);

            double maxHeight = 0;

            string results = "";
            while (y >= 0)
            {
                
                v = Math.Sqrt(vx * vx + vy * vy);
                vx = vx - k * vx * v * t_step;
                vy = vy - (g + k * vy * v) * t_step;
                x = x + vx * t_step;
                y = y + vy * t_step;
                Console.WriteLine(y);
                newSeries.Points.AddXY(x, y);
                chart1.Update();

                
                if (y > maxHeight) maxHeight = y;
            }
            chart1.Series.Add(newSeries);
            results += "Series" + (seriesnumber).ToString() + " t step:" + t_step.ToString() +  "\n";
            results += "Last velocity: " + string.Format("{0:f4}", v) + " ";
            results += "Max height: " + string.Format("{0:f4}", maxHeight) + " ";
            results += "Length: " + string.Format("{0:f4}", x) + "\n";
            ResultsLabel.Text += results;
        }

        private void InputAngle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InputSpeed_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
