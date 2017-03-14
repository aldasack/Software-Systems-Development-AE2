using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace TelephoneDiary
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {

        private string username = "admin";
        private string password = "admin";

        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"../../Assets/bigwill.png");     //Why is this local, needs to be accessible by everyone 
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            btLogin.Focus();
        }

        private void LoginType_Click(object sender, EventArgs e)
        {

        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if(tUsername.Text == username && tPassword.Text == password)
            {
                Form1 f = new Form1(this);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or Username is incorrect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tPassword.Text = "";
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
