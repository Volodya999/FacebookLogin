using Facebook.BL;
using Facebook.DAL;
using Microsoft.VisualBasic.ApplicationServices;
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

    public partial class NewFunctions : Form
    {
       
        public int Id {  get; set; }
        public string useremail { get; set; }
        
        public NewFunctions()
        {
            InitializeComponent();
        }

        private void NewFunctions_Load(object sender, EventArgs e)
        {
            NewUsers newUsers = new NewUsers();
            DataTable dt =  new DataTable();
            dt= newUsers.GetUserInfo(useremail);
            FirstName_textBox.Text = dt.Rows[0][1].ToString();
            LastName_textBox.Text= dt.Rows[0][2].ToString();
            Email_textBox.Text = useremail;
            Id = Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        private void Upload_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Images images = new Images();
                images.InsertImages(Id,path);
                MessageBox.Show("Uploaded");
            }
            

        }

        private void showimage_button_Click(object sender, EventArgs e)
        {
            try
            {
                Images img = new Images();
                string imgpath = img.GetUserImages(Id);
                pictureBox1.Image = Image.FromFile(imgpath);
            }
            catch (Exception)
            {

                MessageBox.Show("Unkonwn Error");
            }
            
        }
    }
}
