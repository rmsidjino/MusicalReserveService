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
    public partial class frmMusicalShow : Form
    {
        public DataTable dtMusical { get; set; }
        public DataTable dtActor { get; set; }
        public string MusicalID { get; set; }
        public string UserID { get; set; }
        public frmMusicalShow()
        {
            InitializeComponent();
            ptbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbDetail.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void btnReserve_Click(object sender, EventArgs e)
        {
            frmReserve1 frm = new frmReserve1(dtMusical);
            frm.UserID = this.UserID;
            frm.Show();
        }

        private void frmMusicalShow_Load(object sender, EventArgs e)
        {
            this.Controls[this.Controls.Count - 1].BackColor = Color.White;

            MusicalDAC dac = new MusicalDAC();
            dtMusical = dac.GetMusical(MusicalID);
            dac.Dispose();

            ActorDAC actor = new ActorDAC();
            dtActor = actor.GetActor(MusicalID);
            dac.Dispose();

            CommonDAC com = new CommonDAC();
            DataTable dtCommon = com.GetCommonCodes("seat", "rate");
            com.Dispose();

            HallDAC hal = new HallDAC();
            DataTable dthall = hal.GetHall(dtMusical.Rows[0]["HallID"].ToString());


            string[] cast = dtActor.Select().Select(x => x["actorName"]).ToArray().Cast<string>().ToArray();

            lblMusicalName.Text = dtMusical.Rows[0]["MusicalName"].ToString();
            lklHall.Text = dthall.Rows[0]["HallName"].ToString();
            lklHall.Tag = dthall.Rows[0]["hallAddress"].ToString();
            lblShowPeriod.Text = dtMusical.Rows[0]["MusicalStartDay"].ToString() + "~" + dtMusical.Rows[0]["MusicalEndDay"].ToString();
            ptbPoster.ImageLocation = dtMusical.Rows[0]["MusicalPoster"].ToString();
            DataRow[] grade = dtCommon.Select($"Code ='{dtMusical.Rows[0]["MusicalGrade"]}'");
            lblGrade.Text = grade[0]["Value"].ToString();
            lblShowTime.Text = dtMusical.Rows[0]["MusicalTime"].ToString().ToString() +"분(인터미션 20분)";
            lblActor.Text = string.Join(", ", cast);
            //가격 정보가져와서 계산, 공통정보 같이 필요
            //배우 목록 보여주기
            //panActor
            ptbDetail.ImageLocation = dtMusical.Rows[0]["MusicalDetail"].ToString();

            DataRow[] price = dtCommon.Select($"Category ='seat'");

            foreach(DataRow p in price)
            {
                if(p["Code"].ToString()=="VIP")
                    lblVIP.Text = (Convert.ToInt32(p["Value"]) * Convert.ToInt32(dtMusical.Rows[0]["MusicalPrice"])/100).ToString();
                else if (p["Code"].ToString() == "R")
                    lblR.Text = (Convert.ToInt32(p["Value"]) * Convert.ToInt32(dtMusical.Rows[0]["MusicalPrice"])/100).ToString();
                else if (p["Code"].ToString() == "S")
                    lblS.Text = (Convert.ToInt32(p["Value"]) * Convert.ToInt32(dtMusical.Rows[0]["MusicalPrice"])/100).ToString();
                else if (p["Code"].ToString() == "A")
                    lblA.Text = (Convert.ToInt32(p["Value"]) * Convert.ToInt32(dtMusical.Rows[0]["MusicalPrice"])/100).ToString();

            }
            

            if(Convert.ToDateTime(dtMusical.Rows[0]["TicketOpenDay"]) > DateTime.Now)
            {
                btnReserve.Text = "예매불가";
                btnReserve.Enabled = false;
            }


        }

        private void lklHall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            lklHall.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start($"https://www.google.com/maps/search/{lklHall.Tag.ToString()}");
        }
    }
}
