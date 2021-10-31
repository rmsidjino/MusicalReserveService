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

    public partial class frmMusicalInfo : Form
    {
        public string posterFileName { get; set; }
        public string detailFileName { get; set; }

        private IList<string> _Actors = new List<string>();
        public IList<string> Actors
        {
            get { return _Actors; }
            set { _Actors = value; }
        }

        List<DateTime> dateTimes = new List<DateTime>();

        public frmMusicalInfo()
        {
            InitializeComponent();
        }

        private void frmMusicalInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvMusical);

            DataGridViewUtil.AddGridTextColumn(dgvMusical, "뮤지컬번호", "MusicalID", DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "뮤지컬이름", "MusicalName", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "시작날짜", "MusicalStartDay", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "끝날짜", "MusicalEndDay", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "오픈날짜", "ticketOpenDay", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "등급", "MusicalGrade", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "포스터", "MusicalPoster", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "상세정보", "MusicalDetail", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "가격", "MusicalPrice", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "공연장", "HallID", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvMusical, "관람시간", "MusicalTime", colWidth: 100);


            DataLoad();

            string[] codes = { "rate" };
            CommonDAC dac = new CommonDAC();
            DataTable rate = dac.GetCommonCodes("rate");
            cboGrade.DataSource = rate;
            cboGrade.DisplayMember = "Value";
            cboGrade.ValueMember = "Code";
            cboGrade.SelectedIndex = 0;
            dac.Dispose();

            HallDAC hDac = new HallDAC();
            DataTable dtHall = hDac.GetHall();
            cboHall.DataSource = dtHall;
            cboHall.DisplayMember = "hallName";
            cboHall.ValueMember = "hallId";
            dac.Dispose();


            DataGridViewUtil.SetInitGridView(dgvTime);
            DataGridViewUtil.AddGridTextColumn(dgvTime, "요일", "Day", DataGridViewContentAlignment.MiddleCenter, colWidth: 60);
            DataGridViewUtil.AddGridTextColumn(dgvTime, "시간", "Time", colWidth: 60 );
            dgvTime.RowHeadersVisible = false;


        }

        private void DataLoad()
        {
            MusicalDAC musical = new MusicalDAC();
            dgvMusical.DataSource = musical.GetMusical().DefaultView;
            musical.Dispose();
        }

        private void btnAddMuscialTime_Click(object sender, EventArgs e)
        {
            dgvTime.Rows.Add(cboDay.SelectedItem.ToString(), dtpTime.Value.ToString("HH:mm"));
        }

        private void btnDeleteTime_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTime.Rows.Count; i++)
            {
                //행 선택 여부
                dgvTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (dgvTime.Rows[i].Selected == true)
                {
                    //현재 선택된 인덱스에 해당된 Row 삭제
                    dgvTime.Rows.Remove(dgvTime.Rows[i]);
                }
            }
        }

        private void btnAddPoster_Click(object sender, EventArgs e)
        {
            frmImageRegister frm = new frmImageRegister(txtMusicalID.Text, txtMusicalName.Text,"Musical");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.posterFileName = frm.destFileName;
            }
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            frmActorAdd frm = new frmActorAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Actors = frm.Actors;
                lblActor.Text = string.Join(", ", Actors);
            }

        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmImageRegister frm = new frmImageRegister(txtMusicalID.Text, txtMusicalName.Text,"Musical");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.detailFileName = frm.destFileName;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime(2017, 03, 02);
            //MessageBox.Show(dt.DayOfWeek.ToString());



            //MessageBox.Show(times[0][1].ToString());


            Musical musical = new Musical()
            {
                MusicalID = txtMusicalID.Text,
                MusicalName = txtMusicalName.Text,
                MusicalStartDay = dtpMusicalStart.Value.ToString("yyyy-MM-dd"),
                MusicalEndDay = dtpMusicalEnd.Value.ToString("yyyy-MM-dd"),
                TicketOpenDay = dtpTicketOpen.Value.ToString("yyyy-MM-dd"),
                MusicalTime = int.Parse(txtPerformTime.Text),
                MusicalGrade = cboGrade.SelectedValue.ToString(),
                MusicalPoster = posterFileName,
                MusicalDetail = detailFileName,
                MusicalPrice = int.Parse(txtPrice.Text),
                HallID = cboHall.SelectedValue.ToString()
            };

            

            MusicalDAC dac = new MusicalDAC();  //DB에 파일경로 저장
            bool bResult = dac.Insert(musical);
            bool aResult = dac.AddActor(musical.MusicalID, Actors);
            dac.Dispose();

            if (dgvTime.Rows.Count > 0)
            {
                dateTimes.Clear();
                MakeDateTime();
                MusicalTimeDAC timeDac = new MusicalTimeDAC();
                bool tResult = timeDac.Insert(musical.MusicalID, dateTimes);
                timeDac.Dispose();
                if(tResult == true)
                {
                    dgvTime.Rows.Clear();
                    MessageBox.Show("시간 등록을 성공했습니다");
                }
            }
            



            if (bResult == true)
            {
                MessageBox.Show(Properties.Resources.MSG_SAVE_OK);
                DataLoad();

                txtMusicalID.Text = null;
                txtMusicalName.Text = null;
                txtPerformTime.Text = null;
                posterFileName = null;
                detailFileName = null;
                txtPrice.Text = null;
                dgvTime.Rows.Clear();
            }
            else
            {
                MessageBox.Show("등록을 실패했습니다");
            }


            
        }

        private void dgvTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<DateTime> getDateTime(string startDate, string endDate, List<string[]> times)
        {          
            DateTime dtStartDate =  Convert.ToDateTime(startDate);
            DateTime dtEndDate = Convert.ToDateTime(endDate);

            while (dtStartDate < dtEndDate)
            {
                for (int i = 0; i < times.Count; i++)
                {
                    if (dtStartDate.DayOfWeek == GetDayOfWeek(times[i][0].ToString()))
                    {
                        string[] time = times[i][1].Split(':');
                        TimeSpan ts = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), 0);
                        dtStartDate = dtStartDate + ts;
                        dateTimes.Add(dtStartDate);
                        dtStartDate = dtStartDate - ts;
                    }
                }
                dtStartDate = dtStartDate.AddDays(1);
            }

            return dateTimes;
        }

        private DayOfWeek GetDayOfWeek(string day)
        {
            if (day == "일")
                return DayOfWeek.Sunday;
            else if (day == "월")
                return DayOfWeek.Monday;
            else if (day == "화")
                return DayOfWeek.Tuesday;
            else if (day == "수")
                return DayOfWeek.Wednesday;
            else if (day == "목")
                return DayOfWeek.Thursday;
            else if (day == "금")
                return DayOfWeek.Friday;
            else
                return DayOfWeek.Saturday;

        }

        private void MakeDateTime()
        {
            List<string[]> times = new List<string[]>();

            for (int i = 0; i < dgvTime.RowCount; i++)
            {
                string[] time = { dgvTime.Rows[i].Cells[0].Value.ToString(), dgvTime.Rows[i].Cells[1].Value.ToString() };
                times.Add(time);
            }

            dateTimes = getDateTime(dtpMusicalStart.Value.ToString("yyyy-MM-dd"), dtpMusicalEnd.Value.ToString("yyyy-MM-dd"), times);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicalDAC dac = new MusicalDAC();
            bool aResult = dac.AddActor("hardes", Actors);
        }

        private void dgvMusical_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusicalID.Text = dgvMusical["MusicalID", e.RowIndex].Value.ToString();
            txtMusicalName.Text = dgvMusical["MusicalName", e.RowIndex].Value.ToString();
            dtpMusicalStart.Value = DateTime.Parse(dgvMusical["MusicalStartDay", e.RowIndex].Value.ToString());
            dtpMusicalEnd.Value = DateTime.Parse(dgvMusical["MusicalEndDay", e.RowIndex].Value.ToString());
            dtpTicketOpen.Value = DateTime.Parse(dgvMusical["TicketOpenDay", e.RowIndex].Value.ToString());
            cboGrade.SelectedValue = dgvMusical["MusicalGrade", e.RowIndex].Value.ToString();


            txtPrice.Text = dgvMusical["MusicalPrice", e.RowIndex].Value.ToString();
            txtMusicalName.Text = dgvMusical["MusicalName", e.RowIndex].Value.ToString();


            cboHall.SelectedValue = dgvMusical["HallID", e.RowIndex].Value.ToString();
            posterFileName = dgvMusical["MusicalPoster", e.RowIndex].Value.ToString();
            detailFileName = dgvMusical["MusicalDetail", e.RowIndex].Value.ToString();

            txtPerformTime.Text = dgvMusical["MusicalTime", e.RowIndex].Value.ToString();


            ActorDAC dac = new ActorDAC();
            DataTable dtActor = dac.GetActor(dgvMusical["MusicalID", e.RowIndex].Value.ToString());
            dac.Dispose();


            string[] actor = dtActor.Select().Select(x => x["actorName"]).ToArray().Cast<string>().ToArray();
            lblActor.Text = string.Join(", ",actor);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (dgvTime.Rows.Count > 0)
            {
                dateTimes.Clear();
                MakeDateTime();
                MusicalTimeDAC timeDac = new MusicalTimeDAC();
                bool tResult = timeDac.Insert(txtMusicalID.Text, dateTimes);
                if (tResult == true)
                {
                    dgvTime.Rows.Clear();
                    MessageBox.Show("시간 등록을 성공했습니다");
                }
                else
                {
                    MessageBox.Show("실패~~");
                }
            }
            
        }
    }
}
