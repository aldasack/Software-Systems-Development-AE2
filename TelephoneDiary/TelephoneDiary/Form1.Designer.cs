using System;

namespace TelephoneDiary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phoneBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new TelephoneDiary.AppData();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteEventBttn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddEventBttn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.SaveEventBttn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Coachtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Descriptiontxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lCoach = new MaterialSkin.Controls.MaterialLabel();
            this.lTime = new MaterialSkin.Controls.MaterialLabel();
            this.lDescription = new MaterialSkin.Controls.MaterialLabel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.phoneBooksTableAdapter = new TelephoneDiary.AppDataTableAdapters.PhoneBooksTableAdapter();
            this.eventsTableAdapter = new TelephoneDiary.AppDataTableAdapters.EventsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Hint = "";
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 12);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(183, 23);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // phoneBooksBindingSource
            // 
            this.phoneBooksBindingSource.DataMember = "PhoneBooks";
            this.phoneBooksBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Full name:";
            // 
            // txtFullName
            // 
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "FullName", true));
            this.txtFullName.Depth = 0;
            this.txtFullName.Hint = "";
            this.txtFullName.Location = new System.Drawing.Point(120, 41);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.Size = new System.Drawing.Size(183, 23);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 72);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Email", true));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(120, 70);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(355, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 101);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Address", true));
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(120, 99);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(355, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 130);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(120, 128);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(565, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(639, 352);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.phoneBooksBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(10, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(675, 186);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(567, 352);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(518, 352);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(41, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Depth = 0;
            this.btnNew.Location = new System.Drawing.Point(469, 352);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.Primary = false;
            this.btnNew.Size = new System.Drawing.Size(42, 36);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 96);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1014, 526);
            this.materialTabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.txtPhoneNumber);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.txtFullName);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.eventsDataGrid);
            this.tabPage2.Controls.Add(this.DeleteEventBttn);
            this.tabPage2.Controls.Add(this.AddEventBttn);
            this.tabPage2.Controls.Add(this.cbMinutes);
            this.tabPage2.Controls.Add(this.cbHour);
            this.tabPage2.Controls.Add(this.SaveEventBttn);
            this.tabPage2.Controls.Add(this.Coachtxt);
            this.tabPage2.Controls.Add(this.Descriptiontxt);
            this.tabPage2.Controls.Add(this.lCoach);
            this.tabPage2.Controls.Add(this.lTime);
            this.tabPage2.Controls.Add(this.lDescription);
            this.tabPage2.Controls.Add(this.calendar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.AllowUserToAddRows = false;
            this.eventsDataGrid.AllowUserToDeleteRows = false;
            this.eventsDataGrid.AllowUserToOrderColumns = true;
            this.eventsDataGrid.AutoGenerateColumns = false;
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.coachDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.eventsDataGrid.DataSource = this.eventsBindingSource;
            this.eventsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.eventsDataGrid.Location = new System.Drawing.Point(282, 38);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.Size = new System.Drawing.Size(718, 459);
            this.eventsDataGrid.TabIndex = 13;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // coachDataGridViewTextBoxColumn
            // 
            this.coachDataGridViewTextBoxColumn.DataPropertyName = "Coach";
            this.coachDataGridViewTextBoxColumn.HeaderText = "Coach";
            this.coachDataGridViewTextBoxColumn.Name = "coachDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.appDataBindingSource;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // DeleteEventBttn
            // 
            this.DeleteEventBttn.Depth = 0;
            this.DeleteEventBttn.Location = new System.Drawing.Point(925, 6);
            this.DeleteEventBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteEventBttn.Name = "DeleteEventBttn";
            this.DeleteEventBttn.Primary = true;
            this.DeleteEventBttn.Size = new System.Drawing.Size(75, 23);
            this.DeleteEventBttn.TabIndex = 12;
            this.DeleteEventBttn.Text = "-";
            this.DeleteEventBttn.UseVisualStyleBackColor = true;
            this.DeleteEventBttn.Click += new System.EventHandler(this.DeleteEventBttn_Click);
            // 
            // AddEventBttn
            // 
            this.AddEventBttn.Depth = 0;
            this.AddEventBttn.Location = new System.Drawing.Point(282, 5);
            this.AddEventBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEventBttn.Name = "AddEventBttn";
            this.AddEventBttn.Primary = true;
            this.AddEventBttn.Size = new System.Drawing.Size(75, 23);
            this.AddEventBttn.TabIndex = 11;
            this.AddEventBttn.Text = "+";
            this.AddEventBttn.UseVisualStyleBackColor = true;
            this.AddEventBttn.Click += new System.EventHandler(this.AddEventBttn_Click);
            // 
            // cbMinutes
            // 
            this.cbMinutes.Enabled = false;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cbMinutes.Location = new System.Drawing.Point(202, 246);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(51, 21);
            this.cbMinutes.TabIndex = 8;
            // 
            // cbHour
            // 
            this.cbHour.Enabled = false;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cbHour.Location = new System.Drawing.Point(129, 246);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(50, 21);
            this.cbHour.TabIndex = 7;
            // 
            // SaveEventBttn
            // 
            this.SaveEventBttn.AutoSize = true;
            this.SaveEventBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveEventBttn.Depth = 0;
            this.SaveEventBttn.Enabled = false;
            this.SaveEventBttn.Location = new System.Drawing.Point(76, 326);
            this.SaveEventBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveEventBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveEventBttn.Name = "SaveEventBttn";
            this.SaveEventBttn.Primary = false;
            this.SaveEventBttn.Size = new System.Drawing.Size(92, 36);
            this.SaveEventBttn.TabIndex = 6;
            this.SaveEventBttn.Text = "Save Event";
            this.SaveEventBttn.UseVisualStyleBackColor = true;
            this.SaveEventBttn.Click += new System.EventHandler(this.SaveEventBttn_Click);
            // 
            // Coachtxt
            // 
            this.Coachtxt.Depth = 0;
            this.Coachtxt.Enabled = false;
            this.Coachtxt.Hint = "";
            this.Coachtxt.Location = new System.Drawing.Point(129, 273);
            this.Coachtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Coachtxt.Name = "Coachtxt";
            this.Coachtxt.PasswordChar = '\0';
            this.Coachtxt.SelectedText = "";
            this.Coachtxt.SelectionLength = 0;
            this.Coachtxt.SelectionStart = 0;
            this.Coachtxt.Size = new System.Drawing.Size(124, 23);
            this.Coachtxt.TabIndex = 5;
            this.Coachtxt.UseSystemPasswordChar = false;
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Depth = 0;
            this.Descriptiontxt.Enabled = false;
            this.Descriptiontxt.Hint = "";
            this.Descriptiontxt.Location = new System.Drawing.Point(129, 196);
            this.Descriptiontxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.PasswordChar = '\0';
            this.Descriptiontxt.SelectedText = "";
            this.Descriptiontxt.SelectionLength = 0;
            this.Descriptiontxt.SelectionStart = 0;
            this.Descriptiontxt.Size = new System.Drawing.Size(124, 23);
            this.Descriptiontxt.TabIndex = 4;
            this.Descriptiontxt.UseSystemPasswordChar = false;
            // 
            // lCoach
            // 
            this.lCoach.AutoSize = true;
            this.lCoach.Depth = 0;
            this.lCoach.Font = new System.Drawing.Font("Roboto", 11F);
            this.lCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lCoach.Location = new System.Drawing.Point(8, 273);
            this.lCoach.MouseState = MaterialSkin.MouseState.HOVER;
            this.lCoach.Name = "lCoach";
            this.lCoach.Size = new System.Drawing.Size(52, 19);
            this.lCoach.TabIndex = 3;
            this.lCoach.Text = "Coach";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Depth = 0;
            this.lTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lTime.Location = new System.Drawing.Point(8, 236);
            this.lTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(43, 19);
            this.lTime.TabIndex = 2;
            this.lTime.Text = "Time";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Depth = 0;
            this.lDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lDescription.Location = new System.Drawing.Point(9, 201);
            this.lDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(86, 19);
            this.lDescription.TabIndex = 1;
            this.lDescription.Text = "Description";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(12, 12);
            this.calendar.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.ShowWeekNumbers = true;
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += this.calender_DateSelected;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1039, 26);
            this.materialTabSelector1.TabIndex = 10;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // phoneBooksTableAdapter
            // 
            this.phoneBooksTableAdapter.ClearBeforeFill = true;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 801);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Diary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void btSaveEvent_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFullName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnNew;
        private AppData appData;
        private System.Windows.Forms.BindingSource phoneBooksBindingSource;
        private AppDataTableAdapters.PhoneBooksTableAdapter phoneBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.MonthCalendar calendar;
        private MaterialSkin.Controls.MaterialLabel lDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField Descriptiontxt;
        private MaterialSkin.Controls.MaterialLabel lCoach;
        private MaterialSkin.Controls.MaterialLabel lTime;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteEventBttn;
        private MaterialSkin.Controls.MaterialRaisedButton AddEventBttn;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbHour;
        private MaterialSkin.Controls.MaterialFlatButton SaveEventBttn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Coachtxt;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private AppDataTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

