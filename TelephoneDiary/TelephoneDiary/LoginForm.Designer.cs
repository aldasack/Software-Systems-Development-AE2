namespace TelephoneDiary
{
    partial class LoginForm
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
            this.Loginbttn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Usertxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Passtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appData = new TelephoneDiary.AppData();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new TelephoneDiary.AppDataTableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbttn
            // 
            this.Loginbttn.AutoSize = true;
            this.Loginbttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Loginbttn.Depth = 0;
            this.Loginbttn.Location = new System.Drawing.Point(249, 190);
            this.Loginbttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Loginbttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Loginbttn.Name = "Loginbttn";
            this.Loginbttn.Primary = false;
            this.Loginbttn.Size = new System.Drawing.Size(52, 36);
            this.Loginbttn.TabIndex = 0;
            this.Loginbttn.Text = "Login";
            this.Loginbttn.UseVisualStyleBackColor = true;
            this.Loginbttn.Click += new System.EventHandler(this.Loginbttn_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.Depth = 0;
            this.Usertxt.Hint = "";
            this.Usertxt.Location = new System.Drawing.Point(163, 112);
            this.Usertxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.PasswordChar = '\0';
            this.Usertxt.SelectedText = "";
            this.Usertxt.SelectionLength = 0;
            this.Usertxt.SelectionStart = 0;
            this.Usertxt.Size = new System.Drawing.Size(235, 23);
            this.Usertxt.TabIndex = 1;
            this.Usertxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "UserName:";
            // 
            // Passtxt
            // 
            this.Passtxt.Depth = 0;
            this.Passtxt.Hint = "";
            this.Passtxt.Location = new System.Drawing.Point(163, 149);
            this.Passtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.SelectedText = "";
            this.Passtxt.SelectionLength = 0;
            this.Passtxt.SelectionStart = 0;
            this.Passtxt.Size = new System.Drawing.Size(235, 23);
            this.Passtxt.TabIndex = 3;
            this.Passtxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(66, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 163);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.appData;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.appData;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Loginbttn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Loginbttn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Usertxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Passtxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppData appData;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AppDataTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
    }
}