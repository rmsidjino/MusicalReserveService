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
    public class Hall
    {
        public string HallID { get; set; }
        public string HallName { get; set; }
        public string HallAddress { get; set; }
        public int VIP { get; set; }
        public int R { get; set; }
        public int S { get; set; }
        public int A { get; set; }


    }
    public class HallDAC : IDisposable
    {
        MySqlConnection conn;

        public HallDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetHall()
        {
            string sql = "SELECT hallID, hallName, hallAddress, VIP, R, S, A FROM hallinfo";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetHall(string hID)
        {
            string sql = "SELECT hallID, hallName, hallAddress, VIP, R, S, A FROM hallinfo where hallID = @hallID";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@hallID", hID);
            da.Fill(dt);

            return dt;
        }
        //이미지 다중추가로 수정중
        public bool Insert(Hall ha) 
        {
            string sql = @"insert into hallInfo(hallID, hallName, hallAddress,VIP,R,S,A) values(@hallID,@hallName,@hallAddress,@VIP,@R,@S,@A)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hallID", ha.HallID);
            cmd.Parameters.AddWithValue("@hallName", ha.HallName);
            cmd.Parameters.AddWithValue("@hallAddress", ha.HallAddress);
            cmd.Parameters.AddWithValue("@VIP", ha.VIP);
            cmd.Parameters.AddWithValue("@R", ha.R);
            cmd.Parameters.AddWithValue("@S", ha.S);
            cmd.Parameters.AddWithValue("@A", ha.A);


            int iRowaffect = cmd.ExecuteNonQuery();
            return (iRowaffect > 0);
        }


        public DataTable GetHallImage(string hid)
        {
            string sql = @"select hallimageID, hallID, hallImgFileName
from hallimage
where hallID = @hallID";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@hallID", hid);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetHallList()
        {
            string sql = @"select h.hallID, hallName, hallAddress
from hall h inner join hallimage hi on h.hallID = hi.hallID
where hi.hallMainImage = 'Y'";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(dt);
            return dt;
        }

        public bool UpdateMainImage(string hid, int imgID)
        {
            string sql = @"update hallimage set hallMainImage = 'N' where hallID=@hid;
update hallimage set hallMainImage = 'Y' 
where hallImageID=@imageID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hid", hid);
            cmd.Parameters.AddWithValue("@imageID", imgID);
            int iRowsAffect = cmd.ExecuteNonQuery();
            return (iRowsAffect > 0);
        }

        public bool UpdateImage(string hid, string fileName)
        {
            string sql = @"insert into hallimage(hallID,hallimgFileName) values(@hallID,@hallimgFileName)" ;

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hallID", hid);
            cmd.Parameters.AddWithValue("@hallimgFileName", fileName);
            int iRowsAffect = cmd.ExecuteNonQuery();
            return (iRowsAffect > 0);
        }

        public int DeleteHall(string hID)
        {
            string sql = @"delete from hallInfo where hallID=@hallID;update musicalInfo
set hallID = 'None'
where hallID = @hallID";

            try 
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("hallID", hID);
                
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
