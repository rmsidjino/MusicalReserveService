using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppMusical
{
    public partial class frmIDCheckPopup : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

        bool bCheck = false;
        public string UserID
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public frmIDCheckPopup()
        {
            InitializeComponent();
        }

        public frmIDCheckPopup(string userID)
        {
            InitializeComponent();
            textBox1.Text = userID;
        }

        private void frmIDCheckPopup_Load(object sender, EventArgs e)
        {
            //Form1 frm = (Form1)this.Owner;
            //textBox1.Text = frm.txtUserID.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("사용하실 아이디를 입력하세요");
                return;
            }
            string sql = "select count(*) from userInfo where userID = @userID;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@userID", textBox1.Text);
            conn.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar()); // select 결과가 하나의 값일 때, 행이 한개여도 여러개의 칼럼이면 X, reader로 가리키는게 아니라 값을 반환
            conn.Close();

            if (cnt > 0)
            {
                label1.Text = "이미 사용중인 아이디입니다.";
                bCheck = false;
            }
            else
            {
                label1.Text = "사용 가능한 아이디입니다.";
                bCheck = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bCheck)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("사용자ID 중복체크를 다시 하시기 바랍니다");
            }
        }
    }
}
