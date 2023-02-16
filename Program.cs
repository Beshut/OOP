using System;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Покажите диалоговое окно "Открыть файл". Если пользователь нажмет кнопку ОК, загрузите
                // изображение, которое выбрал пользователь.
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закройте форму.
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Покажите диалоговое окно "Цвет". Если пользователь нажмет кнопку ОК, измените
            // фон элемента управления PictureBox соответствует цвету, выбранному пользователем.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Проясните картину.
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если пользователь установит флажок Растягивать,
            // измените размер PictureBox в
            // Свойство SizeMode для "растягивания". Если пользователь очищает
            // установите флажок, измените его на "Обычный".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
