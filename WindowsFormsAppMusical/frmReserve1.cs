using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMusical
{
    public partial class frmReserve1 : Form
    {
        DataTable dtTime;
        List<DateTime> MusicalDates = new List<DateTime>();
        public string Date;
        public string Time;
        public DataTable MusicalInfo { get; set; }

        public string UserID { get; set; }
        public frmReserve1()
        {
            InitializeComponent();
        }

        public frmReserve1(DataTable MI)
        {
            InitializeComponent();
            MusicalInfo = MI;

        }

        private void frmReserve1_Load(object sender, EventArgs e)
        {
            MusicalTimeDAC dac = new MusicalTimeDAC();
            dtTime = dac.GetMusicalTime(MusicalInfo.Rows[0]["MusicalID"].ToString());
            dac.Dispose();

            for(int i = 0;i<dtTime.Rows.Count; i++)
            {
                string[] date = dtTime.Rows[i]["musicalDay"].ToString().Split('-');
                string[] time = dtTime.Rows[i]["musicalTime"].ToString().Split('-');
                int year = int.Parse(date[0]);
                int month = int.Parse(date[1]);
                int day = int.Parse(date[2]);
                DateTime musicalday = new DateTime(year,month,day);
                if(musicalday> DateTime.Now)
                    MusicalDates.Add(musicalday);
            }
            monthCalendar1.BoldedDates = MusicalDates.ToArray();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            Date = e.Start.ToString().Substring(0, 10);
            if (Convert.ToDateTime(Date) >= DateTime.Now)
            {
                DataRow[] rows = dtTime.Select($"musicalDay ='{Date}'");
                if (rows.Length > 0)
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        listBox1.Items.Add($"[{i + 1}회차]" + rows[0]["musicalTime"]);
                    }
                }
            }
            if(listBox1.Items.Count>0)
                listBox1.SelectedIndex = 0;
        }

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string[] Time = listBox1.SelectedItem.ToString().Split(']');

                frmReserve2 frm = new frmReserve2(this);
                frm.UserID = this.UserID;
                frm.MusicalID = MusicalInfo.Rows[0]["MusicalID"].ToString();
                frm.HallID = MusicalInfo.Rows[0]["HallID"].ToString();
                frm.SelectDate = this.Date;
                frm.SelectTime = Time[1];
                frm.Price = Convert.ToInt32(MusicalInfo.Rows[0]["MusicalPrice"].ToString());
                frm.dtTime = this.dtTime;
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("날짜를 선택해주세요");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] Time = listBox1.SelectedItem.ToString().Split(']');
            IEnumerable<DataRow> rows = dtTime.AsEnumerable().Where(r => r.Field<string>("musicalDay") == Date
            && r.Field<string>("musicalTime") == Time[1]);

            SeatDAC seat = new SeatDAC();
            DataTable sDt =seat.GetMusicalSeatReserve(Convert.ToInt32(rows.ToList()[0]["musicalTimeID"].ToString()));
            seat.Dispose();

            HallDAC hall = new HallDAC();
            DataTable hDt = hall.GetHall(MusicalInfo.Rows[0]["HallID"].ToString());
            hall.Dispose();

            for (int i = 0; i<hDt.Columns.Count-3; i++)
            {
                DataRow[] grade = sDt.Select($"seatGrade ='{hDt.Columns[i+3].ColumnName}'");
                if (grade.Length >0)
                    listBox2.Items.Add($"{hDt.Columns[i + 3].ColumnName}석 (잔여 : {Convert.ToInt32(hDt.Rows[0][i+3]) - Convert.ToInt32(grade[0]["cnt"])})");
                else
                    listBox2.Items.Add($"{hDt.Columns[i + 3].ColumnName}석 (잔여 : {Convert.ToInt32(hDt.Rows[0][i+3])})");
            }


        }
    }
}
