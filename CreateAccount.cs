using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string username = textBox1CreateUsername.Text;
            string password = textBoxCreateMasterPassword.Text;
            string passwordConfirmation = textBox2MasterPasswordConfirmation.Text;
            string email = textBoxCreateEmail.Text;

            if(string.IsNullOrEmpty(username) || 
                string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(passwordConfirmation) ) {
                MessageBox.Show("All fields are required!");
                return;
            }
            if(password != passwordConfirmation)
            {
                MessageBox.Show("Password mismatch!!");
                return ;
            }

            if(password.Count() > 8 ) {
                MessageBox.Show("Master password must be over 8 characters!!!");
                return;
            }
            
            try
            {
                MailAddress address = new MailAddress(email);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid email!");
                return;
            }
        }
    }
}
