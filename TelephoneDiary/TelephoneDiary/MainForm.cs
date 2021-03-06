﻿using System;
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
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        private Form login;

        public MainForm(Form pLogin)
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            login = pLogin;
            this.FormClosing += OnForm_Close;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "appData.Events". Sie können sie bei Bedarf verschieben oder entfernen.
            this.eventsTableAdapter.Fill(this.appData.Events);
            // TODO: This line of code loads data into the 'appData.PhoneBooks' table. You can move, or remove it, as needed.
            this.phoneBooksTableAdapter.Fill(this.appData.PhoneBooks);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txtPhoneNumber.Enabled = value;
            txtFullName.Enabled = value;
            txtEmail.Enabled = value;
            txtAddress.Enabled = value;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.PhoneBooks.AddPhoneBooksRow(appData.PhoneBooks.NewPhoneBooksRow());
                phoneBooksBindingSource.MoveLast();
                txtPhoneNumber.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.PhoneBooks.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtPhoneNumber.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            phoneBooksBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                phoneBooksBindingSource.EndEdit();
                phoneBooksTableAdapter.Update(appData.PhoneBooks);
                dataGridView.Refresh();
                txtPhoneNumber.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.PhoneBooks.RejectChanges();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    phoneBooksBindingSource.Filter = string.Format("PhoneNumber = '{0}' OR FullName LIKE '*{1}*' OR Email = '{2}' OR Address LIKE '*{3}*'", txtPhoneNumber.Text, txtFullName.Text, txtEmail.Text, txtAddress.Text);
                else
                    phoneBooksBindingSource.Filter = string.Empty;
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    phoneBooksBindingSource.RemoveCurrent();
            }
        }

        private void OnForm_Close(object sender, EventArgs e)
        {
            if(login != null)
                login.Close();
        }

        #region Event Handling
        private DateTime selectedDate = new DateTime(1, 1, 1);
        private bool newEntry = false;

        private void calender_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
        }
        private void AddEventBttn_Click(object sender, EventArgs e)
        {
            // Activates input fields
            Descriptiontxt.Enabled = true;
            Coachtxt.Enabled = true;
            cbHour.Enabled = true;
            cbMinutes.Enabled = true;
            newEntry = true;
            cbHour.SelectedIndex = 12;
            cbMinutes.SelectedIndex = 0;
            SaveEventBttn.Enabled = true;
        }

        private void DeleteEventBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eventsBindingSource.RemoveCurrent();
            }
        }

        private void SaveEventBttn_Click(object sender, EventArgs e)
        {
            //checking if a year has been selected first
            if (selectedDate.Year != 1 && newEntry == true)
            {
                calendar.AddBoldedDate(selectedDate);
                calendar.UpdateBoldedDates();
                newEntry = false;

                string time = cbHour.Text + ":" + cbMinutes.Text;


                int r = eventsTableAdapter.InsertEvent(time, Descriptiontxt.Text, Coachtxt.Text, selectedDate.ToString(), 0);
                if(r == 0)
                {
                    MessageBox.Show("Data could not be inserted, please check your intput or connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                eventsDataGrid.DataSource = null;
                eventsDataGrid.DataSource = eventsTableAdapter.GetData();
                // Input data into database
                // open and closing of object is handled through the using statement
                //string sql = "INSERT INTO Events (Date, Time, Description, Coach) VALUES (" + selectedDate + ", " + time + ", '" + Descriptiontxt.Text + "', '" + Coachtxt.Text + "' )";
                //string sql = "INSERT INTO Events (Date, Time, Description, Coach) VALUES (@date, @time, @description, @coach)";
                /*
                string sql = "INSERT INTO Events (Description, Coach) VALUES (@description, @coach)";
                using (conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand com = new SqlCommand(sql, conn))
                    {
                        try
                        {
                            //conn.Open();
                            //com.Parameters.Add("@date", SqlDbType.Date).Value = selectedDate;
                            //com.Parameters.Add("@time", SqlDbType.Time).Value = TimeSpan.Parse(time);
                            com.Parameters.Add("@description", SqlDbType.VarChar).Value = Descriptiontxt.Text;
                            com.Parameters.Add("@coach", SqlDbType.VarChar).Value = Coachtxt.Text;

                            conn.Open();
                            int result = com.ExecuteNonQuery();
                            if(result == 0)
                            {
                                result++;
                            }
                        }
                        catch (Exception sqlE)
                        {
                            Console.WriteLine(sqlE.Message);
                        }
                    }
                }
                */
                // TODO: Get this shit working. No new Data is shown....
                // refresh the data grid to show new data
               // eventsTableAdapter.Update(appData.Events);
                
                eventsDataGrid.Update();
                eventsDataGrid.Refresh();

                // Deactivates input fields and resets them
                Descriptiontxt.Enabled = false;
                Descriptiontxt.Text = "";
                Coachtxt.Enabled = false;
                Coachtxt.Text = "";
                cbHour.Enabled = false;
                cbHour.SelectedIndex = 12;
                cbMinutes.Enabled = false;
                cbMinutes.SelectedIndex = 0;
                SaveEventBttn.Enabled = false;
                }

        }
        #endregion
    }
}
