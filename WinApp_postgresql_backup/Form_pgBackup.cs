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

            this.textBox_db_pass.PasswordChar = '*';

            button_load.Click += Button_load_Click;
            button_save.Click += Button_save_Click;
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

    }
}
