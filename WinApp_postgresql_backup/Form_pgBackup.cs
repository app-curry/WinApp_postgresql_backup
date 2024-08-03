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


        }
    }
}
