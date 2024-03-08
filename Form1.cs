using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            string XLogin,Xpwd;
            XLogin=txt_login.Text;
            Xpwd =txt_password.Text;
            if (XLogin != "" && Xpwd != "")
            {
                table Tspec = new table();
                Tspec.Show();

            }
            else
            {
                MessageBox.Show("verfier votre inforamtion","Authentification", MessageBoxButtons.OK ,MessageBoxIcon.Information   );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}