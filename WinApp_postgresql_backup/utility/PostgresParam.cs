using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_postgresql_backup.utility
{
    /// <summary>
    /// バックアップ対象データベース接続設定
    /// </summary>
    internal class PostgresParam
    {
        private string _user;

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _pass;

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private string _host;

        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        private string _port;

        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private string _dbname;

        public string DatabaseName
        {
            get { return _dbname; }
            set { _dbname = value; }
        }


    }
}
