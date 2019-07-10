using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string a = "admin";
            string b = "12345";
            //MessageBox.Show(usaername);
            if (username == a &&  password == b)
            {
                MessageBox.Show("duzdur");
                
            }
            else
            {
                MessageBox.Show("sehvdir");
                txtUsername.Text = null;
                txtpassword.Text = null;


            }

            }
        


        
    }
}
