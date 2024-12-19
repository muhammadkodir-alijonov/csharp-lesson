using System.Drawing.Text;
using winform_example_app.Forms;

namespace winform_example_app
{
    public partial class LogInForm : Form
    {
        private const string _login = "admin";
        private const string _password = "123";
        public LogInForm()
        {
            InitializeComponent();
        }
        private void btmLogIn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            if (email == _login && password == _password)
            {
                tbMessage.Text = "Successful!";
                tbMessage.ForeColor = Color.Green;
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                tbMessage.Text = "Login or password is incorrect!";
                tbMessage.ForeColor = Color.Red;
                tbEmail.Text = tbPassword.Text = "";
            }
        }
    }
}