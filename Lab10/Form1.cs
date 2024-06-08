using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double lambda1, lambda2;
            Random rand = new Random();

            lambda1 = (double)edLamb1.Value;
            lambda2 = (double)edLamb2.Value;

            double a1, a2;
            double sum1 = 0, sum2 = 0;
            int goals1 = 0, goals2 = 0;

            while (sum1 >= -lambda1 || sum2 >= -lambda2)
            {
                a1 = rand.NextDouble();
                a2 = rand.NextDouble();

                if (sum1 >= -lambda1)
                {
                    sum1 += Math.Log10(a1);
                    goals1++;
                }

                if (sum2 >= -lambda2)
                {
                    sum2 += Math.Log10(a2);
                    goals2++;
                }
            }

            if (goals1 > goals2)
            {
                label5.Text = $"Победила первая команда со счётом {goals1} : {goals2}";
                return;
            }
            else if (goals2 > goals1)
            {
                label5.Text = $"Победила вторая команда со счётом {goals1} : {goals2}";
                return;
            }
            else
            {
                label5.Text = $"Ничья со счётом {goals1} : {goals2}";
                return;
            }
        }
    }
}
