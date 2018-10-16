using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNumber.Hide();
            lblNumber.Text = Random().ToString();
            lblResult.Text = "";
            lblHeader.Text = "Угадайте число от 1 до 100";
            btnSubmit.Text = "Проверить";
            btnRestart.Text = "Заново";
            btnRestart.Hide();
        }

        int counter = 0;
        /// <summary>
        /// Генератор случайного числа
        /// </summary>
        /// <returns></returns>
        private int Random()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtUserNumber.Text) == int.Parse(lblNumber.Text))//проверка на совпадение загаданному числу
                {
                    counter++;
                    lblResult.Text = "Угадал за " + counter + " попыток";
                    txtUserNumber.Hide();
                    btnSubmit.Hide();
                    btnRestart.Show();

                }
                else if (int.Parse(txtUserNumber.Text) > int.Parse(lblNumber.Text))
                {
                    lblResult.Text = "Слишком большое число";
                    counter++;
                }
                else if (int.Parse(txtUserNumber.Text) < int.Parse(lblNumber.Text))
                {
                    lblResult.Text = "Слишком маленькое число";
                    counter++;
                }

                txtUserNumber.Clear();
                txtUserNumber.Focus();
            }
            catch//отлов исключений при вводе
            {
                txtUserNumber.Clear();
                txtUserNumber.Focus();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            lblNumber.Text = Random().ToString();
            counter = 0;
            txtUserNumber.Show();
            btnSubmit.Show();
            btnRestart.Hide();
            lblResult.Text = "";
        }
    }
}
