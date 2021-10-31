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
    
    public partial class frmSeatMake : Form
    {
        public int VIP { get; set; }
        public int R { get; set; }
        public int S { get; set; }
        public int A { get; set; }

        public class Seat
        {
            public int Number { get; set; }
            public string Grade { get; set; }
            public int Reservation { get; set; }
        }
        public frmSeatMake()
        {
            InitializeComponent();
        }

        public frmSeatMake(int vip =0,int r = 0, int s = 0, int a = 0)
        {
            InitializeComponent();
            VIP = vip;
            R = r;
            S = s;
            A = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIP = Convert.ToInt32(txtVipSeat.Text);
            R = Convert.ToInt32(txtRSeat.Text);
            S = Convert.ToInt32(txtSSeat.Text);
            A = Convert.ToInt32(txtASeat.Text);
            panel1.Controls.Clear();
            MakeSeat();
        }

        //여기 좌석만드는건데 너무 개판....이네요...로직을 막짜서....ㅠㅠ
        private void MakeSeat()
        {
            List<Seat> list = new List<Seat>();

            for (int i = 0; i < VIP; i++)
            {
                list.Add(new Seat { Number = i, Grade = "VIP", Reservation = 0 });
            }
            for (int i = 0; i < R; i++)
            {
                list.Add(new Seat { Number = i, Grade = "R", Reservation = 0 });
            }
            for (int i = 0; i < S; i++)
            {
                list.Add(new Seat { Number = i, Grade = "S", Reservation = 0 });
            }
            for (int i = 0; i < A; i++)
            {
                list.Add(new Seat { Number = i, Grade = "A", Reservation = 0 });
            }


            foreach (Seat seat in list)
            {
                Button btn = new Button();               
                btn.Size = new Size(12, 12);
                btn.FlatStyle = FlatStyle.Flat;
                if(seat.Grade == "VIP")
                {
                    int odd = (VIP / (VIP / 20 + 1) % 2 == 1) ? 10 : 0;
                    if (VIP%20 !=0)
                        for(int i =0; i <= VIP /20; i++)
                            btn.Location = new Point(20 + odd + (20-VIP/(VIP/20+1))/2 *20 + (seat.Number % (VIP / (VIP / 20 + 1)) * 20), seat.Number / (VIP / (VIP / 20 + 1)) * 20);
                    else
                        btn.Location = new Point(20  + (seat.Number % 20 * 20), seat.Number / 20 * 20);
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.BackColor = Color.Red;
                }
                else if(seat.Grade =="R")
                {
                    int odd = (R / (R / 20 + 1) % 2 == 1) ? 10 : 0;
                    if (R % 20 != 0)
                        for (int i = 0; i <= R / 20; i++)
                            btn.Location = new Point(20 + odd + (20 - R / (R / 20 + 1)) / 2 * 20 + (seat.Number % (R / (R / 20 + 1)) * 20), (VIP / 20 + 1) * 20 + seat.Number / (R / (R / 20 + 1)) * 20);
                    else
                        btn.Location = new Point(20 + (seat.Number % 20 * 20), (VIP/20 +1) * 20);
                    btn.FlatAppearance.BorderColor = Color.Yellow;
                    btn.BackColor = Color.Yellow;
                }
                else if (seat.Grade == "S")
                {
                    int odd = (S / (S / 20 + 1) % 2 == 1) ? 10 : 0;
                    if (S % 20 != 0)
                        for (int i = 0; i <= S / 20; i++)
                            btn.Location = new Point(20 + odd + (20 - S / (S / 20 + 1)) / 2 * 20 + (seat.Number % (S / (S / 20 + 1)) * 20), (VIP / 20 + R / 20 + 2) * 20 +  seat.Number / (S / (S / 20 + 1)) * 20 );
                    else
                        btn.Location = new Point(20 + (seat.Number % 20 * 20), (VIP / 20 + R/20 +2 )  * 20);
                    btn.FlatAppearance.BorderColor = Color.Green;
                    btn.BackColor = Color.Green;
                }
                else if(seat.Grade == "A")
                {
                    int odd = (A / (A / 20 + 1) % 2 == 1) ? 10 : 0;
                    if (A % 20 != 0)
                        for (int i = 0; i <= A / 20; i++)
                            btn.Location = new Point(20 + odd + (20 - A / (A / 20 + 1)) / 2 * 20 + (seat.Number % (A / (A / 20 + 1)) * 20), (VIP / 20 + R / 20 + S / 20 + 3) * 20 +  seat.Number / (A / (A / 20 + 1)) * 20);
                    else
                        btn.Location = new Point(20 + (seat.Number % 20 * 20), (VIP / 20 + R / 20 + S/20 +3) * 20);
                    btn.FlatAppearance.BorderColor = Color.Blue;
                    btn.BackColor = Color.Blue;
                }
                else
                {
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.BackColor = Color.Gray;
                }

                panel1.Controls.Add(btn);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void frmSeatMake_Load(object sender, EventArgs e)
        {
            txtVipSeat.Text = VIP.ToString();
            txtRSeat.Text = R.ToString();
            txtSSeat.Text = S.ToString();
            txtASeat.Text = A.ToString();

        }
    }
}
