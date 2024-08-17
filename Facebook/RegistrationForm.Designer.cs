namespace Facebook
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_firstname = new TextBox();
            label2 = new Label();
            textBox_userlastname = new TextBox();
            label3 = new Label();
            textBox_useremail = new TextBox();
            label4 = new Label();
            comboBox_day = new ComboBox();
            comboBox_month = new ComboBox();
            comboBox_year = new ComboBox();
            label5 = new Label();
            comboBox_gender = new ComboBox();
            label6 = new Label();
            textBox_newpassword = new TextBox();
            button_signup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(78, 48);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(125, 27);
            textBox_firstname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // textBox_userlastname
            // 
            textBox_userlastname.Location = new Point(256, 48);
            textBox_userlastname.Name = "textBox_userlastname";
            textBox_userlastname.Size = new Size(125, 27);
            textBox_userlastname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 92);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // textBox_useremail
            // 
            textBox_useremail.Location = new Point(78, 130);
            textBox_useremail.Name = "textBox_useremail";
            textBox_useremail.Size = new Size(303, 27);
            textBox_useremail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 240);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 6;
            label4.Text = "Birthday";
            // 
            // comboBox_day
            // 
            comboBox_day.FormattingEnabled = true;
            comboBox_day.Location = new Point(78, 279);
            comboBox_day.Name = "comboBox_day";
            comboBox_day.Size = new Size(91, 28);
            comboBox_day.TabIndex = 5;
            comboBox_day.SelectedIndexChanged += comboBox_day_SelectedIndexChanged;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Location = new Point(175, 279);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(91, 28);
            comboBox_month.TabIndex = 6;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(290, 279);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(91, 28);
            comboBox_year.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 337);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 10;
            label5.Text = "Gender";
            // 
            // comboBox_gender
            // 
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Location = new Point(78, 375);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(91, 28);
            comboBox_gender.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 160);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 12;
            label6.Text = "New Password";
            // 
            // textBox_newpassword
            // 
            textBox_newpassword.Location = new Point(78, 198);
            textBox_newpassword.Name = "textBox_newpassword";
            textBox_newpassword.Size = new Size(125, 27);
            textBox_newpassword.TabIndex = 4;
            // 
            // button_signup
            // 
            button_signup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_signup.Location = new Point(256, 392);
            button_signup.Name = "button_signup";
            button_signup.Size = new Size(139, 57);
            button_signup.TabIndex = 9;
            button_signup.Text = "Sign Up";
            button_signup.UseVisualStyleBackColor = true;
            button_signup.Click += button_signup_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(button_signup);
            Controls.Add(textBox_newpassword);
            Controls.Add(label6);
            Controls.Add(comboBox_gender);
            Controls.Add(label5);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_day);
            Controls.Add(label4);
            Controls.Add(textBox_useremail);
            Controls.Add(label3);
            Controls.Add(textBox_userlastname);
            Controls.Add(label2);
            Controls.Add(textBox_firstname);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_firstname;
        private Label label2;
        private TextBox textBox_userlastname;
        private Label label3;
        private TextBox textBox_useremail;
        private Label label4;
        private ComboBox comboBox_day;
        private ComboBox comboBox_month;
        private ComboBox comboBox_year;
        private Label label5;
        private ComboBox comboBox_gender;
        private Label label6;
        private TextBox textBox_newpassword;
        private Button button_signup;
    }
}