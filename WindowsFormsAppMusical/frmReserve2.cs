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
    public partial class frmReserve2 : Form
    {
        
        public string SelectDate;
        public string SelectTime;
        DataTable dtSeat;
        public DataTable dtTime { get; set; }
        public string UserID { get; set; }
        public string MusicalID { get; set; }
        public string HallID { get; set; }
        public int Price { get; set; }
        private Form frmReserve1;
        private int musicalTimeID;
        int[] reserveSeat;
        public class Seat
        {
            public int Number { get; set; }
            public string Grade { get; set; }
            public int Reservation { get; set; }
        }

        public frmReserve2(Form frmReserve1)
        {
            InitializeComponent();
            this.frmReserve1= frmReserve1;
            frmReserve1.Hide();
            
        }

        private void frmReserve2_Load(object sender, EventArgs e)
        {
            dtSeat = new DataTable();
            dtSeat.Columns.Add(new DataColumn("Snum", typeof(int)));
            dtSeat.Columns.Add(new DataColumn("Sgrade", typeof(string)));
            dgvSelectSeat.RowHeadersVisible = false;
            DataGridViewUtil.SetInitGridView(dgvSelectSeat);
            DataGridViewUtil.AddGridTextColumn(dgvSelectSeat, "번호", "Snum", colWidth: 60);
            DataGridViewUtil.AddGridTextColumn(dgvSelectSeat, "등급", "Sgrade", colWidth: 60);

            lblDay.Text = SelectDate;
            lblTime.Text = SelectTime;

            HallDAC hall = new HallDAC();
            DataTable dt = hall.GetHall(HallID);
            hall.Dispose();
            int vip = Convert.ToInt32(dt.Rows[0]["VIP"]);
            int r = Convert.ToInt32(dt.Rows[0]["R"]);
            int s = Convert.ToInt32(dt.Rows[0]["S"]);
            int a = Convert.ToInt32(dt.Rows[0]["A"]);
            

            DataRow[] dataRows = dtTime.Select($"(musicalDay = '{SelectDate}') AND (musicalTime = '{SelectTime}')");
            musicalTimeID = Convert.ToInt32(dataRows[0]["musicalTimeID"].ToString());

            SeatDAC seat = new SeatDAC();
            DataTable allSeat = seat.GetMusicalSeat(musicalTimeID);
            seat.Dispose();

            reserveSeat = allSeat.Select().Select(x => x["seatNum"]).ToArray().Cast<int>().ToArray();

            MakeSeat(vip, r, s, a);



            CommonDAC com = new CommonDAC();
            DataTable dtCommon = com.GetCommonCodes("seat");
            com.Dispose();
            DataRow[] vipSeat = dtCommon.Select($"Code ='VIP'");
            DataRow[] rSeat = dtCommon.Select($"Code ='R'");
            DataRow[] sSeat = dtCommon.Select($"Code ='S'");
            DataRow[] aSeat = dtCommon.Select($"Code ='A'");

            lsbSeat.Items.Add($"{vipSeat[0]["Name"]}  {Convert.ToInt32(vipSeat[0]["Value"]) * Price /100} 원");
            lsbSeat.Items.Add($"{rSeat[0]["Name"]}  {Convert.ToInt32(rSeat[0]["Value"]) * Price /100} 원");
            lsbSeat.Items.Add($"{sSeat[0]["Name"]}  {Convert.ToInt32(sSeat[0]["Value"]) * Price /100} 원");
            lsbSeat.Items.Add($"{aSeat[0]["Name"]}  {Convert.ToInt32(aSeat[0]["Value"]) * Price /100} 원");

        }

        //여기 로직도....좌석 만드는건데 아주 더럽네요...ㅜ
        private void MakeSeat(int VIP,int R, int S, int A)
        {

            List<Seat> list = new List<Seat>();
            int j = 0;

            for (int i = 0; i < VIP; i++)
            {
                if (reserveSeat.Length > j)
                {
                    if (reserveSeat[j] == i)
                        list.Add(new Seat { Number = i, Grade = "VIP", Reservation = 1 });
                    else
                        list.Add(new Seat { Number = i, Grade = "VIP", Reservation = 0 });
                }
                else
                    list.Add(new Seat { Number = i, Grade = "VIP", Reservation = 0 });
            }
            for (int i = 0; i < R; i++)
            {
                if (reserveSeat.Length > j)
                {
                    if (reserveSeat[j] == i)
                        list.Add(new Seat { Number = i + VIP, Grade = "R", Reservation = 1 });
                    else
                        list.Add(new Seat { Number = i + VIP, Grade = "R", Reservation = 0 });
                }
                else
                    list.Add(new Seat { Number = i + VIP, Grade = "R", Reservation = 0 });

            }
            for (int i = 0; i < S; i++)
            {
                if (reserveSeat.Length > j)
                {
                    if (reserveSeat[j] == i)
                        list.Add(new Seat { Number = i + VIP + R, Grade = "S", Reservation = 1 });
                    else
                        list.Add(new Seat { Number = i + VIP + R, Grade = "S", Reservation = 0 });
                }
                else
                    list.Add(new Seat { Number = i + VIP + R, Grade = "S", Reservation = 0 });

            }
            for (int i = 0; i < A; i++)
            {
                if (reserveSeat.Length > j)
                {
                    if (reserveSeat[j] == i)
                        list.Add(new Seat { Number = i + VIP + R + S, Grade = "A", Reservation = 1 });
                    else
                        list.Add(new Seat { Number = i + VIP + R + S, Grade = "A", Reservation = 0 });
                }
                else
                    list.Add(new Seat { Number = i + VIP + R + S, Grade = "A", Reservation = 0 });

            }

            foreach (Seat seat in list)
            {
                Button btn = new Button();
                btn.Location = new Point(20 + (seat.Number % 20 * 20), seat.Number / 20 * 20);
                btn.Size = new Size(12, 12);
                btn.FlatStyle = FlatStyle.Flat;
                if(seat.Grade == "VIP")
                {
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.BackColor = Color.Red;
                }
                else if(seat.Grade =="R")
                {
                    btn.FlatAppearance.BorderColor = Color.Yellow;
                    btn.BackColor = Color.Yellow;
                }
                else if (seat.Grade == "S")
                {
                    btn.FlatAppearance.BorderColor = Color.Green;
                    btn.BackColor = Color.Green;
                }
                else if(seat.Grade == "A")
                {
                    btn.FlatAppearance.BorderColor = Color.Blue;
                    btn.BackColor = Color.Blue;
                }
                else
                {
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.BackColor = Color.Gray;
                }

                btn.Click += Btn_Click;
                btn.Text = (seat.Number +" " + seat.Grade).ToString();
                if (seat.Reservation == 1)
                {
                    btn.Enabled = false;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.BackColor = Color.Gray;
                }
                panel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text.Split(' ')[0];
            string grade = btn.Text.Split(' ')[1];
            DataRow[] rows = dtSeat.Select("Snum=" + num);
            if (rows.Length > 0)
            {
                dtSeat.Rows.Remove(rows[0]);
                btn.BackColor = btn.FlatAppearance.BorderColor;
            }
            else
            {
                btn.BackColor = SystemColors.Control;
                DataRow dr = dtSeat.NewRow();
                dr["Snum"] = num;
                dr["Sgrade"] = grade;
                dtSeat.Rows.Add(dr);
            }
            dtSeat.DefaultView.Sort = "Snum ASC";
            dtSeat.AcceptChanges();
            dgvSelectSeat.DataSource = dtSeat;
            dgvSelectSeat.ClearSelection();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmReserve1.Show();
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSelectSeat.Rows.Count > 0)
            {
                frmReserve3 frm = new frmReserve3(this);
                frm.UserID = this.UserID;
                frm.dtSeat = this.dtSeat;
                frm.Price = this.Price;
                frm.MusicalTimeID = musicalTimeID;
                frm.Show();
            }
            else
                MessageBox.Show("좌석을 선택해주세요");
        }
    }
}
