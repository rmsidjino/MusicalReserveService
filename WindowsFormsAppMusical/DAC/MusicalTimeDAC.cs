using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppMusical
{
    class MusicalTimeDAC :IDisposable
    {
        MySqlConnection conn;

        public MusicalTimeDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetMusicalTime(string musicalID)
        {
            string sql = "SELECT musicalTimeID, musicalID, date_format(musicalDay,'%Y-%m-%d') as musicalDay, time_format(musicalTime,'%H:%y') musicalTime FROM musicalTime where musicalID =@musicalID";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(sql, conn);           
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@musicalID", musicalID);
            da.Fill(dt);

            return dt;
        }

        public bool Insert(string mID, List<DateTime> times)
        {
           using (MySqlTransaction transaction = conn.BeginTransaction())
           {
                string sql = "insert into musicalTIme(musicalID, musicalDay, musicalTime) values(@musicalID, @musicalDay, @musicalTime);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = transaction;
                cmd.Parameters.Add("@musicalID", MySqlDbType.VarChar);
                cmd.Parameters.Add("@musicalDay",MySqlDbType.Date);
                cmd.Parameters.Add("@musicalTime",MySqlDbType.Time);

                for (int i =0; i < times.Count; i++)
                {
                    cmd.Parameters["@musicalID"].Value = mID;
                    cmd.Parameters["@musicalDay"].Value = times[i].ToString("yyyy-MM-dd");
                    cmd.Parameters["@musicalTime"].Value = TimeSpan.Parse(times[i].ToString("HH:mm:ss"));

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
           }


        }
    }
}
