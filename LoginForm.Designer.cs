namespace PasswordManager
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.textBox2MasterPassword = new System.Windows.Forms.TextBox();
            this.button1Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Master Password";
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(238, 89);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(311, 31);
            this.textBox1Username.TabIndex = 2;
            // 
            // textBox2MasterPassword
            // 
            this.textBox2MasterPassword.Location = new System.Drawing.Point(238, 260);
            this.textBox2MasterPassword.Name = "textBox2MasterPassword";
            this.textBox2MasterPassword.PasswordChar = '*';
            this.textBox2MasterPassword.Size = new System.Drawing.Size(311, 31);
            this.textBox2MasterPassword.TabIndex = 3;
            this.textBox2MasterPassword.UseSystemPasswordChar = true;
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(327, 311);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(98, 51);
            this.button1Login.TabIndex = 4;
            this.button1Login.Text = "Login";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Login);
            this.Controls.Add(this.textBox2MasterPassword);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.TextBox textBox2MasterPassword;
        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.Button button1;
    }
}

