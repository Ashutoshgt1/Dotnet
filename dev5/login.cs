using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev5
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            if(Username=="admin"&& Password=="1234")
            {
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid username & password");
            }
        }
    }
}
