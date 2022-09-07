
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace DatabaseBackup
{
    public partial class DatabaseBackup : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public DatabaseBackup()
        {
            InitializeComponent();
            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
         
        }
        
        private void DatabaseBackup_Load(object sender, EventArgs e)
        {
            BTN_StartBackup.Enabled = false;


            progressBar1.Minimum = 0;
            LBL_hidden_desination.Text = "";
            LBL_hidden_source.Text = "";

            LBL_message.Visible = false;


            TXT_DB_username.Text = "mohabs";
            TXT_DB_Password.Text = "mohabs123";


        }


        public void serverName(string str)
        {
            try
            {
                var username = TXT_DB_username.Text;
                var password = TXT_DB_Password.Text;
                string query = string.Format(@"Data Source=" + str + ";Database=Master;data source=.; uid='{0}'; pwd='{1}';", username, password);
                con = new SqlConnection(query);
                con.Open();
                cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    COM_servername.Items.Add(dr[2]);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("SQL username or password incorrect,Refresh and try again");

       
               
            }
           
        }
        public void Createconnection()
        {
            var username = TXT_DB_username.Text;
            var password = TXT_DB_Password.Text;
            string query2 = string.Format(@"Data Source=" + (COM_servername.Text) + ";Database=Master;data source=.; uid='{0}'; pwd='{1}'",username,password);

            //S_VVR 1234554321
            con = new SqlConnection(query2);
            con.Open();
            COM_databasename.Items.Clear();
            cmd = new SqlCommand("select * from sysdatabases", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                COM_databasename.Items.Add(dr[0]);
            }
            dr.Close();
        }
        public void query(string que)
        {
            // ERROR: Not supported in C#: OnErrorStatement
            cmd = new SqlCommand(que, con);

            cmd.ExecuteNonQuery();
        }
        public void blank(string str)
        {
            if (string.IsNullOrEmpty(COM_servername.Text) | string.IsNullOrEmpty(COM_databasename.Text))
            {
                // label3.Visible = true;
                MessageBox.Show("Server Name & Database can not be Blank");
                return;
            }
            else
            {
                if (str == "backup")
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                  string datetime=  DateTime.Now.ToString("BackUp_" + "MM_dd_yyyy_hh_mm_ss_tt");
                    dlg.FileName = COM_databasename.Text+ datetime;
                    dlg.ShowDialog();
                    string s = null;
                    s = dlg.FileName;
                    query("Backup database " + COM_databasename.Text + " to disk='" + s + "'");
                    LBL_message.Visible = true;
                    LBL_message.Text = "Database BackUp has been created successful";
                }
            }
        }

        private void BTN_backup_Click(object sender, EventArgs e)
        {
            LBL_message.Text = "";
            blank("backup");
        }

        private void COM_servername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Createconnection();

        }

        private void btn_backup_filesystem_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show("Please Select Backup Destination ");
            string sourcePath = @"E:\ArchiveSystem\Docs_FTP";
            LBL_hidden_source.Text = "";
            LBL_hidden_source.Text = sourcePath;

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.FileName = "Docs_FTP" + "_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss_tt");

            dlg.ShowDialog();
            string targetPath = null;
            targetPath = dlg.FileName;

            LBL_hidden_desination.Text = "";
            LBL_hidden_desination.Text = targetPath;

 
            int countFiles = System.IO.Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories).Count();
            BTN_StartBackup.Enabled = true;


            progressBar1.Maximum = countFiles;





        }

       
        

        private void BTN_StartBackup_Click(object sender, EventArgs e)
        {

            BTN_StartBackup.Enabled = false;

            backgroundWorker1.RunWorkerAsync();


        }

    
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //containt that u wanna copy of source folder must be inside folder before copy it 
            string sourcePath = LBL_hidden_source.Text;

            string targetPath = LBL_hidden_desination.Text;

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            int i = 0;
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {

                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                backgroundWorker1.ReportProgress(i);//send percentage to worker
                i++;
            }

            if (targetPath.Length == 0)
            {
                MessageBox.Show("Backup Faild");

            }

            else

            {
               
                MessageBox.Show("Backup succeed");

 
            }



        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //restart progress bar
            progressBar1.Value = 0;
 
        }

        private void btn_Select_HR_docs_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please Select Backup Destination ");
            string sourcePath = @"E:\Parsonal_Documents";
            LBL_hidden_source.Text = "";
            LBL_hidden_source.Text = sourcePath;

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.FileName = "Parsonal_Documents" + "_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss_tt");

            dlg.ShowDialog();
            string targetPath = null;
            targetPath = dlg.FileName;

            LBL_hidden_desination.Text = "";
            LBL_hidden_desination.Text = targetPath;


            int countFiles = System.IO.Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories).Count();
            BTN_StartBackup.Enabled = true;


            progressBar1.Maximum = countFiles;


        }
        public static string sourcePath = "";
        private void BTN_OFD_Click(object sender, EventArgs e)
        {
            //select Source 
            MessageBox.Show("Please Select Source Directory ");

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    sourcePath = fbd.SelectedPath;
                 }
            }
            
               
            LBL_hidden_source.Text = "";
            LBL_hidden_source.Text = sourcePath;

            //select distination 
            MessageBox.Show("Please Select Backup Destination Directory");
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.FileName = DateTime.Now.ToString("BackUp_"+"MM_dd_yyyy_hh_mm_ss_tt");

            dlg.ShowDialog();
            string targetPath = null;
            targetPath = dlg.FileName;

            LBL_hidden_desination.Text = "";
            LBL_hidden_desination.Text = targetPath;


            int countFiles = System.IO.Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories).Count();
            BTN_StartBackup.Enabled = true;


            progressBar1.Maximum = countFiles;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_DB_OK_Click(object sender, EventArgs e)
        {
            serverName(".");
            COM_servername.Enabled = true;
            COM_databasename.Enabled = true;
            BTN_backup.Enabled = true;
            TXT_DB_Password.Enabled = false;
            TXT_DB_username.Enabled = false;
            BTN_DB_OK.Enabled = false;
        }

        private void BTN_refresh_Click(object sender, EventArgs e)
        {
            COM_servername.Enabled = false;
            COM_databasename.Enabled = false;
            BTN_backup.Enabled = false;
            TXT_DB_Password.Enabled = true;
            TXT_DB_username.Enabled = true;
            BTN_DB_OK.Enabled = true;
            TXT_DB_Password.Clear();
            TXT_DB_username.Clear();
        }
    }
}