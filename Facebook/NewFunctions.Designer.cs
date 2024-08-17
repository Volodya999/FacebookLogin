namespace Facebook
{
    partial class NewFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFunctions));
            label_name = new Label();
            label_lastname = new Label();
            label_email = new Label();
            pictureBox1 = new PictureBox();
            FirstName_textBox = new TextBox();
            LastName_textBox = new TextBox();
            Email_textBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            Upload_button = new Button();
            showimage_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(45, 57);
            label_name.Name = "label_name";
            label_name.Size = new Size(80, 20);
            label_name.TabIndex = 1;
            label_name.Text = "First Name";
            // 
            // label_lastname
            // 
            label_lastname.AutoSize = true;
            label_lastname.Location = new Point(230, 57);
            label_lastname.Name = "label_lastname";
            label_lastname.Size = new Size(79, 20);
            label_lastname.TabIndex = 2;
            label_lastname.Text = "Last Name";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(438, 57);
            label_email.Name = "label_email";
            label_email.Size = new Size(46, 20);
            label_email.TabIndex = 3;
            label_email.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FirstName_textBox
            // 
            FirstName_textBox.Location = new Point(28, 100);
            FirstName_textBox.Name = "FirstName_textBox";
            FirstName_textBox.ReadOnly = true;
            FirstName_textBox.Size = new Size(125, 27);
            FirstName_textBox.TabIndex = 4;
            // 
            // LastName_textBox
            // 
            LastName_textBox.Location = new Point(209, 100);
            LastName_textBox.Name = "LastName_textBox";
            LastName_textBox.ReadOnly = true;
            LastName_textBox.Size = new Size(125, 27);
            LastName_textBox.TabIndex = 5;
            // 
            // Email_textBox
            // 
            Email_textBox.Location = new Point(397, 100);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.ReadOnly = true;
            Email_textBox.Size = new Size(125, 27);
            Email_textBox.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Upload_button
            // 
            Upload_button.Location = new Point(626, 327);
            Upload_button.Name = "Upload_button";
            Upload_button.Size = new Size(138, 58);
            Upload_button.TabIndex = 7;
            Upload_button.Text = "Upload";
            Upload_button.UseVisualStyleBackColor = true;
            Upload_button.Click += Upload_button_Click;
            // 
            // showimage_button
            // 
            showimage_button.Location = new Point(649, 154);
            showimage_button.Name = "showimage_button";
            showimage_button.Size = new Size(115, 43);
            showimage_button.TabIndex = 8;
            showimage_button.Text = "ShowImage";
            showimage_button.UseVisualStyleBackColor = true;
            showimage_button.Click += showimage_button_Click;
            // 
            // NewFunctions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showimage_button);
            Controls.Add(Upload_button);
            Controls.Add(Email_textBox);
            Controls.Add(LastName_textBox);
            Controls.Add(FirstName_textBox);
            Controls.Add(pictureBox1);
            Controls.Add(label_email);
            Controls.Add(label_lastname);
            Controls.Add(label_name);
            Name = "NewFunctions";
            Text = "NewFunctions";
            Load += NewFunctions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private Label label_lastname;
        private Label label_email;
        private PictureBox pictureBox1;
        private TextBox FirstName_textBox;
        private TextBox LastName_textBox;
        private TextBox Email_textBox;
        private OpenFileDialog openFileDialog1;
        private Button Upload_button;
        private Button showimage_button;
    }
}