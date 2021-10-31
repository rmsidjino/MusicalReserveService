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
    public class Seat
    {
        public int SeatCode { get; set; }
        public int MusicalTimeID { get; set; }
        public string userID { get; set; }
        public string HallID { get; set; }
        public int SeatNum { get; set; }
        public string Discount { get; set; }
        public string SeatGrade { get; set; }

    }
    public class SeatDAC : IDisposable
    {
        MySqlConnection conn;

        public SeatDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public bool Insert(string uID, int mTimeID, DataTable dt, List<string[]> dic)
        {
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                string sql = @"insert into seatInfo(musicalTimeID, userID, seatNum, seatGrade, discount) 
values(@musicalTimeID, @userID, @seatNum, @seatGrade, @discount) ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = transaction;
                cmd.Parameters.Add("@musicalTimeID", MySqlDbType.Int32);
                cmd.Parameters.Add("@userID", MySqlDbType.VarChar);
                cmd.Parameters.Add("@seatNum", MySqlDbType.Int32);
                cmd.Parameters.Add("@seatGrade", MySqlDbType.VarChar);
                cmd.Parameters.Add("@discount", MySqlDbType.VarChar);

                cmd.Parameters["@musicalTimeID"].Value = mTimeID;
                cmd.Parameters["@userID"].Value = uID;            
                for(int i =0; i < dic.Count; i++)
                {
                    cmd.Parameters["@seatNum"].Value = dt.Rows[i]["Snum"].ToString();
                    cmd.Parameters["@seatGrade"].Value = dt.Rows[i]["Sgrade"].ToString();

                    cmd.Parameters["@discount"].Value = dic[i][1];
                    cmd.ExecuteNonQuery();
                }


                transaction.Commit();
                return true;
            }

        }

        public DataTable GetUserSeat(string uID)
        {
            string sql = @"select seatCode, s.musicalTimeID, mi.musicalName, m.musicalDay,time_format(m.musicalTime,'%H:%y') musicalTime , seatNum, seatGrade, discount,registerTime
from seatinfo s
inner
join musicaltime m on m.musicalTimeID = s.musicalTimeID
inner
join musicalinfo mi on mi.musicalID = m.musicalID
where userID = @userID and s.canceled = 0";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@userID", uID);
            da.Fill(dt);
            return dt;
        }
        public bool Delete(List<int> lSeat)
        {
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                string sql = $"UPDATE seatInfo SET canceled=1 WHERE seatCode=@seatCode";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = transaction;              
                cmd.Parameters.Add("@seatCode", MySqlDbType.Int32);
                for (int i = 0; i < lSeat.Count; i++)
                {
                    cmd.Parameters["@seatCode"].Value = lSeat[i];
                    cmd.ExecuteNonQuery();
                }
                
                transaction.Commit();
                return true;
            }
        }

        public DataTable GetMusicalSeat(int mtID)
        {
            string sql = @"select seatNum from seatinfo where musicalTimeID = @musicalTimeID";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@musicalTimeID", mtID);
            da.Fill(dt);
            return dt;
        }

        public DataSet GetAllSeatInfo()
        {
            DataSet ds = new DataSet();

            string sql = @"select musicalID, musicalName from musicalInfo;select musicalTimeID, musicalID, date_format(musicalDay,'%Y-%m-%d') musicalDay, time_format(musicalTime,'%h:%y') musicalTime from musicalTime;select musicalTimeID, seatCode, userID, registerTime, seatNum, seatGrade, discount, canceled from SeatInfo;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(ds);

            return ds;
        }

        public DataTable GetMusicalSeatCount()
        {
            DataTable dt = new DataTable();

            string sql = @"select m.musicalName, ifnull(c.countNum,0) countNum
from musicalInfo m
left outer join
(select mt.musicalID, count(mt.musicalID) countNum
from musicalTime mt
inner join seatinfo s
on mt.musicalTimeID = s.musicalTimeID
group by mt.musicalDay) c
on c.musicalID = m.musicalID;;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllSeatInfo(int mtID)
        {
            DataTable dt = new DataTable();

            string sql = @"select musicalTimeID, seatCode, userID, registerTime, seatNum, seatGrade, discount, canceled from SeatInfo where musicalTimeID = @musicalTimeID;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@musicalTimeID", mtID);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetMusicalSeatReserve(int mtID)
        {
            string sql = @"select seatGrade ,COUNT(seatGrade) as cnt from seatInfo where musicalTimeID =@musicalTimeID group by seatGrade";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@musicalTimeID", mtID);
            da.Fill(dt);
            return dt;
        }

        public bool Update(DataTable dtChange)
        {
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                string sql = @"update seatInfo set  userID=@userID, seatNum=@seatNum, seatGrade=@seatGrade, discount=@discount ,canceled =@canceled where seatCode=@seatCode";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = transaction;
                cmd.Parameters.Add("@userID", MySqlDbType.VarChar);
                cmd.Parameters.Add("@seatNum", MySqlDbType.Int32);
                cmd.Parameters.Add("@seatGrade", MySqlDbType.VarChar);
                cmd.Parameters.Add("@discount", MySqlDbType.VarChar);
                cmd.Parameters.Add("@canceled", MySqlDbType.VarChar);
                cmd.Parameters.Add("@seatCode", MySqlDbType.Int32);

                for (int i = 0; i < dtChange.Rows.Count; i++)
                {
                    cmd.Parameters["@userID"].Value = dtChange.Rows[i]["userID"].ToString();
                    cmd.Parameters["@seatNum"].Value = Convert.ToInt32(dtChange.Rows[i]["seatNum"]);
                    cmd.Parameters["@seatGrade"].Value = dtChange.Rows[i]["seatGrade"].ToString();
                    cmd.Parameters["@discount"].Value = dtChange.Rows[i]["discount"].ToString();
                    cmd.Parameters["@canceled"].Value = dtChange.Rows[i]["canceled"].ToString();
                    cmd.Parameters["@seatCode"].Value = Convert.ToInt32(dtChange.Rows[i]["seatCode"]);
                    cmd.ExecuteNonQuery();
                }


                transaction.Commit();
                return true;
            }

        }
    }

    
}
