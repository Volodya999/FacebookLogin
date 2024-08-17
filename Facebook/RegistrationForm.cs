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
    public partial class RegistrationForm : Form
    {
        NewUsers nu = new NewUsers();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            try
            {
                NewUsers user = new NewUsers();
                int usercount;
                usercount = user.Login(textBox_useremail.Text, textBox_newpassword.Text);
                if (usercount > 0)
                {
                    MessageBox.Show("Invalid credentials");
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something Error");
            }

            try
            {
                
                
                
                nu.NewUsersAccount(textBox_firstname.Text, textBox_userlastname.Text, textBox_useremail.Text, textBox_newpassword.Text, Convert.ToInt32(comboBox_day.SelectedValue), Convert.ToInt32(comboBox_month.SelectedValue), Convert.ToInt32(comboBox_year.SelectedValue), Convert.ToInt32(comboBox_gender.SelectedValue));
                MessageBox.Show("created");
                textBox_firstname.Clear();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nu.GetBirthDay("GetBirthDay");
            comboBox_day.DataSource = dt;
            comboBox_day.DisplayMember = "Name";
            comboBox_day.ValueMember = "Id";
            dt = nu.GetBirthMonth("GetBirthMonth");
            comboBox_month.DataSource = dt;
            comboBox_month.DisplayMember = "Name";
            comboBox_month.ValueMember = "Id";
            dt = nu.GetBirthYear("GetBirthYear");
            comboBox_year.DataSource = dt;
            comboBox_year.DisplayMember = "Name";
            comboBox_year.ValueMember = "Id";
            dt = nu.GetGender("GetGender");
            comboBox_gender.DataSource = dt;
            comboBox_gender.DisplayMember = "Name";
            comboBox_gender.ValueMember = "Id";
        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
