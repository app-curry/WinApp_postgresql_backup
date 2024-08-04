using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_postgresql_backup.utility
{
    internal class PostgreSQLCmdGen
    {
        /// <summary>
        /// pg_dump,pg_restore実行中のパスワード入力を省略するためのファイルを作成
        /// "hostname:port:database:username:password"
        /// 33.15. パスワードファイル
        /// https://www.postgresql.jp/document/10/html/libpq-pgpass.html
        /// </summary>
        /// <param name="param"></param>
        public static void CreatePassFile(PostgresParam param)
        {

            string appdatadir = "";
            appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string path = Path.Combine(appdatadir, "postgresql");
            Directory.CreateDirectory(path);

            path = Path.Combine(path, "pgpass.conf");

            string output = String.Format("{0}:{1}:{2}:{3}:{4}",
                param.Host, param.Port, param.DatabaseName, param.User, param.Pass);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(output);

                sw.Close();
            }

        }

    }
}
