
namespace WindowsFormsAppMusical
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userMenu = new System.Windows.Forms.MenuStrip();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.마이페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblHot = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.managerMenu = new System.Windows.Forms.MenuStrip();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배우관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공연장관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.뮤지컬관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예매관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예매차트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucTabControl1 = new WindowsFormsAppMusical.ucTabControl();
            this.userMenu.SuspendLayout();
            this.managerMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMenu
            // 
            this.userMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.홈ToolStripMenuItem,
            this.마이페이지ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
            this.userMenu.Location = new System.Drawing.Point(0, 24);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(1051, 24);
            this.userMenu.TabIndex = 0;
            this.userMenu.Text = "menuStrip1";
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.홈ToolStripMenuItem.Text = "홈";
            this.홈ToolStripMenuItem.Click += new System.EventHandler(this.홈ToolStripMenuItem_Click);
            // 
            // 마이페이지ToolStripMenuItem
            // 
            this.마이페이지ToolStripMenuItem.Name = "마이페이지ToolStripMenuItem";
            this.마이페이지ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.마이페이지ToolStripMenuItem.Tag = "frmMyPage";
            this.마이페이지ToolStripMenuItem.Text = "마이페이지";
            this.마이페이지ToolStripMenuItem.Click += new System.EventHandler(this.마이페이지ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(102, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 281);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(102, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 281);
            this.panel2.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHot.Location = new System.Drawing.Point(411, 15);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(189, 32);
            this.lblHot.TabIndex = 4;
            this.lblHot.Text = "What\'s Hot";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOpen.Location = new System.Drawing.Point(402, 351);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(207, 32);
            this.lblOpen.TabIndex = 5;
            this.lblOpen.Text = "Ticket Open";
            // 
            // managerMenu
            // 
            this.managerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.배우관리ToolStripMenuItem,
            this.공연장관리ToolStripMenuItem,
            this.뮤지컬관리ToolStripMenuItem,
            this.예매관리ToolStripMenuItem,
            this.예매차트ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem2});
            this.managerMenu.Location = new System.Drawing.Point(0, 0);
            this.managerMenu.Name = "managerMenu";
            this.managerMenu.Size = new System.Drawing.Size(1051, 24);
            this.managerMenu.TabIndex = 7;
            this.managerMenu.Text = "menuStrip2";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회원관리ToolStripMenuItem.Tag = "frmUserInfo";
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 배우관리ToolStripMenuItem
            // 
            this.배우관리ToolStripMenuItem.Name = "배우관리ToolStripMenuItem";
            this.배우관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.배우관리ToolStripMenuItem.Tag = "frmActorInfo";
            this.배우관리ToolStripMenuItem.Text = "배우관리";
            this.배우관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 공연장관리ToolStripMenuItem
            // 
            this.공연장관리ToolStripMenuItem.Name = "공연장관리ToolStripMenuItem";
            this.공연장관리ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.공연장관리ToolStripMenuItem.Tag = "frmHallInfo";
            this.공연장관리ToolStripMenuItem.Text = "공연장관리";
            this.공연장관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 뮤지컬관리ToolStripMenuItem
            // 
            this.뮤지컬관리ToolStripMenuItem.Name = "뮤지컬관리ToolStripMenuItem";
            this.뮤지컬관리ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.뮤지컬관리ToolStripMenuItem.Tag = "frmMusicalInfo";
            this.뮤지컬관리ToolStripMenuItem.Text = "뮤지컬관리";
            this.뮤지컬관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 예매관리ToolStripMenuItem
            // 
            this.예매관리ToolStripMenuItem.Name = "예매관리ToolStripMenuItem";
            this.예매관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.예매관리ToolStripMenuItem.Tag = "frmReserveInfo";
            this.예매관리ToolStripMenuItem.Text = "예매관리";
            this.예매관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 예매차트ToolStripMenuItem
            // 
            this.예매차트ToolStripMenuItem.Name = "예매차트ToolStripMenuItem";
            this.예매차트ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.예매차트ToolStripMenuItem.Tag = "frmChart";
            this.예매차트ToolStripMenuItem.Text = "예매차트";
            this.예매차트ToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem2
            // 
            this.로그아웃ToolStripMenuItem2.Name = "로그아웃ToolStripMenuItem2";
            this.로그아웃ToolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.로그아웃ToolStripMenuItem2.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem2.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblHot);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblOpen);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 695);
            this.panel3.TabIndex = 11;
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ucTabControl1.Location = new System.Drawing.Point(0, 48);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(1051, 25);
            this.ucTabControl1.TabIndex = 9;
            this.ucTabControl1.SelectedIndexChanged += new System.EventHandler(this.ucTabControl1_SelectedIndexChanged);
            this.ucTabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucTabControl1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucTabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userMenu);
            this.Controls.Add(this.managerMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.managerMenu;
            this.Name = "frmMain";
            this.Text = "예스24뮤지컬에 오신 것을 환영합니다";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.userMenu.ResumeLayout(false);
            this.userMenu.PerformLayout();
            this.managerMenu.ResumeLayout(false);
            this.managerMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip userMenu;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 마이페이지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblHot;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.MenuStrip managerMenu;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공연장관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 뮤지컬관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배우관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem2;
        private ucTabControl ucTabControl1;
        private System.Windows.Forms.ToolStripMenuItem 예매관리ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem 예매차트ToolStripMenuItem;
    }
}