using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showPass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !chk_showPass.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }
    }
}
