namespace DatabaseBackup
{
    partial class DatabaseBackup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseBackup));
            this.LBL_servername = new System.Windows.Forms.Label();
            this.LBL_databasename = new System.Windows.Forms.Label();
            this.LBL_message = new System.Windows.Forms.Label();
            this.COM_servername = new System.Windows.Forms.ComboBox();
            this.COM_databasename = new System.Windows.Forms.ComboBox();
            this.BTN_backup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_hidden_desination = new System.Windows.Forms.Label();
            this.LBL_hidden_source = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_DB_OK = new System.Windows.Forms.Button();
            this.TXT_DB_Password = new System.Windows.Forms.TextBox();
            this.TXT_DB_username = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_backup_filesystem = new System.Windows.Forms.Button();
            this.BTN_StartBackup = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTN_OFD = new System.Windows.Forms.Button();
            this.btn_Select_HR_docs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_servername
            // 
            this.LBL_servername.AutoSize = true;
            this.LBL_servername.Location = new System.Drawing.Point(21, 191);
            this.LBL_servername.Name = "LBL_servername";
            this.LBL_servername.Size = new System.Drawing.Size(108, 15);
            this.LBL_servername.TabIndex = 0;
            this.LBL_servername.Text = "Select Server Name";
            // 
            // LBL_databasename
            // 
            this.LBL_databasename.AutoSize = true;
            this.LBL_databasename.Location = new System.Drawing.Point(21, 245);
            this.LBL_databasename.Name = "LBL_databasename";
            this.LBL_databasename.Size = new System.Drawing.Size(124, 15);
            this.LBL_databasename.TabIndex = 1;
            this.LBL_databasename.Text = "Select Database Name";
            // 
            // LBL_message
            // 
            this.LBL_message.AutoSize = true;
            this.LBL_message.Location = new System.Drawing.Point(122, 313);
            this.LBL_message.Name = "LBL_message";
            this.LBL_message.Size = new System.Drawing.Size(0, 15);
            this.LBL_message.TabIndex = 2;
            // 
            // COM_servername
            // 
            this.COM_servername.Enabled = false;
            this.COM_servername.FormattingEnabled = true;
            this.COM_servername.Location = new System.Drawing.Point(21, 209);
            this.COM_servername.Name = "COM_servername";
            this.COM_servername.Size = new System.Drawing.Size(277, 23);
            this.COM_servername.TabIndex = 3;
            this.COM_servername.SelectedIndexChanged += new System.EventHandler(this.COM_servername_SelectedIndexChanged);
            // 
            // COM_databasename
            // 
            this.COM_databasename.Enabled = false;
            this.COM_databasename.FormattingEnabled = true;
            this.COM_databasename.Location = new System.Drawing.Point(21, 263);
            this.COM_databasename.Name = "COM_databasename";
            this.COM_databasename.Size = new System.Drawing.Size(277, 23);
            this.COM_databasename.TabIndex = 4;
            // 
            // BTN_backup
            // 
            this.BTN_backup.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_backup.Enabled = false;
            this.BTN_backup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_backup.Location = new System.Drawing.Point(21, 290);
            this.BTN_backup.Name = "BTN_backup";
            this.BTN_backup.Size = new System.Drawing.Size(95, 38);
            this.BTN_backup.TabIndex = 5;
            this.BTN_backup.Text = "Start Backup";
            this.BTN_backup.UseVisualStyleBackColor = false;
            this.BTN_backup.Click += new System.EventHandler(this.BTN_backup_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 16);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(790, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 424);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 424);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.LBL_hidden_desination);
            this.panel5.Controls.Add(this.LBL_hidden_source);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(780, 50);
            this.panel5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBase And File System Backup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_hidden_desination
            // 
            this.LBL_hidden_desination.AutoSize = true;
            this.LBL_hidden_desination.Location = new System.Drawing.Point(486, 3);
            this.LBL_hidden_desination.Name = "LBL_hidden_desination";
            this.LBL_hidden_desination.Size = new System.Drawing.Size(38, 15);
            this.LBL_hidden_desination.TabIndex = 14;
            this.LBL_hidden_desination.Text = "label3";
            this.LBL_hidden_desination.Visible = false;
            // 
            // LBL_hidden_source
            // 
            this.LBL_hidden_source.AutoSize = true;
            this.LBL_hidden_source.Location = new System.Drawing.Point(442, 3);
            this.LBL_hidden_source.Name = "LBL_hidden_source";
            this.LBL_hidden_source.Size = new System.Drawing.Size(38, 15);
            this.LBL_hidden_source.TabIndex = 13;
            this.LBL_hidden_source.Text = "label2";
            this.LBL_hidden_source.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.LBL_servername);
            this.panel8.Controls.Add(this.LBL_databasename);
            this.panel8.Controls.Add(this.LBL_message);
            this.panel8.Controls.Add(this.COM_servername);
            this.panel8.Controls.Add(this.COM_databasename);
            this.panel8.Controls.Add(this.BTN_backup);
            this.panel8.Location = new System.Drawing.Point(10, 60);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(382, 335);
            this.panel8.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_refresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_DB_OK);
            this.groupBox1.Controls.Add(this.TXT_DB_Password);
            this.groupBox1.Controls.Add(this.TXT_DB_username);
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local SQL Authontication";
            // 
            // BTN_refresh
            // 
            this.BTN_refresh.Location = new System.Drawing.Point(270, 93);
            this.BTN_refresh.Name = "BTN_refresh";
            this.BTN_refresh.Size = new System.Drawing.Size(75, 23);
            this.BTN_refresh.TabIndex = 5;
            this.BTN_refresh.Text = "Refresh";
            this.BTN_refresh.UseVisualStyleBackColor = true;
            this.BTN_refresh.Click += new System.EventHandler(this.BTN_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Instance Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instance Username";
            // 
            // BTN_DB_OK
            // 
            this.BTN_DB_OK.Location = new System.Drawing.Point(216, 93);
            this.BTN_DB_OK.Name = "BTN_DB_OK";
            this.BTN_DB_OK.Size = new System.Drawing.Size(52, 23);
            this.BTN_DB_OK.TabIndex = 2;
            this.BTN_DB_OK.Text = "ok";
            this.BTN_DB_OK.UseVisualStyleBackColor = true;
            this.BTN_DB_OK.Click += new System.EventHandler(this.BTN_DB_OK_Click);
            // 
            // TXT_DB_Password
            // 
            this.TXT_DB_Password.Location = new System.Drawing.Point(6, 93);
            this.TXT_DB_Password.Name = "TXT_DB_Password";
            this.TXT_DB_Password.Size = new System.Drawing.Size(197, 23);
            this.TXT_DB_Password.TabIndex = 1;
            // 
            // TXT_DB_username
            // 
            this.TXT_DB_username.Location = new System.Drawing.Point(6, 40);
            this.TXT_DB_username.Name = "TXT_DB_username";
            this.TXT_DB_username.Size = new System.Drawing.Size(197, 23);
            this.TXT_DB_username.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(382, 50);
            this.panel9.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(101, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "DataBase Backup";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(10, 401);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(780, 33);
            this.panel10.TabIndex = 18;
            // 
            // btn_backup_filesystem
            // 
            this.btn_backup_filesystem.Location = new System.Drawing.Point(14, 59);
            this.btn_backup_filesystem.Name = "btn_backup_filesystem";
            this.btn_backup_filesystem.Size = new System.Drawing.Size(361, 38);
            this.btn_backup_filesystem.TabIndex = 11;
            this.btn_backup_filesystem.Text = "Archive (File System)";
            this.btn_backup_filesystem.UseVisualStyleBackColor = true;
            this.btn_backup_filesystem.Click += new System.EventHandler(this.btn_backup_filesystem_Click);
            // 
            // BTN_StartBackup
            // 
            this.BTN_StartBackup.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_StartBackup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_StartBackup.Location = new System.Drawing.Point(281, 260);
            this.BTN_StartBackup.Name = "BTN_StartBackup";
            this.BTN_StartBackup.Size = new System.Drawing.Size(107, 39);
            this.BTN_StartBackup.TabIndex = 15;
            this.BTN_StartBackup.Text = "Start Backup";
            this.BTN_StartBackup.UseVisualStyleBackColor = false;
            this.BTN_StartBackup.Click += new System.EventHandler(this.BTN_StartBackup_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 50);
            this.panel7.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(121, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "File System Backup";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.BTN_OFD);
            this.panel6.Controls.Add(this.btn_Select_HR_docs);
            this.panel6.Controls.Add(this.progressBar1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.BTN_StartBackup);
            this.panel6.Controls.Add(this.btn_backup_filesystem);
            this.panel6.Location = new System.Drawing.Point(398, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 335);
            this.panel6.TabIndex = 16;
            // 
            // BTN_OFD
            // 
            this.BTN_OFD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_OFD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_OFD.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_OFD.Location = new System.Drawing.Point(281, 215);
            this.BTN_OFD.Name = "BTN_OFD";
            this.BTN_OFD.Size = new System.Drawing.Size(107, 39);
            this.BTN_OFD.TabIndex = 19;
            this.BTN_OFD.Text = "Open File Dialog";
            this.BTN_OFD.UseVisualStyleBackColor = false;
            this.BTN_OFD.Click += new System.EventHandler(this.BTN_OFD_Click);
            // 
            // btn_Select_HR_docs
            // 
            this.btn_Select_HR_docs.Location = new System.Drawing.Point(14, 110);
            this.btn_Select_HR_docs.Name = "btn_Select_HR_docs";
            this.btn_Select_HR_docs.Size = new System.Drawing.Size(361, 38);
            this.btn_Select_HR_docs.TabIndex = 18;
            this.btn_Select_HR_docs.Text = "HR Documents (File System)";
            this.btn_Select_HR_docs.UseVisualStyleBackColor = true;
            this.btn_Select_HR_docs.Click += new System.EventHandler(this.btn_Select_HR_docs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.BlueViolet;
            this.progressBar1.ForeColor = System.Drawing.Color.Orchid;
            this.progressBar1.Location = new System.Drawing.Point(6, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // DatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "DatabaseBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseBackup";
            this.Load += new System.EventHandler(this.DatabaseBackup_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LBL_servername;
        private Label LBL_databasename;
        private Label LBL_message;
        private ComboBox COM_servername;
        private ComboBox COM_databasename;
        private Button BTN_backup;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label LBL_hidden_source;
        private Label LBL_hidden_desination;
        private Panel panel8;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private Button btn_backup_filesystem;
        private Button BTN_StartBackup;
        private Panel panel7;
        private Label label2;
        private Panel panel6;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_Select_HR_docs;
        private Button BTN_OFD;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Button BTN_DB_OK;
        private TextBox TXT_DB_Password;
        private TextBox TXT_DB_username;
        private Button BTN_refresh;
    }
}