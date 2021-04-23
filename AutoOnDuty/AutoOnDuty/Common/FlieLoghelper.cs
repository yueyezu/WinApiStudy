using System;
using System.IO;

namespace AutoOnDuty.Common
{
    /// <summary>
    /// 日志输出类
    /// </summary>
    public class LogHelp
    {
        public static String AppPath = AppDomain.CurrentDomain.BaseDirectory + "\\log\\";
        public static String FileName = DateTime.Now.ToString("yyyy-MM-dd") + "_log.log";

        /// <summary>
        /// 输出函数，把要输出的数据写入文件
        /// </summary>
        /// <param name="logName"></param>
        /// <param name="msg"></param>
        public static void Log(String logName, String msg, string path)
        {
            if (!Directory.Exists(AppPath))
            {
                Directory.CreateDirectory(AppPath);
            }
            String FilePath = AppPath + FileName;
            try
            {
                StreamWriter strmW = new StreamWriter(FilePath, true, System.Text.Encoding.UTF8);
                strmW.WriteLine(DateTime.Now.ToString("[hh:mm:ss] [") + logName + "]  " + msg + " " + path);
                strmW.Close();
            }
            catch
            {
            }
        }

        /// <summary>
        /// 输出对象到文件
        /// </summary>
        /// <param name="obj"></param>
        public static void Log(object obj)
        {
            Log("Info", obj.ToString(), "");
        }

        /// <summary>
        /// 输出警告信息
        /// </summary>
        /// <param name="msg">警告信息</param>
        /// <param name="path">发生警告信息位置的路径</param>
        public static void LogWarningMsg(string msg, string path)
        {
            Log("Wornning", msg, path);
        }

        /// <summary>
        /// 输出警告信息
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="path">发生错误信息位置的路径</param>
        public static void LogErrorMsg(string msg, string path)
        {
            Log("Error", msg, path);
        }
    }
}
