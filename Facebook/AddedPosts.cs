using Facebook.BL;
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
    public partial class AddedPosts : Form
    {
        public int Id { get; set; }
        public string cellValue;
        Posts posts = new Posts();
        public AddedPosts()
        {
            InitializeComponent();
        }

        private void AddedPosts_Load(object sender, EventArgs e)
        {
            NewPost newPost = new NewPost();
            DataTable dt = new DataTable();
            dt = newPost.GetPostInfo(Id);
            Id = Convert.ToInt32(dt.Rows[0][0].ToString());
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostPictures pp = new PostPictures();
            pp.PostId = Convert.ToInt32(cellValue);
            pp.ShowDialog();
        }

       
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }
    }
}
