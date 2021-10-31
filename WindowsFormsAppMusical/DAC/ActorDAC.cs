using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsAppMusical
{
    public class Actor
    {
        public string ActorID { get; set; }
        public string ActorName { get; set; }
        public int ActorAge { get; set; }
        public string ActorImgFileName { get; set; }
    }
    public class ActorDAC : IDisposable
    {
        MySqlConnection conn;

        public ActorDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetActor()
        {
            string sql = "SELECT actorID, actorName, actorAge, actorImgFileName FROM actorinfo";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetActor(string mID)
        {
            string sql = @"select ac.actorName
from actorinfo ac
inner
join actorinmusical aci
on aci.actorID = ac.actorID
where aci.musicalID = @musicalID ";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@musicalID", mID);
            da.Fill(dt);
            return dt;
        }

        public bool Insert(Actor ac) //이미지경로로 저장
        {
            string sql = "insert into actorInfo(actorID, actorName, actorAge, actorImgFileName) values(@actorID,@actorName,@actorAge, @actorImgFileName)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@actorID", ac.ActorID);
            cmd.Parameters.AddWithValue("@actorName", ac.ActorName);
            cmd.Parameters.AddWithValue("@actorAge", ac.ActorAge);
            cmd.Parameters.AddWithValue("@actorImgFileName", ac.ActorImgFileName);

            int iRowaffect = cmd.ExecuteNonQuery();
            return (iRowaffect > 0);
        }

        public int UpdateActor(Actor ac)
        {
            try
            {
                string sql = $"UPDATE actorInfo SET actorName=@actorName actorImgFileName =@actorImgFileName actorAge = @actorAge WHERE actorID=@actorID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@actorName", ac.ActorName);
                cmd.Parameters.AddWithValue("@actorImgFileName", ac.ActorImgFileName);
                cmd.Parameters.AddWithValue("@actorAge", ac.ActorAge);
                cmd.Parameters.AddWithValue("@actorID", ac.ActorID);

                return cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        public int DeleteActor(string aID)
        {
            string sql = @"delete from actorInfo where actorID=@actorID;delete from actorinmusical where actorID = @actorID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("actorID", aID);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

    }
}
