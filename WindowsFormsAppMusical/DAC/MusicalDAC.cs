using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsAppMusical
{
    public class Musical
    {
        public string MusicalID { get; set; }
        public string MusicalName { get; set; }
        public string MusicalStartDay { get; set; }
        public string MusicalEndDay { get; set; }
        public string TicketOpenDay { get; set; }
        public int MusicalTime { get; set; }
        public string MusicalGrade { get; set; }
        public string MusicalPoster { get; set; }
        public string MusicalDetail { get; set; }
        public int MusicalPrice { get; set; }
        public string HallID { get; set; }
    }
    public class MusicalDAC : IDisposable
    {
        MySqlConnection conn;

        public MusicalDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetMusical()
        {
            string sql = "SELECT musicalID, musicalName, date_format(musicalStartDay, '%Y-%m-%d') musicalStartDay, date_format(musicalEndDay, '%Y-%m-%d') musicalEndDay, ticketOpenDay,musicalGrade, musicalPoster, musicalDetail, musicalTime, musicalPrice, hallID FROM musicalinfo order by musicalStartDay";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetMusical(string musicalId)
        {
            string sql = "SELECT musicalID, musicalName, date_format(musicalStartDay, '%Y-%m-%d') musicalStartDay, date_format(musicalEndDay, '%Y-%m-%d') musicalEndDay, ticketOpenDay, musicalGrade, musicalPoster, musicalDetail, musicalTime, musicalPrice, hallID FROM musicalinfo where musicalID =@musicalID";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@musicalID", musicalId);
            da.Fill(dt);
            return dt;
        }

        public bool Insert(Musical mu)
        {
            string sql = @"insert into musicalInfo(musicalID, musicalName, musicalStartDay, musicalEndDay, ticketOpenDay, musicalGrade, musicalPoster, musicalDetail, musicalTime, musicalPrice, hallID) 
values(@musicalID,@musicalName,@musicalStartDay,@musicalEndDay,@ticketOpenDay,@musicalGrade,@musicalPoster,@musicalDetail,@musicalTime,@musicalPrice,@hallID)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@musicalID", mu.MusicalID);
            cmd.Parameters.AddWithValue("@musicalName", mu.MusicalName);
            cmd.Parameters.AddWithValue("@musicalStartDay", mu.MusicalStartDay);
            cmd.Parameters.AddWithValue("@musicalEndDay", mu.MusicalEndDay);
            cmd.Parameters.AddWithValue("@musicalticketOpenDay", mu.TicketOpenDay);
            cmd.Parameters.AddWithValue("@musicalGrade", mu.MusicalGrade);
            cmd.Parameters.AddWithValue("@musicalPoster", mu.MusicalPoster);
            cmd.Parameters.AddWithValue("@musicalDetail", mu.MusicalDetail);
            cmd.Parameters.AddWithValue("@musicalPrice", mu.MusicalPrice);
            cmd.Parameters.AddWithValue("@musicalTime", mu.MusicalTime);
            cmd.Parameters.AddWithValue("@ticketOpenDay", mu.TicketOpenDay);
            cmd.Parameters.AddWithValue("@hallID", mu.HallID);


            int iRowaffect = cmd.ExecuteNonQuery();
            return (iRowaffect > 0);
        }

        public bool AddActor(string mID, IList<string> actors)
        {
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                string sql = @"insert into actorinmusical(musicalID, actorID) 
values(@musicalID, @actorID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@musicalID", mID);
                cmd.Parameters.Add("@actorID", MySqlDbType.VarChar);
                for (int i = 0; i < actors.Count; i++)
                {                 
                    cmd.Parameters["@actorID"].Value = actors[i];

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
        }
    }
}
