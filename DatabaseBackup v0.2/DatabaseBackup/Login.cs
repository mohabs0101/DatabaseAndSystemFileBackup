using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackup
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {

            if(TXT_username.Text =="a"&& TXT_password.Text=="a")
            {
                this.Hide();
                DatabaseBackup db = new DatabaseBackup();
                db.Show();

            }
            else
            {
                MessageBox.Show("username or password incorrect");
            }
        }

        private void BTN_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTN_login.PerformClick();
        }
    }
}
