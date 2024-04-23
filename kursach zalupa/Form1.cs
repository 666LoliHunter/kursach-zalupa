using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_zalupa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // прочитать данные из БД
            oleDbDataAdapter1.Fill(dataSet1.Tables[0]);

            // можно и так:
            // oleDbDataAdapter1.Fill(dataSet1.Tables["сontacts"]);
        }

        // завершение работы программы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet1.Tables[0]);
        }
        // пользователь выделил строку и нажал <Delete>
        private void dataGridView1_UserDeletingRow(object sender,

        DataGridViewRowCancelEventArgs e)

        {
            DialogResult dr = MessageBox.Show(

            "Запись будет удалена из БД.\nВыполнить?",
            "Удаление записи",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void oleDbConnection1_InfoMessage_1(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
