namespace Facebook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_password = new TextBox();
            button_login = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_useremail = new TextBox();
            button_newaccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(321, 168);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(164, 27);
            textBox_password.TabIndex = 2;
            // 
            // button_login
            // 
            button_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.Location = new Point(334, 220);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 117);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(214, 168);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Castellar", 18F);
            label4.Location = new Point(303, 57);
            label4.Name = "label4";
            label4.Size = new Size(182, 36);
            label4.TabIndex = 5;
            label4.Text = "Welcome";
            // 
            // textBox_useremail
            // 
            textBox_useremail.Location = new Point(321, 118);
            textBox_useremail.Name = "textBox_useremail";
            textBox_useremail.Size = new Size(164, 27);
            textBox_useremail.TabIndex = 1;
            // 
            // button_newaccount
            // 
            button_newaccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_newaccount.Location = new Point(264, 282);
            button_newaccount.Name = "button_newaccount";
            button_newaccount.Size = new Size(221, 29);
            button_newaccount.TabIndex = 4;
            button_newaccount.Text = "Crate New Account";
            button_newaccount.UseVisualStyleBackColor = true;
            button_newaccount.Click += button_newaccount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_newaccount);
            Controls.Add(textBox_useremail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_password;
        private Button button_login;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_newaccount;
        public TextBox textBox_useremail;
    }
}
