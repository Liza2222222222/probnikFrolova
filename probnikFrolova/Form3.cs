using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace probnikFrolova
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 form1 = new Form1();
            form1.ShowDialog();
            return;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
           
            label1.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = false;
            ShowClientInGrid("SELECT * FROM users");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            
            label1.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = false;
            ShowClientInGrid("SELECT * FROM number_of_rooms");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            label1.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = false;
            ShowClientInGrid("SELECT * FROM room_status");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void отчётностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = false;
            dataGridView1.Visible = false;
            label2.Visible = true;
            button1.Visible = true;
            label2.MaximumSize = new System.Drawing.Size(1100, label2.MaximumSize.Height);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, label2.Text);
            MessageBox.Show("Отчет был успешно сохранен!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void постояльцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            panel1.Visible = false;
            label1.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = false;
            ShowClientInGrid("SELECT * FROM guests");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        string connectionsString = "Server=localhost;Port=3306;Database=probnikfrolova;Username=root;Password=root;";
        void ShowClientInGrid(string q)
        {
            MySqlConnection connection = new MySqlConnection(connectionsString);
            connection.Open();
            string query = q;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable(); 
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}

