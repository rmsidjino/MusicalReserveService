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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvUser);

            DataGridViewUtil.AddGridTextColumn(dgvUser, "유저번호", "UserID", DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "비밀번호", "UserPWD");
            DataGridViewUtil.AddGridTextColumn(dgvUser, "이름", "UserName", colWidth: 200);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "생일", "userBirthDay");
            DataGridViewUtil.AddGridTextColumn(dgvUser, "성별", "userGender");
            DataGridViewUtil.AddGridTextColumn(dgvUser, "핸드폰번호", "UserPhoneNum", colWidth: 200);         
            DataGridViewUtil.AddGridTextColumn(dgvUser, "이메일", "UserEmail");
            DataGridViewUtil.AddGridTextColumn(dgvUser, "주소", "UserAddress");                   
            DataGridViewUtil.AddGridTextColumn(dgvUser, "관리자권한", "IsAdmin");
            DataGridViewUtil.AddGridTextColumn(dgvUser, "생성시간", "createTime");

            DataLoad();
        }

        private void DataLoad()
        {
            UserDAC user = new UserDAC();
            dgvUser.DataSource = user.GetAll().DefaultView;
            user.Dispose();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvUser[0, dgvUser.CurrentRow.Index].Value.ToString();
            txtPwd.Text = dgvUser[1, dgvUser.CurrentRow.Index].Value.ToString();
            txtName.Text = dgvUser[2, dgvUser.CurrentRow.Index].Value.ToString();
            dtpBirthDay.Value = DateTime.Parse(dgvUser[3, dgvUser.CurrentRow.Index].Value.ToString());
            mtxPhone.Text = dgvUser[5, dgvUser.CurrentRow.Index].Value.ToString().Replace("-"," ");
            cboGender.SelectedIndex = cboGender.Items.IndexOf(dgvUser[4, dgvUser.CurrentRow.Index].Value.ToString());

            string[] email = dgvUser[6, dgvUser.CurrentRow.Index].Value.ToString().Split('@');
            txtEmail1.Text = email[0].Trim('@');
            txtEmail2.Text = email[1];
            zipControl1.ZipCode = dgvUser["UserAddress", dgvUser.CurrentRow.Index].Value.ToString().Substring(0, 4);
            zipControl1.Address1 = dgvUser["UserAddress", dgvUser.CurrentRow.Index].Value.ToString().Split(')')[0].Substring(5);
            zipControl1.Address2 = dgvUser["UserAddress", dgvUser.CurrentRow.Index].Value.ToString().Split(')')[1];
            cboManager.SelectedIndex = cboManager.Items.IndexOf(dgvUser["IsAdmin", dgvUser.CurrentRow.Index].Value.ToString());

        }
    }
}
