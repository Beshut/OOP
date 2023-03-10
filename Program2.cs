using System;
using System.Windows.Forms;

namespace Lab6_2
{
    public partial class Lab6_2 : Form
    {
        public Lab6_2()
        {
            InitializeComponent();
        }

        private void bthCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x, precision;
            bool f = false;
            do
            {
                counter++;
                if (double.TryParse(txtPrecision.Text, out precision))
                {
                    f = true;
                }

                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }

                sum += summand;
            } while (f && Math.Abs(summand) > precision);

            if (f)
            {
                lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            }
            else
            {
                MessageBox.Show("Введите числоыое значение!");
                txtPrecision.Text = String.Empty;
            }
        }
    }
}
