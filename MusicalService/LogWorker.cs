using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicalService
{
    class LogWorker
    {
        public static void WriteLog(string msg)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\JungJinho\WorkLogFile.log", true);

                sw.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")} : {msg}");
                sw.Flush();
                sw.Close();
            }
            catch (Exception err)
            {
                WriteErrorLog(err.Message);
            }
        }

        public static void WriteErrorLog(string msg)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\JungJinho\LogFile.log", true);

                sw.WriteLine($"[ERROR] {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")} : {msg}");
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
