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
    public partial class frmFindPWD : Form
    {
        public frmFindPWD()
        {
            InitializeComponent();
        }

        private void btnFindPWD_Click(object sender, EventArgs e)
        {
            //3개의 값을 모두 입력했는지 유효성체크
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("회원아이디, 이름, 이메일을 모두 입력하세요.");
                return;
            }

            //입력한 값으로 회원여부를 확인
            UserDAC dac = new UserDAC();
            bool bFlag = dac.ConfirmUser(txtUserID.Text, txtUserName.Text, txtEmail.Text);
            if (!bFlag)
            {
                MessageBox.Show("회원정보가 없습니다. 다시 확인하여 주십시오.");
                return;
            }

            //회원인 경우 비밀번호를 재생성
            string newPwd = CreatePassword();

            //재생성된 비밀번호를 DB에 update
            bool bResult = dac.UpdatePWD(txtUserID.Text, newPwd);
            if (bResult)
            {
                //재생성된 비밀번호를 메일로 발송
                string subject = $"{txtUserName.Text}님의 비밀번호 초기화 안내 메일입니다.";
                string body = $"{txtUserName.Text}님의 비밀번호는 {newPwd}으로 초기화 되었습니다. 로그인해주십시오.";
                string to = txtEmail.Text;

                CommonUtil.SendMail(subject, body, to);
                MessageBox.Show("비밀번호를 재생성해서 메일로 발송하였습니다. 확인하여 주십시오.");
            }
            else
            {
                MessageBox.Show("비밀번호 찾기 중 오류가 발생했습니다. 다시 시도하여 주십시오..");
            }
        }

        private string CreatePassword()
        {
            StringBuilder sb = new StringBuilder();

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int temp = rnd.Next(0, 36);  //0 ~35 숫자(0~9) 영문자(10~35) A:65
                if (temp < 10)
                    sb.Append(temp);
                else
                    sb.Append((char)(temp + 55));
            }
            return sb.ToString();
        }
    }
}
