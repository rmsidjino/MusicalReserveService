using MySql.Data.MySqlClient;
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
    public partial class frmActorInfo : Form
    {
        public string currentFileName { get; set; }
        public frmActorInfo()
        {
            InitializeComponent();
        }

        private void btnImageInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtActorId.Text))
            {
                MessageBox.Show("이미지를 넣을 배우를 먼저 선택해주세요.");
                return;
            }

            frmImageRegister frm = new frmImageRegister(txtActorId.Text,txtActorName.Text, "Actor");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.currentFileName = frm.destFileName;
                ptbActor.ImageLocation = currentFileName;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtActorId.Enabled == false)
            {
                txtActorId.Clear();
                txtActorName.Clear();
                txtActorAge.Clear();
                //currentFileName = null;
                ptbActor.Dispose();
                txtActorId.Enabled = true;
                return;
            }

            if(!string.IsNullOrWhiteSpace(txtActorId.Text) && !string.IsNullOrWhiteSpace(txtActorAge.Text) && !string.IsNullOrWhiteSpace(txtActorName.Text) && ptbActor.Image != null)
            {
                Actor actor = new Actor()
                {
                    ActorID = txtActorId.Text,
                    ActorName = txtActorName.Text,
                    ActorAge = Convert.ToInt32(txtActorAge.Text),
                    ActorImgFileName = currentFileName
                };

                ActorDAC dac = new ActorDAC();  //DB에 파일경로 저장
                bool bResult = dac.Insert(actor);
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
            else
            {
                MessageBox.Show("입력 더 해");
            }
            
            
            
        }

        private void frmActorInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvActor);

            DataGridViewUtil.AddGridTextColumn(dgvActor, "배우번호", "ActorID", DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvActor, "배우명", "ActorName", colWidth: 200);
            DataGridViewUtil.AddGridTextColumn(dgvActor, "배우나이", "ActorAge", colWidth: 200);
            DataGridViewUtil.AddGridTextColumn(dgvActor, "파일경로", "ActorImgFileName", visibility: false);

            ptbActor.SizeMode = PictureBoxSizeMode.StretchImage;
            DataLoad();
        }

        private void DataLoad()
        {
            ActorDAC actor = new ActorDAC();
            dgvActor.DataSource = actor.GetActor().DefaultView;
            actor.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtActorId.Text != null && txtActorAge.Text != null && txtActorName.Text != null)
            {
                Actor actor = new Actor()
                {
                    ActorID = txtActorId.Text,
                    ActorName = txtActorName.Text,
                    ActorAge = Convert.ToInt32(txtActorAge.Text),
                    ActorImgFileName = currentFileName
                };

                ActorDAC dac = new ActorDAC();  //DB에 파일경로 저장
                int bResult = dac.UpdateActor(actor);
                dac.Dispose();

                if (bResult > 0)
                {
                    DataLoad();
                    MessageBox.Show("홀정보가 변경되었습니다.");
                }
                else
                {
                    MessageBox.Show("업데이트를 실패했습니다");
                }
            }
            else
            {
                MessageBox.Show("입력 더 해");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 삭제하실겁니까?", "공연장 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActorDAC dac = new ActorDAC();
                int iResult = dac.DeleteActor(txtActorId.Text);
                dac.Dispose();

                if (iResult > 0)
                {
                    DataLoad();
                    MessageBox.Show("홀정보가 삭제되었습니다. 뮤지컬에서 홀 정보를 변경해주세요");
                }
            }
        }

        private void dgvActor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActorId.Enabled = false;
            txtActorId.Text = dgvActor["actorID", e.RowIndex].Value.ToString();
            txtActorName.Text = dgvActor["actorName", e.RowIndex].Value.ToString();
            txtActorAge.Text = dgvActor["actorAge", e.RowIndex].Value.ToString();

            currentFileName = dgvActor["actorImgFileName", e.RowIndex].Value.ToString();

            ptbActor.ImageLocation = currentFileName;
        }
    }
}
