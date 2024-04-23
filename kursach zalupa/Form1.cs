using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void oleDbConnection1_InfoMessage_1(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
