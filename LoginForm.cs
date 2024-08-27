using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //<sumary>

        private void buttonLogin_Click(object sender, EventArgs e)
        { 
            PasswordList passwordList = new PasswordList();
            Hide();
            passwordList.FormClosed += passwordList_FormClosed;
            passwordList.ShowDialog();
        }

        private void passwordList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //<Sumary>
    }
}
