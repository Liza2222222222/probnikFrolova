using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probnikFrolova
{
    public partial class Form1 : Form
    {
            private (string Login, string Password)[] users = new (string, string)[]
            {
            ("admin", "admin123"),
            ("user", "user123")

            };      
        public Form1()
        {
            InitializeComponent();
        }
        int block = 3;
        private void button1_Click(object sender, EventArgs e)
        {


            //проверка пустых полей
            string login = loginBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль обязательны для заполнения!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //проверка логина и пароля
            foreach (var user in users)
            {

                if (user.Login == login && user.Password == password)
                {
                    if (user.Login == "admin" && user.Password == "admin123")
                    {
                        MessageBox.Show("Вы вошли  систему как Администратор, \n добро пожаловать!");
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Вы вошли  систему как Пользователь, \n добро пожаловать!");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        return;
                    }
                }

            }
            MessageBox.Show("Неправильный логин или пароль!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //проверка на блокировку 
            block--;
            if (block == 2)
            {
                MessageBox.Show("Логин или пароль введён неверно,осталось " + block + " попытки до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (block == 1)
            {
                MessageBox.Show("Логин или пароль введён неверно,осталась " + block + " попытка до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loginBox.Enabled = false;
                passwordBox.Enabled = false;
                MessageBox.Show("Вы заблокированы. \nОбратитесь к администратору!", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

    }
}

