
namespace WindowsFormsAppMusical
{
    partial class frmMusicalInfo
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
            this.dtpTicketOpen = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTime = new System.Windows.Forms.DataGridView();
            this.lblActor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteTime = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddMuscialTime = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpMusicalEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpMusicalStart = new System.Windows.Forms.DateTimePicker();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHall = new System.Windows.Forms.ComboBox();
            this.btnAddPoster = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMusicalName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusicalID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMusical = new System.Windows.Forms.DataGridView();
            this.btnTime = new System.Windows.Forms.Button();
            this.txtPrice = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.txtPerformTime = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusical)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTime);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtPerformTime);
            this.groupBox1.Controls.Add(this.dtpTicketOpen);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dgvTime);
            this.groupBox1.Controls.Add(this.lblActor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnDeleteTime);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAddMuscialTime);
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.cboDay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpMusicalEnd);
            this.groupBox1.Controls.Add(this.dtpMusicalStart);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.btnAddDetail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboHall);
            this.groupBox1.Controls.Add(this.btnAddPoster);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddActor);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtMusicalName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMusicalID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(512, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "뮤지컬 정보";
            // 
            // dtpTicketOpen
            // 
            this.dtpTicketOpen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTicketOpen.Location = new System.Drawing.Point(166, 140);
            this.dtpTicketOpen.Name = "dtpTicketOpen";
            this.dtpTicketOpen.Size = new System.Drawing.Size(112, 21);
            this.dtpTicketOpen.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 58;
            this.label13.Text = "티켓 오픈";
            // 
            // dgvTime
            // 
            this.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTime.Location = new System.Drawing.Point(406, 168);
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.RowTemplate.Height = 23;
            this.dgvTime.Size = new System.Drawing.Size(149, 78);
            this.dgvTime.TabIndex = 57;
            this.dgvTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTime_CellContentClick);
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(292, 264);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(41, 12);
            this.lblActor.TabIndex = 56;
            this.lblActor.Text = "출연진";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 54;
            this.label12.Text = "공연 시간";
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.Location = new System.Drawing.Point(307, 225);
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(61, 21);
            this.btnDeleteTime.TabIndex = 53;
            this.btnDeleteTime.Text = "삭제하기";
            this.btnDeleteTime.UseVisualStyleBackColor = true;
            this.btnDeleteTime.Click += new System.EventHandler(this.btnDeleteTime_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "가격";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 50;
            this.label10.Text = "시간";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 49;
            this.label9.Text = "요일";
            // 
            // btnAddMuscialTime
            // 
            this.btnAddMuscialTime.Location = new System.Drawing.Point(240, 225);
            this.btnAddMuscialTime.Name = "btnAddMuscialTime";
            this.btnAddMuscialTime.Size = new System.Drawing.Size(61, 21);
            this.btnAddMuscialTime.TabIndex = 48;
            this.btnAddMuscialTime.Text = "추가하기";
            this.btnAddMuscialTime.UseVisualStyleBackColor = true;
            this.btnAddMuscialTime.Click += new System.EventHandler(this.btnAddMuscialTime_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "\"HH시 mm분\"";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(270, 198);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(98, 21);
            this.dtpTime.TabIndex = 47;
            this.dtpTime.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // cboDay
            // 
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboDay.Location = new System.Drawing.Point(199, 198);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(37, 20);
            this.cboDay.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "~";
            // 
            // dtpMusicalEnd
            // 
            this.dtpMusicalEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMusicalEnd.Location = new System.Drawing.Point(298, 84);
            this.dtpMusicalEnd.Name = "dtpMusicalEnd";
            this.dtpMusicalEnd.Size = new System.Drawing.Size(112, 21);
            this.dtpMusicalEnd.TabIndex = 43;
            // 
            // dtpMusicalStart
            // 
            this.dtpMusicalStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMusicalStart.Location = new System.Drawing.Point(165, 84);
            this.dtpMusicalStart.Name = "dtpMusicalStart";
            this.dtpMusicalStart.Size = new System.Drawing.Size(112, 21);
            this.dtpMusicalStart.TabIndex = 41;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(165, 168);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 20);
            this.cboGrade.TabIndex = 40;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(165, 326);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(121, 23);
            this.btnAddDetail.TabIndex = 39;
            this.btnAddDetail.Text = "상세정보 추가하기";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "상세정보 추가하기";
            // 
            // cboHall
            // 
            this.cboHall.FormattingEnabled = true;
            this.cboHall.Location = new System.Drawing.Point(165, 392);
            this.cboHall.Name = "cboHall";
            this.cboHall.Size = new System.Drawing.Size(121, 20);
            this.cboHall.TabIndex = 37;
            // 
            // btnAddPoster
            // 
            this.btnAddPoster.Location = new System.Drawing.Point(165, 292);
            this.btnAddPoster.Name = "btnAddPoster";
            this.btnAddPoster.Size = new System.Drawing.Size(112, 23);
            this.btnAddPoster.TabIndex = 36;
            this.btnAddPoster.Text = "포스터 추가하기";
            this.btnAddPoster.UseVisualStyleBackColor = true;
            this.btnAddPoster.Click += new System.EventHandler(this.btnAddPoster_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "공연장";
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(165, 258);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(112, 23);
            this.btnAddActor.TabIndex = 34;
            this.btnAddActor.Text = "출연진 추가하기";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(58, 297);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 33;
            this.label25.Text = "포스터";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(58, 263);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 32;
            this.label24.Text = "출연진";
            // 
            // txtMusicalName
            // 
            this.txtMusicalName.Location = new System.Drawing.Point(165, 56);
            this.txtMusicalName.Name = "txtMusicalName";
            this.txtMusicalName.Size = new System.Drawing.Size(100, 21);
            this.txtMusicalName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "관람시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "뮤지컬ID";
            // 
            // txtMusicalID
            // 
            this.txtMusicalID.Location = new System.Drawing.Point(165, 28);
            this.txtMusicalID.Name = "txtMusicalID";
            this.txtMusicalID.Size = new System.Drawing.Size(100, 21);
            this.txtMusicalID.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(311, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(222, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(132, 421);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(74, 34);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "조회";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 421);
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
            this.label6.Location = new System.Drawing.Point(58, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "등급";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "공연 기간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "뮤지컬 이름";
            // 
            // dgvMusical
            // 
            this.dgvMusical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusical.Location = new System.Drawing.Point(26, 22);
            this.dgvMusical.Name = "dgvMusical";
            this.dgvMusical.RowTemplate.Height = 23;
            this.dgvMusical.Size = new System.Drawing.Size(457, 460);
            this.dgvMusical.TabIndex = 4;
            this.dgvMusical.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusical_CellContentDoubleClick);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(480, 138);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 62;
            this.btnTime.Text = "시간 추가";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(165, 361);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 61;
            // 
            // txtPerformTime
            // 
            this.txtPerformTime.Location = new System.Drawing.Point(165, 113);
            this.txtPerformTime.Name = "txtPerformTime";
            this.txtPerformTime.Size = new System.Drawing.Size(100, 21);
            this.txtPerformTime.TabIndex = 60;
            // 
            // frmMusicalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMusical);
            this.Name = "frmMusicalInfo";
            this.Text = "뮤지컬정보관리";
            this.Load += new System.EventHandler(this.frmMusicalInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMusicalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusicalID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMusical;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHall;
        private System.Windows.Forms.Button btnAddPoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddMuscialTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpMusicalEnd;
        private System.Windows.Forms.DateTimePicker dtpMusicalStart;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnDeleteTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.DateTimePicker dtpTicketOpen;
        private System.Windows.Forms.Label label13;
        private Controls.NumTextBox txtPrice;
        private Controls.NumTextBox txtPerformTime;
        private System.Windows.Forms.Button btnTime;
    }
}