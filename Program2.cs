using System;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int tmpM = Int32.Parse(txtMinutes.Text);
            tmp += 1;
            if (tmp != 60)
            {
                txtSeconds.Text = tmp.ToString();
            }
            else
            {
                txtSeconds.Text = "0";
                tmpM += 1;
                txtMinutes.Text = tmpM.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Start();
            if (btnStart.Text == "Старт")
            {
                btnStart.Text = "Стоп";
            }
            else
            {
                btnStart.Text = "Старт";
                tmrSecundomer.Stop();
            }
            
        }

        private void bthRecord_Click(object sender, EventArgs e)
        {
            txtRecord.Text = $"{txtMinutes.Text} мин. {txtSeconds.Text} сек.";
        }
    }
}
