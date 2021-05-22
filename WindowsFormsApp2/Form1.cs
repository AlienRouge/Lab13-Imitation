using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Geimetric : Form
    {
        const int N = 5;
        double[] prob = new double[N];
        double p0;
        int n;
        double chiConst = 9.488;

        public Geimetric()
        {
            InitializeComponent();
        }

        void InitGeometric()
        {
            double sum = 0;
            for (int i = 0; i < N - 1; i++)
            {
                prob[i] = (p0 * Math.Pow((1 - p0), i));
                sum += prob[i];
            }

            prob[N - 1] = 1 - sum;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rnd = new Random();
            p0 = (double) Pprob.Value;
            InitGeometric();

            n = (int) NumberOfExper.Value;
            int[] mass = new int[N];
            for (int i = 0; i < n; i++)
            {
                int x = (int) (Math.Log(rnd.NextDouble()) / Math.Log(1 - p0));
                if (x > prob.Length - 1)
                {
                    mass[prob.Length - 1]++;
                }
                else
                    mass[x]++;
            }

            double[] prob1 = new double[mass.Length];
            double chiSquare = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                prob1[i] = (double) mass[i] / n;
                chiSquare += Math.Pow(mass[i], 2) / (prob[i] * n);
                Console.WriteLine(chiSquare);
                chart1.Series[0].Points.AddXY(i + 1, (float) mass[i] / n);
            }

            chiSquare -= n;
            Console.WriteLine(chiSquare);

            double me1 = 0;
            double me2 = 0;
            double de1 = 0;
            double de2 = 0;
            for (int i = 0; i < prob1.Length; i++)
            {
                me1 += (i + 1) * prob[i];
                me2 += (i + 1) * prob1[i];
                de1 += (float) Math.Pow((i + 1), 2) * prob[i];
                de2 += (float) Math.Pow((i + 1), 2) * prob1[i];
            }

            de1 -= (float) Math.Pow(me1, 2);
            de2 -= (float) Math.Pow(me2, 2);
            RelAver.Text = $@"{Math.Round(me2, 3)} (error = {Math.Round(Math.Abs(me2 - me1) / Math.Abs(me2) * 100)}%)";
            RelVariance.Text = $@"{Math.Round(de2, 3)} (error = {Math.Round(Math.Abs(de2 - de1) / Math.Abs(de2) * 100, 2)}%)";
            ResChi.Text = chiSquare < chiConst
                ? $"{Math.Round(chiSquare, 3)} < {chiConst}  is {false}"
                : $"{Math.Round(chiSquare, 3)} > {chiConst}  is {true}";
        }
    }
}