using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SMLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double allTime = (double)allTimeUpDown.Value;
            double L = (double)lengthUpDown.Value;
            double tileStep = (double)tileCountUpDown.Value;
            double timeStep = (double)timeStepUpDown.Value;
            int stepCount = (int)(allTime / timeStep) + 1;
            int tileCount = Math.Max((int)(L / tileStep), 3);   
            double TL = (double)temperatureLUpDown.Value;
            double TR = (double)temperatureRUpDown.Value;
            double T0 = (double)temperatureMUpDown.Value;
            double density = (double)densityUpDown.Value;
            double capacity = (double)capacityUpDown.Value;
            double conductivity = (double)conductivityUpDown.Value;
            

            double[] T_cur = new double[tileCount];
            double[] T_next = new double[tileCount];
            double[] a1 = new double[tileCount];
            double[] b1 = new double[tileCount];

            for (int i = 0; i < tileCount; i++) T_cur[i] = T0;

            T_cur[0] = TL;
            T_cur[tileCount - 1] = TR;


            for (int step = 0; step < stepCount; step++)
            {
                a1[0] = 0;
                b1[0] = TL;

                for (int i = 1; i < tileCount - 1; i++)
                {
                    double ch2 = conductivity / (tileStep * tileStep);
                    double Ai = ch2;
                    double Ci = Ai;
                    double Bi = 2 * ch2 + density * capacity / timeStep;
                    double Fi = -density * capacity / timeStep * T_cur[i];

                    a1[i] = Ai / (Bi - Ci * a1[i - 1]);
                    b1[i] = (Ci * b1[i - 1] - Fi) / (Bi - Ci * a1[i - 1]);
                }

                T_next[tileCount - 1] = TR;

                for (int i = tileCount - 2; i >= 0; i--)
                {
                    T_next[i] = a1[i] * T_next[i + 1] + b1[i];
                }
                Array.Copy(T_next, T_cur, tileCount);
            }
            double T_result = T_cur[tileCount / 2];
            middleTemp.Text = ((T_result >= 0) ? "+" : "-") + string.Format("{0:f4}", T_result);

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
