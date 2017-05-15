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

using System.Configuration;
using System.Data.SqlClient;

namespace TelephoneDiary
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        private string connectionString = "";
        private SqlConnection conn;

        public LoginForm()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            connectionString = ConfigurationManager.ConnectionStrings["TelephoneDiary.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Users' table. You can move, or remove it, as needed.
            // Dunno if needed /Alex
            //this.usersTableAdapter.Fill(this.appData.Users);

            
        }

        private void Loginbttn_Click(object sender, EventArgs e)
        {
            // Getting user input
            string userName = Usertxt.Text;
            string password = Passtxt.Text;
       

            // open and closing of object is handled through the using statement
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users WHERE Username ='" + userName + "'", conn))
            {
                //conn.Open();

                DataTable personTable = new DataTable();
                adapter.Fill(personTable);
                if(personTable.Rows.Count == 1)
                {
                    Form f = new MainForm(this);
                    f.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password or Username is incorrect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Passtxt.Text = "";
                }


                //ListPerson.DisplayMember = "Name";
                //ListPerson.ValueMember = "Id";
                //ListPerson.DataSource = personTable;
            }
        }
    }
}
