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
    public partial class frmLogin : Form
    {
        public User LoginUser { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }
            //입력된 아이디와 비밀번호를 DB에 전달해서, 유효한 로그인인지 체크
            UserDAC dac = new UserDAC();
            User loginUser = dac.Login(txtId.Text);
            dac.Dispose();
            if (loginUser == null)
            {
                MessageBox.Show("등록된 아이디가 아닙니다. 회원가입을 해주십시오.");
            }
            else if (loginUser.UserPWD != txtPwd.Text)
            {
                MessageBox.Show("비밀번호를 다시 입력하여 주십시오.");
            }
            else
            {
                this.LoginUser = loginUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void bthSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFindPWD frm = new frmFindPWD();
            frm.ShowDialog();
        }
    }
}
