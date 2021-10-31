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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            cboEmail.SelectedIndex = 0;  // -1을 하면 아무것도 안 보임
            txtEmail2.Visible = false;
            cboEmail.Location = txtEmail2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.UserID = txtUserID.Text;
            newUser.UserName = txtUserName.Text;
            newUser.UserPWD = txtPWD.Text;
            newUser.UserBirthDay = dtpBirthDay.Value.ToString("yyyy-MM-dd");
            if (rboMan.Checked)
                newUser.UserGender = rboMan.Text;
            else
                newUser.UserGender = rboWoman.Text;
            newUser.UserPhoneNum = mtxPhone.Text;
            if (txtEmail2.Visible)
                newUser.UserEmail = $"{txtEmail1.Text}@{txtEmail2.Text}";
            else
                newUser.UserEmail = $"{txtEmail1.Text}@{cboEmail.Text}";
            newUser.UserAddress = zipControl1.ZipCode + zipControl1.Address1 + zipControl1.Address2;

            UserDAC user = new UserDAC();
            int userID = user.Insert(newUser);
            if (userID > 0)
                user.Dispose();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //폼과 폼의 데이터 전달 
            frmIDCheckPopup frm = new frmIDCheckPopup();
            frm.UserID = txtUserID.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUserID.Text = frm.UserID;
                txtUserID.Enabled = false;
            }
        }


        private void cboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEmail.Text == "직접입력")
            {
                txtEmail2.Visible = true;
                cboEmail.Location = new Point(620, 223);
                txtEmail2.Focus();
            }
            else
            {
                txtEmail2.Visible = false;
                cboEmail.Location = txtEmail2.Location;
            }
        }

    }
}
