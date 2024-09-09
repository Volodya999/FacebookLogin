namespace Facebook
{
    partial class Posts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posts));
            richTextBox_description = new RichTextBox();
            pictureBox1 = new PictureBox();
            button_post = new Button();
            textBox_title = new TextBox();
            label_title = new Label();
            label_description = new Label();
            label_pictures = new Label();
            label_datetime = new Label();
            button_uplode = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox_description
            // 
            richTextBox_description.Location = new Point(320, 125);
            richTextBox_description.Name = "richTextBox_description";
            richTextBox_description.Size = new Size(405, 64);
            richTextBox_description.TabIndex = 2;
            richTextBox_description.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button_post
            // 
            button_post.Location = new Point(959, 457);
            button_post.Name = "button_post";
            button_post.Size = new Size(94, 29);
            button_post.TabIndex = 4;
            button_post.Text = "Post";
            button_post.UseVisualStyleBackColor = true;
            button_post.Click += button_post_Click;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(320, 50);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(125, 27);
            textBox_title.TabIndex = 1;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new Point(320, 27);
            label_title.Name = "label_title";
            label_title.Size = new Size(38, 20);
            label_title.TabIndex = 4;
            label_title.Text = "Title";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(320, 93);
            label_description.Name = "label_description";
            label_description.Size = new Size(85, 20);
            label_description.TabIndex = 5;
            label_description.Text = "Description";
            // 
            // label_pictures
            // 
            label_pictures.AutoSize = true;
            label_pictures.Location = new Point(320, 206);
            label_pictures.Name = "label_pictures";
            label_pictures.Size = new Size(60, 20);
            label_pictures.TabIndex = 6;
            label_pictures.Text = "Pitcures";
            // 
            // label_datetime
            // 
            label_datetime.AutoSize = true;
            label_datetime.Location = new Point(584, 449);
            label_datetime.Name = "label_datetime";
            label_datetime.Size = new Size(74, 20);
            label_datetime.TabIndex = 8;
            label_datetime.Text = "DateTime";
            // 
            // button_uplode
            // 
            button_uplode.Location = new Point(399, 445);
            button_uplode.Name = "button_uplode";
            button_uplode.Size = new Size(94, 29);
            button_uplode.TabIndex = 3;
            button_uplode.Text = "Uplode";
            button_uplode.UseVisualStyleBackColor = true;
            button_uplode.Click += button_uplode_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Posts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 578);
            Controls.Add(button_uplode);
            Controls.Add(label_datetime);
            Controls.Add(label_pictures);
            Controls.Add(label_description);
            Controls.Add(label_title);
            Controls.Add(textBox_title);
            Controls.Add(button_post);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox_description);
            Name = "Posts";
            Text = "Posts";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_description;
        private PictureBox pictureBox1;
        private Button button_post;
        private TextBox textBox_title;
        private Label label_title;
        private Label label_description;
        private Label label_pictures;
        private Label label_datetime;
        private Button button_uplode;
        private OpenFileDialog openFileDialog1;
    }
}