#define INFO
#define DEBUG
#define WARNING
#define ERROR

using System;
using System.IO;
using System.Reflection;
using System.Threading;


//namespace CRD
//{
    /// <summary>
    /// Logs operations.
    /// </summary>
    public class Log
    {
        private static System.Object lockObj = new System.Object();

        //private static string ApPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase); //WinCE support
        private static string ApPath = System.Windows.Forms.Application.StartupPath; 
        public static string LogPath = "";
        public static string LogFullFilename = "";

        /// <summary>
        /// Log info. 通常用在顯示參數傳遞值的內容
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="msg"></param>
        public static void i(string tag, string msg)
        {
#if INFO
            if (!writeLog("Info.", tag, msg))
            {
                //Retry again
                Thread.Sleep(100);
                writeLog("Info.:Log Retried", tag, msg);
            }
#endif
        }


        /// <summary>
        /// Log Debug. 用在追蹤程式流程, 變數的改變, 及其他需要記錄的log. 是最常使用的 log function.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="msg"></param>
        public static void d(string tag, string msg)
        {
#if DEBUG
            if (!writeLog("Debug", tag, msg))
            {
                //Retry again
                Thread.Sleep(100);
                writeLog("Debug:Log Retried", tag, msg);
            }
#endif
        }


        /// <summary>
        /// Log Warning. 用在顯示程式收到錯誤訊息, 或是跑到預期外的流程.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="msg"></param>
        public static void w(string tag, string msg)
        {
#if WARNING
            if (!writeLog("Warn.", tag, msg))
            {
                //Retry again
                Thread.Sleep(100);
                writeLog("Warn.:Log Retried", tag, msg);
            }
#endif
        }


        /// <summary>
        /// Log Error. 用在顯示程式出現可能導致致命錯誤, 或是Exception.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="msg"></param>
        public static void e(string tag, string msg)
        {
#if ERROR

            if (!writeLog("Error", tag, msg))
            {
                //Retry again
                Thread.Sleep(100);
                writeLog("Error:Log Retried", tag, msg);
            }
#endif
        }


       
        /* WriteLog 
         *  type: Info Type, it can be "Error", "Warn.", "Debug"....
         *  tag:  It is a user defined tag that can be any token to indecate the occurred location of message or other extra info.
         */
        private static bool writeLog(string type, string tag, string message)
        {
            StreamWriter sWriter = null;
            lock (lockObj)
            {
                try
                {
                    //string dirPath = dirRoot + "\\Debug\\";
                    LogPath = ApPath + @"\LOG\" + DateTime.Now.ToString("yyyyMMdd") + @"\";
                    LogFullFilename = LogPath + DateTime.Now.ToString("yyyyMMddHH") + ".log";

                    if (!Directory.Exists(LogPath))
                        Directory.CreateDirectory(LogPath);

                    FileStream filestream = new FileStream(LogFullFilename,
                                           FileMode.OpenOrCreate,
                                           FileAccess.Write);

                    sWriter = new StreamWriter(filestream);
                    sWriter.BaseStream.Seek(0, SeekOrigin.End);

                    if (message == "" ||
                        message == Environment.NewLine)
                    {
                        sWriter.WriteLine(message);
                    }
                    else
                    {
                        string head = "[" + DateTime.Now.ToString("hh:mm:ss.ffff") +
                                    "] [" + type + "] [" + tag + "]: ";
                        sWriter.WriteLine(head + message);
                    }

                    sWriter.Flush();
                    sWriter.Close();
                    //Console.WriteLine(head + message); // for debug test
                }
                catch //(Exception e)
                {
                    //System.Windows.Forms.MessageBox.Show("Write Log Exception. Msg=" + e.StackTrace);
                    if (sWriter != null)
                    {
                        try
                        {
                            sWriter.Close();
                        }
                        catch { }
                    }
                    return false;
                }
            } //End of lock
            return true;
        }
    }
//}
