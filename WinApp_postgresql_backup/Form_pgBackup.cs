using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp_postgresql_backup.Properties;
using WinApp_postgresql_backup.utility;


namespace WinApp_postgresql_backup
{
    public partial class Form_pgBackup : Form
    {
        public Form_pgBackup()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox_db_pass.PasswordChar = '*';

            checkBox_showpass.CheckedChanged += CheckBox_showpass_CheckedChanged;

            button_load.Click += Button_load_Click;
            button_save.Click += Button_save_Click;

            button_pg_bin.Click += Button_pg_bin_Click;
            button_dumpDir.Click += Button_dumpDir_Click;
            button_restoreFile.Click += Button_restoreFile_Click;

            textBox_dbPath.AllowDrop = true;
            textBox_dbPath.DragDrop += TextBox_Path_DragDrop;
            textBox_dbPath.DragEnter += TextBox_Path_DragEnter;

            textBox_dumpPath.AllowDrop = true;
            textBox_dumpPath.DragDrop += TextBox_Path_DragDrop;
            textBox_dumpPath.DragEnter += TextBox_Path_DragEnter;

            textBox_restorePath.AllowDrop = true;
            textBox_restorePath.DragDrop += TextBox_Path_DragDrop;
            textBox_restorePath.DragEnter += TextBox_Path_DragEnter;

            button_passfile.Click += Button_passfile_Click;
            button_open_passfile_folder.Click += Button_open_passfile_folder_Click;

        }

        private void Button_passfile_Click(object sender, EventArgs e)
        {

            PostgresParam param = new PostgresParam();

            param.Host = textBox_db_host.Text;
            param.Port = textBox_db_port.Text;
            param.DatabaseName = textBox_db_name.Text;
            param.User = textBox_db_user.Text;
            param.Pass = textBox_db_pass.Text;

            PostgreSQLCmdGen.CreatePassFile(param);

        }

        private void Button_open_passfile_folder_Click(object sender, EventArgs e)
        {
            string path = "";
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "postgresql");

            System.Diagnostics.Process.Start(path);

        }

        private void CheckBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                textBox_db_pass.PasswordChar = '\0';
            }
            else
            {
                textBox_db_pass.PasswordChar = '*';
            }
        }

        private void TextBox_Path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TextBox_Path_DragDrop(object sender, DragEventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtbox.Text = path[0];

        }


        private void Button_pg_bin_Click(object sender, EventArgs e)
        {
            string path = GetDirPath();

            if (!string.IsNullOrEmpty(path))
            {
                textBox_dbPath.Text = path;
            }
        }

        private void Button_dumpDir_Click(object sender, EventArgs e)
        {
            string path = GetDirPath();

            if (!string.IsNullOrEmpty(path))
            {
                textBox_dumpPath.Text = path;
            }
        }

        private void Button_restoreFile_Click(object sender, EventArgs e)
        {
            string path = GetFilePath();

            if (!string.IsNullOrEmpty(path))
            {
                textBox_restorePath.Text = path;
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Button_load_Click(object sender, EventArgs e)
        {
            load();
        }

        private Setting _setting = null;

        void save()
        {
            _setting = new Setting();

            _setting.PGParam.Host = textBox_db_host.Text;
            _setting.PGParam.Port = textBox_db_port.Text;
            _setting.PGParam.DatabaseName = textBox_db_name.Text;
            _setting.PGParam.User = textBox_db_user.Text;
            _setting.PGParam.Pass = textBox_db_pass.Text;

            _setting.DBinstallPath = textBox_dbPath.Text;
            _setting.DumpPath = textBox_dumpPath.Text;
            _setting.RestoreSourcePath = textBox_restorePath.Text;

            Setting.Save(_setting);

        }

        void load()
        {
            _setting = Setting.Load();

            if (_setting == null)
            {
                _setting = new Setting();
            }

            textBox_db_host.Text = _setting.PGParam.Host;
            textBox_db_port.Text = _setting.PGParam.Port;
            textBox_db_name.Text = _setting.PGParam.DatabaseName;
            textBox_db_user.Text = _setting.PGParam.User;
            textBox_db_pass.Text = _setting.PGParam.Pass;

            textBox_dbPath.Text = _setting.DBinstallPath;
            textBox_dumpPath.Text = _setting.DumpPath;
            textBox_restorePath.Text = _setting.RestoreSourcePath;

        }

        /// <summary>
        /// ディレクトリ選択ダイアログ
        /// </summary>
        /// <returns></returns>
        private string GetDirPath()
        {
            string path = string.Empty;

            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = @"c:\";
                dlg.Description = "";
                dlg.ShowNewFolderButton = false;

                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                }
            }

            return path;
        }

        /// <summary>
        /// ファイル選択ダイアログ
        /// </summary>
        /// <returns></returns>
        private string GetFilePath()
        {
            string path = string.Empty;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = @"c:\";
                dlg.FilterIndex = 2;
                dlg.Title = "";
                dlg.RestoreDirectory = true;

                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    path = dlg.FileName;
                }
            }

            return path;
        }

    }
}
