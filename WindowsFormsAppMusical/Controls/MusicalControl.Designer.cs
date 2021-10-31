
namespace WindowsFormsAppMusical
{
    partial class MusicalControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMusicalName = new System.Windows.Forms.Label();
            this.lblPlayDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lblMusicalName
            // 
            this.lblMusicalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMusicalName.AutoSize = true;
            this.lblMusicalName.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMusicalName.ForeColor = System.Drawing.Color.White;
            this.lblMusicalName.Location = new System.Drawing.Point(36, 3);
            this.lblMusicalName.Name = "lblMusicalName";
            this.lblMusicalName.Size = new System.Drawing.Size(65, 15);
            this.lblMusicalName.TabIndex = 1;
            this.lblMusicalName.Text = "뮤지컬 이름";
            this.lblMusicalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayDay
            // 
            this.lblPlayDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayDay.AutoSize = true;
            this.lblPlayDay.BackColor = System.Drawing.Color.Black;
            this.lblPlayDay.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlayDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPlayDay.Location = new System.Drawing.Point(44, 24);
            this.lblPlayDay.Name = "lblPlayDay";
            this.lblPlayDay.Size = new System.Drawing.Size(51, 15);
            this.lblPlayDay.TabIndex = 2;
            this.lblPlayDay.Text = "상영기간";
            this.lblPlayDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMusicalName);
            this.panel1.Controls.Add(this.lblPlayDay);
            this.panel1.Location = new System.Drawing.Point(3, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 43);
            this.panel1.TabIndex = 3;
            // 
            // MusicalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusicalControl";
            this.Size = new System.Drawing.Size(176, 239);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMusicalName;
        private System.Windows.Forms.Label lblPlayDay;
        private System.Windows.Forms.Panel panel1;
    }
}
