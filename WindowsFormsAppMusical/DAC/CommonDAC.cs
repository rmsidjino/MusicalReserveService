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
    public class Commmon
    {
        public string Code { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }

    }
    public class CommonDAC
    {
        MySqlConnection conn;

        public CommonDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["projectDB"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetCommonCodes(params string[] category)
        {
            string temp = "'" + string.Join("','", category) + "'"; // discount, rate, seat

            string sql = @"select Code, Value, Category from commoncode 
where Category in (" + temp + ")";  //'discount, rate, seat

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetCommonCodes(string category)
        {          

            string sql = @"select Code, Value, Category, Name from commoncode 
where category = @category order by Value desc";  //'discount, rate, seat

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@category", category);
            
            da.Fill(dt);

            return dt;
        }
    }
}
