using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class fromLogin : Form
    {
        public fromLogin()
        {
            InitializeComponent();
        }

        private void fromLogin_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create an instance of Form1
            form1.Show(); // Show the main form
            this.Hide();  // Hide the login form instead of closing it
        }



        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += (sender, e) => Application.Exit();
        }
    }
}
