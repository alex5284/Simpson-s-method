using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s;
        double a, b, n, e;

        private void btnRunge_Click(object sender, EventArgs e)
        {
            Runge();
        }

        private void btnSimpsona_Click(object sender, EventArgs e)
        {
            Simpsona();
        }

        void InitExpr()
        {
            s = tbExp.Text;
            a = Convert.ToDouble(tbA.Text);
            b = Convert.ToDouble(tbB.Text);
            n = Convert.ToDouble(tbN.Text);
            e = Convert.ToDouble(tbE.Text);
        }
        void Simpsona()
        {
            InitExpr();
            listBox1.Items.Clear();
            int n1 = Convert.ToInt32(n);
            double h = (b - a) / (n-1);
            double[] X = new double[n1];
            double[] Y = new double[n1];
            MathExpression f = new MathExpression(s);
            X[0] = a;
            Y[0] = f.Calculate(X[0]);
            for (int i = 1; i < n1; i++)
            {
                X[i] = X[i - 1] + h;
                Y[i] = f.Calculate(X[i]);
            }
            double S1 = (Y[0] + Y[n1-1])/2.0;
            double S2 = 0;
            double S3 = 0;
            for(int i = 1; i < n1 - 1; i++)
            {
                S2 += Y[i];
                S3 += f.Calculate((X[i - 1] + X[i]) / 2.0);
            }
            S3 += f.Calculate((X[n1 - 2] + X[n1 - 1]) / 2.0);
            double S = h / 3.0 * (S1 + S2 + 2 * S3);
            //for (int i = 1; i < n1 - 1; i++)
            //{
            //    if (i % 2 != 0) S2 += Y[i];
            //    else S3 += Y[i];
            //}
            //double S = h / 3.0 * (S1 + 4 * S2 + 2 * S3);
            //for(int i = 1; i < n1-1; i++)
            //{
            //    S2 += Y[i];
            //}
            //double S = h / 3.0 * (S1 + 4 * S2);
            listBox1.Items.Add("h = " + Math.Round(h,4).ToString() );
            listBox1.Items.Add("I(f) = " + S.ToString());
        }
        void Runge()
        {
            InitExpr();
            int z = Convert.ToInt32(numZeroesAfterPoint(e));
            listBox1.Items.Clear();
            List<double> S_all = new List<double>();
            //double h1 = Math.Pow(e, 1 / 4.0);
            int n1 = 0;
            //if (n1 % 2 != 0) n1++;
            double h = 0;
            for (int j = 0; j < 20000000; j++)
            {
                if(j == 0)
                {
                    n1 = 11;//(int)((b - a) / h1);
                    //if (n1 % 2 != 0) n1++;
                    h = (b - a) / (n1);
                }
                else
                {
                    n1 = n1 * 2;
                    h = (b - a) / (n1);
                }
                double[] X = new double[n1 + 1];
                double[] Y = new double[n1 + 1];
                MathExpression f = new MathExpression(s);
                X[0] = a;
                Y[0] = f.Calculate(X[0]);
                for (int i = 1; i < n1+1; i++)
                {
                    X[i] = a + i * h;
                    Y[i] = f.Calculate(X[i]);
                }
                double S1 = (Y[0] + Y[n1]) / 2.0;
                double S2 = 0;
                double S3 = 0;
                for (int i = 1; i < n1; i++)
                {
                    S2 += Y[i];
                    S3 += f.Calculate((X[i - 1] + X[i]) / 2.0);
                }
                S3 += f.Calculate((X[n1 - 1] + X[n1]) / 2.0);
                double S = h / 3.0 * (S1 + S2 + 2 * S3);
                S_all.Add(S);
                if (j >= 1)
                {
                    if (Math.Abs(S_all[j] - S_all[j - 1]) / 15.0 <= e)//
                    {
                        listBox1.Items.Add("h = " + h.ToString());
                        listBox1.Items.Add("I(f) = " + S_all[j].ToString());
                        break;
                    }
                    //else h = h / 2.0;
                }
                //else { h = h / 2.0; } n1 = n1 * 2;
            }
        }
        double numZeroesAfterPoint(double x)
        { // функція повертає кількість нулів, перед тим як ідуть числа
            if ((x % 1) == 0)
            {
                return 0;
            }
            else
            {
                return -1 - Math.Floor(Math.Log10(x % 1));
            }
        }
    }
}
