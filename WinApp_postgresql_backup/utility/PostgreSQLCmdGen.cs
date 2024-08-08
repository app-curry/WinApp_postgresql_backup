using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        private static string GetTimestampString()
        {
            string ts = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");

            return ts;
        }

        /// <summary>
        /// ダンプコマンドの生成
        /// </summary>
        public static void Dump_cmd(Setting setting)
        {
            string ts = GetTimestampString();

            string destdir = setting.DumpPath;

            string cmdfilename = string.Format("{0}.pg_dump.bat", ts);
            string cmdfilepath = Path.Combine(destdir, cmdfilename);

            string dumpfilename = string.Format("{0}.pg_dump", ts);
            string dumpfilepath = Path.Combine(destdir, dumpfilename);

            string dbbin = setting.DBinstallPath;

            string cd = String.Format("cd {0}", dbbin);

            string dump =
                String.Format("pg_dump -h {0} -p {1} -U {2} -d {3} -Fc -v -f {4}",
                setting.PGParam.Host,
                setting.PGParam.Port,
                setting.PGParam.User,
                setting.PGParam.DatabaseName,
                dumpfilepath);

            List<string> cmdlist = new List<string>();

            cmdlist.Add(cd);
            cmdlist.Add(dump);
            cmdlist.Add("PAUSE");

            string cmd = string.Join(Environment.NewLine, cmdlist);

            execute_cmd(cmd, cmdfilepath);

        }

        private static void execute_cmd(string cmd, string cmdfilepath)
        {

            using (StreamWriter sw = new StreamWriter(cmdfilepath))
            {
                sw.WriteLine(cmd);
                sw.Close();
            }

            Process.Start(cmdfilepath);

        }

        public static void Restore_cmd(Setting setting)
        {
            string restoredumpfilepath = setting.RestoreSourcePath;

            string ts = GetTimestampString();

            string cmdfilepath = restoredumpfilepath + ".restore.bat";

            PostgresParam param = setting.PGParam;

            string dbbin = setting.DBinstallPath;
            string cd = String.Format("cd {0}", dbbin);

            string restore =
                String.Format("pg_restore --clean -h {0} -p {1} -U {2} -d {3} {4}",
                param.Host, param.Port, param.User, param.DatabaseName, restoredumpfilepath);

            List<string> cmdlist = new List<string>();

            cmdlist.Add(cd);
            cmdlist.Add(restore);
            cmdlist.Add("PAUSE");

            string cmd = string.Join(Environment.NewLine, cmdlist);

            execute_cmd(cmd, cmdfilepath);

        }


    }
}
