
namespace WindowsFormsAppMusical
{
    partial class frmHallInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zipControl1 = new WindowsFormsAppMusical.Controls.ZipControl();
            this.btnMainHall = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSeatRegister = new System.Windows.Forms.Button();
            this.btnHallImage = new System.Windows.Forms.Button();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHallID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHall = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zipControl1);
            this.groupBox1.Controls.Add(this.btnMainHall);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnSeatRegister);
            this.groupBox1.Controls.Add(this.btnHallImage);
            this.groupBox1.Controls.Add(this.txtHallName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHallID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(505, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 492);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "공연장 정보";
            // 
            // zipControl1
            // 
            this.zipControl1.Address1 = "";
            this.zipControl1.Address2 = "";
            this.zipControl1.Location = new System.Drawing.Point(154, 108);
            this.zipControl1.Name = "zipControl1";
            this.zipControl1.Size = new System.Drawing.Size(253, 85);
            this.zipControl1.TabIndex = 39;
            this.zipControl1.ZipCode = "";
            // 
            // btnMainHall
            // 
            this.btnMainHall.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMainHall.Location = new System.Drawing.Point(351, 399);
            this.btnMainHall.Name = "btnMainHall";
            this.btnMainHall.Size = new System.Drawing.Size(100, 22);
            this.btnMainHall.TabIndex = 38;
            this.btnMainHall.Text = "대표이미지설정";
            this.btnMainHall.UseVisualStyleBackColor = true;
            this.btnMainHall.Click += new System.EventHandler(this.btnMainHall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(154, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 148);
            this.listBox1.TabIndex = 36;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btnSeatRegister
            // 
            this.btnSeatRegister.Location = new System.Drawing.Point(154, 199);
            this.btnSeatRegister.Name = "btnSeatRegister";
            this.btnSeatRegister.Size = new System.Drawing.Size(100, 21);
            this.btnSeatRegister.TabIndex = 34;
            this.btnSeatRegister.Text = "좌석 정보 등록";
            this.btnSeatRegister.UseVisualStyleBackColor = true;
            this.btnSeatRegister.Click += new System.EventHandler(this.btnSeatRegister_Click);
            // 
            // btnHallImage
            // 
            this.btnHallImage.Location = new System.Drawing.Point(237, 400);
            this.btnHallImage.Name = "btnHallImage";
            this.btnHallImage.Size = new System.Drawing.Size(100, 21);
            this.btnHallImage.TabIndex = 30;
            this.btnHallImage.Text = "이미지 등록";
            this.btnHallImage.UseVisualStyleBackColor = true;
            this.btnHallImage.Click += new System.EventHandler(this.btnHallImage_Click);
            // 
            // txtHallName
            // 
            this.txtHallName.Location = new System.Drawing.Point(154, 76);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(100, 21);
            this.txtHallName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "공연장 이미지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "공연장 ID";
            // 
            // txtHallID
            // 
            this.txtHallID.Location = new System.Drawing.Point(154, 41);
            this.txtHallID.Name = "txtHallID";
            this.txtHallID.Size = new System.Drawing.Size(100, 21);
            this.txtHallID.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(286, 433);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(196, 433);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(74, 34);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "조회";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(105, 433);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 34);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "등록";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "공연장 좌석 배치";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "공연장 위치";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "공연장 이름";
            // 
            // dgvHall
            // 
            this.dgvHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHall.Location = new System.Drawing.Point(21, 12);
            this.dgvHall.Name = "dgvHall";
            this.dgvHall.RowTemplate.Height = 23;
            this.dgvHall.Size = new System.Drawing.Size(457, 491);
            this.dgvHall.TabIndex = 4;
            this.dgvHall.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHall_CellDoubleClick);
            // 
            // frmHallInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHall);
            this.Name = "frmHallInfo";
            this.Text = "공연장정보관리";
            this.Load += new System.EventHandler(this.frmHallInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHallImage;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHallID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHall;
        private System.Windows.Forms.Button btnSeatRegister;
        private System.Windows.Forms.Button btnMainHall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private Controls.ZipControl zipControl1;
    }
}