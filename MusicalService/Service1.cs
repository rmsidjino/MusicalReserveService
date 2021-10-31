using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Timers;
using System.IO;

namespace MusicalService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer1 = null;
        string orgFolder = ConfigurationManager.AppSettings["OrgFolder"]; //공유폴더명
        int interval = int.Parse(ConfigurationManager.AppSettings["WorkInterval"]); //interval
        private MySqlConnection conn;
        public Service1()
        {
            InitializeComponent();
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }

        protected override void OnStart(string[] args)
        {
            LogWorker.WriteLog("서비스 시작....");

            //작업 timer start
            if (timer1 == null)
            {
                timer1 = new Timer();
                timer1.Interval = interval;
                timer1.Elapsed += Timer1_Elapsed;
            }

            timer1.Start();
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            int iRowsAffect = 0;
            try
            {
                string sql = @"delete from seatInfo where canceled =@canceled";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@canceled", "1");
                iRowsAffect = cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                LogWorker.WriteErrorLog(err.Message);
            }
            finally
            {
                LogWorker.WriteLog($"윈도우서비스 작업 완료 : 작업 => {iRowsAffect} 건");
            }
        }
        protected override void OnStop()
        {
            //작업 timer stop
            timer1.Stop();

            //서비스 종료 로그
            LogWorker.WriteLog("서비스 종료....");
        }
    }
}
