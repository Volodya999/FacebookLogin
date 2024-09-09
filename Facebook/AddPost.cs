using Facebook.BL;
using Facebook.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class Posts : Form
    {
        public string[] imgpath;
        public int userId; 
        public Posts()
        {
            InitializeComponent();
        }

        private void button_post_Click(object sender, EventArgs e)
        {
            NewPost np = new NewPost();
            int postid = 0;
            try
            {
                postid= np.AddPost(userId,textBox_title.Text, richTextBox_description.Text,DateTime.Now);
                np.InsertPostImages(userId, imgpath, postid);
                MessageBox.Show("Posted");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void button_uplode_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgpath = openFileDialog1.FileNames;
                Images img = new Images();
                MessageBox.Show("Uploaded");
            }
        }
    }
}
