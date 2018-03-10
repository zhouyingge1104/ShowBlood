using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ShowBlood.func
{
    class FnFile
    {
        const string CONFIG_FILE_NAME = "config.json";

        public FnFile(){}

        /// <summary>
        /// 获取配置 config.json
        /// </summary>
        public string getConfig()
        {
            string cfgStr = "";
            FileInfo p = new FileInfo(System.Environment.CurrentDirectory + "\\" + CONFIG_FILE_NAME);
            if (!p.Exists)
            {
                p.Create().Close(); //【写blog 这里必须加Close() ，否则下一步会提示被占用】
            }
            StreamReader reader = new StreamReader(p.FullName);
            cfgStr = reader.ReadToEnd();
            reader.Close();
            return cfgStr;
        }

        /// <summary>
        /// 写入配置文件 config.json
        /// </summary>
        public void toConfig(string cfgStr)
        {
            FileInfo p = new FileInfo(System.Environment.CurrentDirectory + "\\" + CONFIG_FILE_NAME);
            if (!p.Exists)
            {
                p.Create().Close(); //【写blog 这里必须加Close() ，否则下一步会提示被占用】
            }
            StreamWriter writer = new StreamWriter(p.FullName);
            writer.WriteLine(cfgStr);
            writer.Close();
        }

    }
}
