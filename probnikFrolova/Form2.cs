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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);

        }

        private void BtnAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            return;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = false;
            label1.Visible = false;
            oNas.Visible = true;
            panel1.Visible = true;
            oNas.Text = "Добро пожаловать в наш салон!\r\n\r\nМы рады предложить вам широкий спектр услуг по уходу за бровями, кожей  лица и ногтями. Вот основные направления нашего сервиса:\r\nУслуги:\r\nУход за лицом:\r\nЧистка кожи\r\nПилинг\r\nУвлажняющие и питательные маски\r\nУход за телом:\r\nМассаж (классический, расслабляющий)\r\nОбертывания\r\nСкрабы\r\nМаникюр и педикюр:\r\nКлассический и аппаратный маникюр\r\nГелевое и акриловое наращивание\r\nУход за стопами и ногтями\r\nМы ценим каждого клиента и стремимся сделать ваше пребывание у нас максимально комфортным. Ждем вас в нашем салоне! ";
            oNas.MaximumSize = new System.Drawing.Size(750, oNas.MaximumSize.Height);

        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = false;
            oNas.Visible = false;
            label1.Visible = true;
            panel1.Visible = true;
            label1.Text = "Контактная информация:\r\nАдрес: [Пушкина 23]\r\nТелефон: [+7 (903) 666-44]\r\nЧасы работы: [Пн-Пт: 10.00-18.00\n Сб-Вс: Выходной] ";
            label1.MaximumSize = new System.Drawing.Size(750, label1.MaximumSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            oNas.Visible = false;
            label1.Visible = false;
            // Set up the DataGridView columns
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Специалист";
            dataGridView1.Columns[0].ReadOnly = true;

            // Generate random data for the DataGridView
            Random random = new Random();
            string[] specialist = { "Гребенникова Наталья Александровна", "Завьялова Виолетта Сергеевна", "Иванова Анастасия Алексеевна.", "Селицкая Юлия Викторовна", "Костромина Александра Сергеевна" };
            dataGridView1.Rows.Clear();

            // Fill 5 rows with random data
            for (int i = 0; i < specialist.Length; i++)
            {
                dataGridView1.Rows.Add(specialist[i]);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            oNas.Visible = false;
            label1.Visible = false;
            // Set up the DataGridView columns
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Дата";
            dataGridView1.Columns[1].Name = "Время";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;

            // Generate random data for the DataGridView
            Random random = new Random();
            string[] data = { "02.12.2024", "03.12.2024", "04.12.2024", "05.12.2024", "06.12.2024", "09.12.2024", "10.12.2024", "27.11.2024", "28.11.2024", "29.11.2024", "11.12.2024" };
            string[] time = { "10.00", "11.30", "11.00", "10.30", "12.00", "12.30", "13.30", "13.00", "14.30", "15.00", "15.20" };
            dataGridView1.Rows.Clear();

            // Fill 5 rows with random data
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows.Add(data[i], time[i]);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            oNas.Visible = false;
            label1.Visible = false;
            // Set up the DataGridView columns
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Услуги";
            dataGridView1.Columns[0].ReadOnly = true;

            // Generate random data for the DataGridView
            Random random = new Random();
            string[] special = { "Маникюр", "Педикюр", "Массаж лица", "Пилинг лица", "Чистка лица", "Увлажняющие и питательные маски", "Обертывания", "Ламинирование бровей", "Ламинирование ресниц" };
            dataGridView1.Rows.Clear();

            // Fill 5 rows with random data
            for (int i = 0; i < special.Length; i++)
            {
                dataGridView1.Rows.Add(special[i]);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
