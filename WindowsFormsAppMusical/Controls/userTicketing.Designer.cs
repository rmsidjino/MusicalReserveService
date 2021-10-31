
namespace WindowsFormsAppMusical.Controls
{
    partial class userTicketing
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMusicalName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblShowDay = new System.Windows.Forms.Label();
            this.lblReserveDay = new System.Windows.Forms.Label();
            this.lblSeatNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(486, 9);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 23);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "lblPrice";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblMusicalName
            // 
            this.lblMusicalName.Location = new System.Drawing.Point(83, 9);
            this.lblMusicalName.Name = "lblMusicalName";
            this.lblMusicalName.Size = new System.Drawing.Size(105, 23);
            this.lblMusicalName.TabIndex = 8;
            this.lblMusicalName.Text = "lblMusicalName";
            this.lblMusicalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMusicalName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-14, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblShowDay
            // 
            this.lblShowDay.Location = new System.Drawing.Point(194, 9);
            this.lblShowDay.Name = "lblShowDay";
            this.lblShowDay.Size = new System.Drawing.Size(81, 23);
            this.lblShowDay.TabIndex = 12;
            this.lblShowDay.Text = "lblShowDay";
            this.lblShowDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReserveDay
            // 
            this.lblReserveDay.Location = new System.Drawing.Point(294, 12);
            this.lblReserveDay.Name = "lblReserveDay";
            this.lblReserveDay.Size = new System.Drawing.Size(81, 23);
            this.lblReserveDay.TabIndex = 13;
            this.lblReserveDay.Text = "lblReserveDay";
            this.lblReserveDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeatNum
            // 
            this.lblSeatNum.Location = new System.Drawing.Point(408, 9);
            this.lblSeatNum.Name = "lblSeatNum";
            this.lblSeatNum.Size = new System.Drawing.Size(81, 23);
            this.lblSeatNum.TabIndex = 14;
            this.lblSeatNum.Text = "lblSeatNum";
            this.lblSeatNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userTicketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeatNum);
            this.Controls.Add(this.lblReserveDay);
            this.Controls.Add(this.lblShowDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMusicalName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "userTicketing";
            this.Size = new System.Drawing.Size(649, 44);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMusicalName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblShowDay;
        private System.Windows.Forms.Label lblReserveDay;
        private System.Windows.Forms.Label lblSeatNum;
    }
}
