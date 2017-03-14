namespace TelephoneDiary
{
    partial class Login
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
            this.lUsername = new MaterialSkin.Controls.MaterialLabel();
            this.btLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.tUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lPassword = new MaterialSkin.Controls.MaterialLabel();
            this.tPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Depth = 0;
            this.lUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lUsername.Location = new System.Drawing.Point(28, 107);
            this.lUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(88, 19);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "User Name:";
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = true;
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.Depth = 0;
            this.btLogin.Location = new System.Drawing.Point(220, 191);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.Primary = false;
            this.btLogin.Size = new System.Drawing.Size(52, 36);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // tUsername
            // 
            this.tUsername.Depth = 0;
            this.tUsername.Hint = "";
            this.tUsername.Location = new System.Drawing.Point(139, 107);
            this.tUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.tUsername.Name = "tUsername";
            this.tUsername.PasswordChar = '\0';
            this.tUsername.SelectedText = "";
            this.tUsername.SelectionLength = 0;
            this.tUsername.SelectionStart = 0;
            this.tUsername.Size = new System.Drawing.Size(227, 23);
            this.tUsername.TabIndex = 2;
            this.tUsername.UseSystemPasswordChar = false;
            this.tUsername.Click += new System.EventHandler(this.LoginType_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Depth = 0;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lPassword.Location = new System.Drawing.Point(28, 145);
            this.lPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(79, 18);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "Password:";
            // 
            // tPassword
            // 
            this.tPassword.Depth = 0;
            this.tPassword.Hint = "";
            this.tPassword.Location = new System.Drawing.Point(139, 145);
            this.tPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.SelectedText = "";
            this.tPassword.SelectionLength = 0;
            this.tPassword.SelectionStart = 0;
            this.tPassword.Size = new System.Drawing.Size(227, 23);
            this.tPassword.TabIndex = 2;
            this.tPassword.UseSystemPasswordChar = false;
            this.tPassword.Click += new System.EventHandler(this.LoginType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(372, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.KeyDown += Form_KeyDown;

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lUsername;
        private MaterialSkin.Controls.MaterialFlatButton btLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField tUsername;
        private MaterialSkin.Controls.MaterialLabel lPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}