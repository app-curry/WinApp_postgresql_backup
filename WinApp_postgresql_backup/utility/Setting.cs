using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinApp_postgresql_backup.utility
{
    /// <summary>
    /// 入力した各設定の保存機能
    /// </summary>
    internal class Setting
    {
        public Setting()
        {
            _pgParam = new PostgresParam();
        }

        // bin(pg_dump,pg_restore) dir
        private string _dbinstallPath;

        public string DBinstallPath
        {
            get { return _dbinstallPath; }
            set { _dbinstallPath = value; }
        }

        // dir
        private string _dumpPath;

        public string DumpPath
        {
            get { return _dumpPath; }
            set { _dumpPath = value; }
        }

        // file
        private string _restoreSourcePath;

        public string RestoreSourcePath
        {
            get { return _restoreSourcePath; }
            set { _restoreSourcePath = value; }
        }


        private PostgresParam _pgParam;

        public PostgresParam PGParam
        {
            get { return _pgParam; }
            set { _pgParam = value; }
        }

        private static string GetSettingFilePath()
        {
            string path = string.Empty;

            path = AppDomain.CurrentDomain.BaseDirectory;
            path = Path.Combine(path, "setting.json");


            return path;
        }

        public static void Save(Setting param)
        {
            string path = GetSettingFilePath();

            string json = JsonSerializer.Serialize(param);

            File.WriteAllText(path, json);

        }

        public static Setting Load()
        {
            Setting setting = null;

            string path = GetSettingFilePath();

            if (!File.Exists(path))
            {
                return null;
            }

            string s = File.ReadAllText(path);

            setting = JsonSerializer.Deserialize<Setting>(s);

            return setting;

        }
    }
}
