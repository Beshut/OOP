using System;
using System.Windows.Forms;

namespace Lesson_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int NumberSymbols(string stroka, string symbol)
        {
            int k = 0;
            int j = 0;
            char[] mas = new char[symbol.Length];
            for (int i = 0; i < symbol.Length; i++)
            {
                string chast = symbol[i].ToString();
                mas[i] = char.Parse(chast);
            }

            int f = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == mas[f])
                {
                    j += 1;
                    f += 1;
                }

                if (j == symbol.Length)
                {
                    k += 1;
                    j = 0;
                    f = 0;
                }
            }
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKolvo.Text = NumberSymbols(txtString.Text, txtPoisk.Text).ToString();
        }
    }
}
