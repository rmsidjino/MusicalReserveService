using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMusical
{
    public partial class frmMain : Form
    {
        DataTable dtAllList;
        public User CurrentUser { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Controls[this.Controls.Count - 1].BackColor = Color.White;

            ucTabControl1.Visible = false;

            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                //메인화면 코딩 시작
                //로그인 성공한 사람의 권한에 따라서 다르게 메뉴를 보여준다.
                this.CurrentUser = login.LoginUser;

                label1.Text = $"{CurrentUser.UserName}님 환영합니다.";
                if (CurrentUser.IsAdmin == "Y")
                {
                    managerMenu.Visible = true;
                    userMenu.Visible = false;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    lblHot.Visible = false;
                    lblOpen.Visible = false;
                    panel3.Visible = false;
                }
                else
                {
                    managerMenu.Visible = false;
                    userMenu.Visible = true;
                }
            }
            else
            {
                Application.Exit();
            }

            //등록된 뮤지컬목록을 조회
            MusicalDAC dac = new MusicalDAC();
            dtAllList = dac.GetMusical();
            dac.Dispose();

            //전달받은 DataTable로부터 뮤지컬 control 바인딩
            ShowMusicalList(dtAllList);
        }
        private void OpenCreateForm(string prgName)
        {
            // 열려있는 폼들중에서 없으면 새로 만들어서 폼을 보여주고,
            // 이미 열려있는 폼이라면, 활성폼으로 만들어서 제일 앞으로 위치

            string appName = Assembly.GetEntryAssembly().GetName().Name;

            Type frmType = Type.GetType($"{appName}.{prgName}");
            //어셈블리명.클래스명

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == frmType)
                {
                    form.Activate(); //Activate 이벤트
                    form.BringToFront();
                    return;
                }
            }

            Form frm = (Form)Activator.CreateInstance(frmType);
            frm.MdiParent = this;
            frm.Show(); //Load->Activate 이벤트
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            OpenCreateForm(menu.Tag.ToString());
        }
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                ucTabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null)
                {
                    //탭페이지를 추가해서 탭컨트롤에 추가
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "   ");
                    tp.Parent = ucTabControl1;
                    tp.Tag = this.ActiveMdiChild;
                    ucTabControl1.SelectedTab = tp;

                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;

                    this.ActiveMdiChild.Tag = tp;
                }

                if (!ucTabControl1.Visible)
                    ucTabControl1.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            ((TabPage)frm.Tag).Dispose();
        }

        private void ucTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ucTabControl1.SelectedTab != null)
            {
                Form frm = (Form)ucTabControl1.SelectedTab.Tag;
                frm.Select();
            }
        }

        private void ucTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ucTabControl1.TabPages.Count; i++)
            {
                var r = ucTabControl1.GetTabRect(i);
                var closeImage = Properties.Resources.close_grey;
                var closeRect = new Rectangle((r.Right - closeImage.Width), r.Top + (r.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (closeRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == ""
                   || e.Item.Text == "닫기(&C)"
                   || e.Item.Text == "최소화(&N)"
                   || e.Item.Text == "이전 크기로(&R)")
                e.Item.Visible = false;
        }


        private void ShowMusicalList(DataTable dt)
        {           
            int iRows = dt.Rows.Count;
            int idx = 0;
            int idxOpen = 0;
            int idxExpected = 0;
            for (int r = 0; r < iRows; r++)
            {
                if (idx >= dt.Rows.Count) break;

                MusicalControl ctrl = new MusicalControl();              
                ctrl.Size = new Size(170, 240);
                ctrl.MusicalInfo = new Musical()
                {
                    MusicalID = dt.Rows[idx]["musicalID"].ToString(),
                    MusicalName = dt.Rows[idx]["musicalName"].ToString(),
                    MusicalStartDay = dt.Rows[idx]["musicalStartDay"].ToString(),
                    MusicalEndDay = dt.Rows[idx]["musicalEndDay"].ToString(),
                    MusicalPoster = dt.Rows[idx]["musicalPoster"].ToString(),   
                    TicketOpenDay = dt.Rows[idx]["TicketOpenDay"].ToString()

                };
                ctrl.UserID = this.CurrentUser.UserID;
                if(DateTime.Now > DateTime.Parse(dt.Rows[idx]["TicketOpenDay"].ToString()))
                {
                    ctrl.Location = new Point(20 + idxOpen * 210, 10);                   
                    panel1.Controls.Add(ctrl);      
                    idxOpen++;
                }
                else
                {                  
                    ctrl.Location = new Point(20 + idxExpected * 210, 10);
                    panel2.Controls.Add(ctrl);
                    idxExpected++;
                }
                    
                idx++;
            }
        }

        private void 로그아웃ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); // 현재 폼 종료,
            Application.Restart();
        }

        private void 마이페이지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyPage frm = new frmMyPage();
            frm.CurrentUser = this.CurrentUser;
            frm.MdiParent = this;
            frm.Show();
            panel3.Hide();
        }

        private void 홈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            panel3.Show();
        }
    }
}
