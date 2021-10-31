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
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNum { get; set; }
        public string UserPWD { get; set; }
        public string UserBirthDay { get; set; }
        public string UserGender { get; set; }
        public string IsAdmin { get; set; }

        public string UserAddress { get; set; }
    }

    public class UserDAC : IDisposable
    {
        MySqlConnection conn;

        public UserDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public User Login(string uID)
        {
            string sql = "select userID, userName, userPhoneNum, userPWD, userBirthDay, userGender, userEmail, userAddress, IsAdmin from userinfo where userID=@userID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", uID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User loginUser = new User();
                loginUser.UserID = reader["userID"].ToString();
                loginUser.UserName = reader["userName"].ToString();
                loginUser.UserEmail = reader["userEmail"].ToString();
                loginUser.UserPhoneNum = reader["userPhoneNum"].ToString();
                loginUser.UserPWD = reader["userPWD"].ToString();
                loginUser.UserGender = reader["userGender"].ToString();
                loginUser.UserBirthDay = reader["userBirthDay"].ToString();
                loginUser.UserAddress = reader["userAddress"].ToString();
                loginUser.IsAdmin = reader["IsAdmin"].ToString();

                return loginUser;
            }
            else
            {
                return null;
            }
        }

        public bool ConfirmUser(string id, string name, string email)
        {
            string sql = "select count(*) from userInfo where userID=@userID and userName=@userName and userEmail=@userEmail";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", id);
            cmd.Parameters.AddWithValue("@userName", name);
            cmd.Parameters.AddWithValue("@userEmail", email);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            return (cnt > 0);
        }

        public bool UpdatePWD(string uid, string newPwd)
        {
            string sql = "update userinfo set userPWD = @userPWD where userID=@userID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userPWD", newPwd);
            cmd.Parameters.AddWithValue("@userID", uid);
            int iRowsAffect = cmd.ExecuteNonQuery();
            return (iRowsAffect > 0);
        }

        public int Insert(User us)
        {
            try
            {
                string sql = $@"INSERT INTO userinfo(userID, userName, userPhoneNum, userPWD, createTime, userBirthDay, userGender, userEmail, userAddress) 
                            VALUES (@userID,@userName,@userPhoneNum,@userPWD,@createTime,@userBirthDay,@userGender,@userEmail,@userAddress)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", us.UserID);
                cmd.Parameters.AddWithValue("@userName", us.UserName);
                cmd.Parameters.AddWithValue("@userPhoneNum", us.UserPhoneNum);
                cmd.Parameters.AddWithValue("@userPWD", us.UserPWD);
                cmd.Parameters.AddWithValue("@userBirthDay", us.UserBirthDay);
                cmd.Parameters.AddWithValue("@userGender", us.UserGender);
                cmd.Parameters.AddWithValue("@userEmail", us.UserEmail);
                cmd.Parameters.AddWithValue("@userAddress", us.UserAddress);
                cmd.Parameters.AddWithValue("@createTime", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                int userID = Convert.ToInt32(cmd.ExecuteScalar());
                return userID;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable GetAll()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = @"SELECT userID,  userPWD,userName, userBirthDay, userGender,userPhoneNum,   userEmail,userAddress, IsAdmin,  createTime FROM userInfo";
            da.SelectCommand = new MySqlCommand(sql, conn);
            da.Fill(ds, "User");

            return ds.Tables["User"];
        }


    }
}
