using Facebook.BL;

namespace Facebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            NewUsers user = new NewUsers();
            int usercount;
            usercount = user.Login(textBox_useremail.Text, textBox_password.Text);
            if (usercount == 1)
            {
                NewFunctions nf = new NewFunctions();
                nf.useremail = textBox_useremail.Text;

                nf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Passsword");
            }

        }

        private void button_newaccount_Click(object sender, EventArgs e)
        {
            RegistrationForm rg = new RegistrationForm();
            rg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
