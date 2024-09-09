using Facebook.BL;
using Facebook.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class PostPictures : Form
    {
        public int PostId { get; set; }
        Posts p = new Posts();
        public PostPictures()
        {
            InitializeComponent();
        }

        private void PostPictures_Load(object sender, EventArgs e)
        {
            NewPost np =  new NewPost();
            DataTable dataTable = new DataTable();
            dataTable= np.GetPostImages(PostId);
          
            int x = 170;
            int y = 72;
            int heigt = 65;
            int width = 22;
            int i = 1;
            foreach (DataRow row in dataTable.Rows) 
            {
                string imgpath = row["postimgpath"].ToString();
                PictureBox p = new PictureBox
                {
                    ImageLocation = imgpath,
                    Dock = DockStyle.Fill,
                    Location = new Point(x, y),
                    Padding = new Padding(50),
                    Name = "picture" + i,
                   // Size = new Size(heigt, width)
                };

                //PictureBox pb = new PictureBox();
                //pb.Name = "picture" + x;
                //pb.Dock = DockStyle.Fill;
                //pb.Location = new Point(x, y);
                //pb.Size = new Size(heigt, width);
                //pb.ImageLocation = imgpath;
                this.Controls.Add(p);
                x = x + 150;
                i = i + 1;
               // y = y + 250;
            }

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    pb.Image = dataTable.Rows[0].;
            //}
        }
    }
}
