using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMusical
{

    public partial class frmMyPage : Form
    {
        public User CurrentUser { get; set; }
        public frmMyPage()
        {
            InitializeComponent();
        }

        private void dgvReserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMyPage_Load(object sender, EventArgs e)
        {
            txtUserID.Text = CurrentUser.UserID;
            txtPwd.Text = CurrentUser.UserPWD;
            txtName.Text = CurrentUser.UserName;
            dtpBirthDay.Value = DateTime.Parse(CurrentUser.UserBirthDay);
            mtxPhone.Text = CurrentUser.UserPhoneNum.Replace("-", "");
            cboGender.SelectedIndex = cboGender.Items.IndexOf(CurrentUser.UserGender);

            string[] email = CurrentUser.UserEmail.Split('@');
            txtEmail1.Text = email[0].Trim('@');
            txtEmail2.Text = email[1];
            zipControl1.ZipCode = CurrentUser.UserAddress.Substring(0, 4);
            zipControl1.Address1 = CurrentUser.UserAddress.Split(')')[0].Substring(5);
            zipControl1.Address2 = CurrentUser.UserAddress.Split(')')[1];        

            DataGridViewUtil.SetInitGridView(dgvReserve);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.ValueType = typeof(bool);
            chk.HeaderText = "예매취소";
            chk.Width = 60;
            dgvReserve.Columns.Add(chk);
            dgvReserve.RowHeadersVisible = false;
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약번호", "seatCode", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "뮤지컬코드", "musicalTimeID", DataGridViewContentAlignment.MiddleCenter, colWidth: 60, visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "뮤지컬이름", "MusicalName", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "날짜", "MusicalDay", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "시간", "MusicalTime", DataGridViewContentAlignment.MiddleCenter, colWidth: 40);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "좌석번호", "seatNum", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "좌석등급", "seatGrade", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "할인정보", "discount", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약시간", "registerTime", colWidth: 150);
            DataLoad();

            dgvReserve.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvReserve.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void DataLoad()
        {
            SeatDAC dac = new SeatDAC();
            DataTable reserve = dac.GetUserSeat(CurrentUser.UserID);
            dac.Dispose();
            dgvReserve.DataSource = reserve;
        }

        private void cancelReserve()
        {

        }

        private void btnReserveCancel_Click(object sender, EventArgs e)
        {
            List<int> cancelSeat = new List<int>();
            var checkedRows = dgvReserve.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells[0].Value) == true).Select(x => x.Cells["seatCode"]);
            foreach (DataGridViewCell cell in checkedRows)
            {
                cancelSeat.Add(Convert.ToInt32(cell.Value));
            }

            if(MessageBox.Show(string.Join("번 ",cancelSeat) +"번 좌석을 정말로 취소하시겠습니까?","예매티켓 삭제",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SeatDAC dac = new SeatDAC();
                bool dResult = dac.Delete(cancelSeat);
                dac.Dispose();
                if (dResult)
                    MessageBox.Show("취소가 완료되었습니다");
            }
            DataLoad();



        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
