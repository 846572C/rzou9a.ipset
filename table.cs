using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WinFormsApp1
{
    









    public partial class table : Form
    {
        OleDbConncetion cns = new OleDbConncetion('Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\moham\Documents\Base de données1.accdb"');
        public table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void table_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_connect_Click(object sender, EventArgs e)
        {

        }
    }
}
