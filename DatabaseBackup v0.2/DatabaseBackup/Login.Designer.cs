namespace DatabaseBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TXT_username = new System.Windows.Forms.TextBox();
            this.TXT_password = new System.Windows.Forms.TextBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_username = new System.Windows.Forms.Label();
            this.LBL_password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_username
            // 
            this.TXT_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_username.Location = new System.Drawing.Point(12, 146);
            this.TXT_username.Multiline = true;
            this.TXT_username.Name = "TXT_username";
            this.TXT_username.Size = new System.Drawing.Size(290, 29);
            this.TXT_username.TabIndex = 0;
            // 
            // TXT_password
            // 
            this.TXT_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_password.Location = new System.Drawing.Point(12, 195);
            this.TXT_password.Multiline = true;
            this.TXT_password.Name = "TXT_password";
            this.TXT_password.Size = new System.Drawing.Size(290, 30);
            this.TXT_password.TabIndex = 1;
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_login.Location = new System.Drawing.Point(12, 242);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(290, 38);
            this.BTN_login.TabIndex = 2;
            this.BTN_login.Text = "Login";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            this.BTN_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTN_login_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_username
            // 
            this.LBL_username.AutoSize = true;
            this.LBL_username.Location = new System.Drawing.Point(12, 128);
            this.LBL_username.Name = "LBL_username";
            this.LBL_username.Size = new System.Drawing.Size(60, 15);
            this.LBL_username.TabIndex = 4;
            this.LBL_username.Text = "Username";
            // 
            // LBL_password
            // 
            this.LBL_password.AutoSize = true;
            this.LBL_password.Location = new System.Drawing.Point(12, 177);
            this.LBL_password.Name = "LBL_password";
            this.LBL_password.Size = new System.Drawing.Size(57, 15);
            this.LBL_password.TabIndex = 5;
            this.LBL_password.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "DataBase And File System Backup";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(311, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_password);
            this.Controls.Add(this.LBL_username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.TXT_password);
            this.Controls.Add(this.TXT_username);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXT_username;
        private TextBox TXT_password;
        private Button BTN_login;
        private PictureBox pictureBox1;
        private Label LBL_username;
        private Label LBL_password;
        private Label label4;
    }
}