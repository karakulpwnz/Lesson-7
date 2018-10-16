using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCount.Text = "0";
            btnStart.Text = "Играть";
            this.Text = "Удвоитель";
            Hide();
            lblCongratz.Hide();
        }

        int counter = 0;
        int trueNumber = 0;

        private void Hide()
        {
            btnCommand1.Hide();
            btnCommand2.Hide();
            btnReset.Hide();
            lblHeaderCount.Hide();
            lblCount.Hide();
            lblHeaderNumber.Hide();
            lblNumber.Hide();
            lblHeaderTrueNumber.Hide();
            lblTrueNumber.Hide();
        }

        /// <summary>
        /// Счетчик попыток и обновление лейбла с кол-ом ходов.
        /// </summary>
        /// <param name="counter">параметр с попытками</param>
        /// <param name="label">название лейбла, в который нужно вывести результат</param>
        /// <returns></returns>
        private int Counter(int counter, Label label)
        {
            counter++;
            label.Text = counter.ToString();
            return counter;
        }
        /// <summary>
        /// Проверка совпадения искомого числа и числа пользвоателя
        /// </summary>
        /// <param name="userNumber"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool Check(int userNumber, int number)
        {
            if (userNumber == number) return true;
            else return false;
        }
        /// <summary>
        /// +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            counter = Counter(counter, lblCount);
            if (Check(int.Parse(lblNumber.Text), trueNumber))
            {
                lblCongratz.Show();
                lblCongratz.Text = "Вы получили число " + trueNumber + " с " + counter + " попыток";
                Hide();
            }
            
        }
        /// <summary>
        /// х 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            counter = Counter(counter, lblCount);

            if (Check(int.Parse(lblNumber.Text), trueNumber))
            {
                lblCongratz.Show();
                lblCongratz.Text = "Вы получили число " + trueNumber + " с " + counter + " попыток";
                Hide();
            }
        }
        /// <summary>
        /// Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            counter = 0;
            lblCount.Text = "0";
        }
        /// <summary>
        /// Старт или рестарт (генерация нового числа) игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            trueNumber = rnd.Next(1, 256);
            btnStart.Text = "Заново";
            lblNumber.Text = "0";
            counter = 0;
            lblCount.Text = "0";
            lblCongratz.Hide();
            btnCommand1.Show();
            btnCommand2.Show();
            btnReset.Show();
            lblHeaderCount.Show();
            lblCount.Show();
            lblHeaderNumber.Show();
            lblNumber.Show();
            lblHeaderTrueNumber.Show();
            lblTrueNumber.Show();
            lblTrueNumber.Text = trueNumber.ToString();
        }
    }
}
