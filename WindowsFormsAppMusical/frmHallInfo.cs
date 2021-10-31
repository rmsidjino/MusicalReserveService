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
    public partial class frmHallInfo : Form
    {
        DataTable dtImage;
        public string currentFileName { get; set; }
        public int VIP { get; set; }
        public int R { get; set; }
        public int S { get; set; }
        public int A { get; set; }

        public frmHallInfo()
        {
            InitializeComponent();
        }

        private void btnHallImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHallID.Text))
            {
                MessageBox.Show("이미지를 넣을 공연장를 먼저 선택해주세요.");
                return;
            }

            frmImageRegister frm = new frmImageRegister(txtHallID.Text, txtHallName.Text, "Hall");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //
                this.currentFileName = frm.destFileName;
                HallDAC dac = new HallDAC();
                dac.UpdateImage(txtHallID.Text, currentFileName);
                BindHallImageList();

            }
        }

        private void BindHallImageList()
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;

            HallDAC dac = new HallDAC();
            dtImage = dac.GetHallImage(txtHallID.Text);
            dac.Dispose();

            if (dtImage != null)
            {
                foreach (DataRow dr in dtImage.Rows)
                {
                    listBox1.Items.Add(dr["hallImgFileName"].ToString());
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string filePath = listBox1.SelectedItems[0].ToString();
                pictureBox1.ImageLocation = filePath;
            }
        }



        private int GetSelectImageID()
        {
            string filepath = listBox1.SelectedItems[0].ToString();
            DataRow[] rows = dtImage.Select($"hallImgFileName='{filepath}'");
            if (rows.Length > 0)
            {
                return Convert.ToInt32(rows[0]["hallImageID"]);
            }
            else
                return -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall()
            {
                HallID = txtHallID.Text,
                HallName = txtHallName.Text,             
                HallAddress = zipControl1.ZipCode + zipControl1.Address1 + zipControl1.Address2,
                VIP = VIP,
                R=R,
                S=S,
                A=A
            };

            HallDAC dac = new HallDAC();  //DB에 파일경로 저장
            bool bResult = dac.Insert(hall);
            dac.Dispose();

            if (bResult == true)
            {
                MessageBox.Show("등록을 성공했습니다");
                DataLoad();
            }
            else
            {
                MessageBox.Show("등록을 실패했습니다");
            }


        }

        private void btnSeatRegister_Click(object sender, EventArgs e)
        {
            frmSeatMake frm = new frmSeatMake(VIP,R,S,A);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                this.VIP = frm.VIP;
                this.R = frm.R;
                this.S = frm.S;
                this.A = frm.A;

            }
        }

        private void frmHallInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvHall);

            DataGridViewUtil.AddGridTextColumn(dgvHall, "공연장번호", "hallID", DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "공연장이름", "hallName", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "공연장주소", "hallAddress", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "VIP", "VIP", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "R", "R", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "S", "S", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvHall, "A", "A", colWidth: 100);

            DataLoad();
        }

        private void DataLoad()
        {
            HallDAC hall = new HallDAC();
            dgvHall.DataSource = hall.GetHall().DefaultView;
            hall.Dispose();
        }

        private void dgvHall_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHallID.Enabled = false;
            txtHallID.Text = dgvHall["hallID", e.RowIndex].Value.ToString();
            txtHallName.Text = dgvHall["hallName", e.RowIndex].Value.ToString();
            zipControl1.ZipCode = dgvHall["hallAddress", e.RowIndex].Value.ToString().Substring(0, 4);
            zipControl1.Address1 = dgvHall["hallAddress", e.RowIndex].Value.ToString().Split(')')[0].Substring(5);
            zipControl1.Address2 = dgvHall["hallAddress", e.RowIndex].Value.ToString().Split(')')[1];
            VIP = Convert.ToInt32(dgvHall["VIP", e.RowIndex].Value.ToString());
            R = Convert.ToInt32(dgvHall["R", e.RowIndex].Value.ToString());
            S = Convert.ToInt32(dgvHall["S", e.RowIndex].Value.ToString());
            A = Convert.ToInt32(dgvHall["A", e.RowIndex].Value.ToString());


            BindHallImageList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnMainHall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHallID.Text) || pictureBox1.Image == null)
            {
                MessageBox.Show("제품과 이미지를 선택해주세요.");
                return;
            }

            if (MessageBox.Show("대표이미지로 설정하시겠습니까?", "이미지확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                int imageID = GetSelectImageID();
                if (imageID > 0)
                {
                    HallDAC dac = new HallDAC();
                    bool bResult = dac.UpdateMainImage(txtHallID.Text, imageID);

                    if (bResult)
                    {
                        MessageBox.Show("대표이미지가 변경되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("대표이미지 변경 중 오류가 발생했습니다. 다시 설정하여 주십시오.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말 삭제하실겁니까?","공연장 삭제",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HallDAC dac = new HallDAC();
                int iResult = dac.DeleteHall(txtHallID.Text);
                dac.Dispose();

                if (iResult > 0)
                {
                    DataLoad();
                    MessageBox.Show("홀정보가 삭제되었습니다. 뮤지컬에서 홀 정보를 변경해주세요");
                }
            }
        }
    }
}
