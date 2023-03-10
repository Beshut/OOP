using System;
using System.Windows.Forms;

namespace Lab6_1
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        bool kon = false;
        private void tmr_Tick(object sender, EventArgs e)
        {
            if ((pct.Left < 207 || pct.Left == 207) && kon == true && bthStart.Text == "Стоп" && pct.Left > 35)
            {
                pct.Left = pct.Left - 4;
            }

            if (pct.Left == 35 && kon == true)
            {
                bthStart.Text = "Старт";
                kon = false;
            }

            if (pct.Left == 207)
            {
                bthStart.Text = "Старт";
                kon = true;
            }

            if (pct.Left < 207 && kon == false && bthStart.Text == "Стоп")
            {
                pct.Left = pct.Left + 4;
            }
        }

        private void bthStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
            tmr.Interval = 50;

            if (bthStart.Text == "Старт")
            {
                bthStart.Text = "Стоп";
            }
            else
            {
                bthStart.Text = "Старт";
                tmr.Stop();
            }
        }

        private void bthExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
