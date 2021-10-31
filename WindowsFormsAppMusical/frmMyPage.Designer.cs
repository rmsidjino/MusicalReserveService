
namespace WindowsFormsAppMusical
{
    partial class frmMyPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwdCheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReserveCancel = new System.Windows.Forms.Button();
            this.dgvReserve = new System.Windows.Forms.DataGridView();
            this.zipControl1 = new WindowsFormsAppMusical.Controls.ZipControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cboGender.Location = new System.Drawing.Point(112, 182);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(57, 23);
            this.cboGender.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "생일";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(111, 150);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 22);
            this.dtpBirthDay.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "성별";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "이름";
            // 
            // txtPwdCheck
            // 
            this.txtPwdCheck.Location = new System.Drawing.Point(111, 86);
            this.txtPwdCheck.Name = "txtPwdCheck";
            this.txtPwdCheck.Size = new System.Drawing.Size(100, 22);
            this.txtPwdCheck.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "비밀번호 확인";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(111, 54);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "비밀번호";
            // 
            // mtxPhone
            // 
            this.mtxPhone.Location = new System.Drawing.Point(111, 213);
            this.mtxPhone.Mask = "000-9000-0000";
            this.mtxPhone.Name = "mtxPhone";
            this.mtxPhone.Size = new System.Drawing.Size(100, 22);
            this.mtxPhone.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "핸드폰번호";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(111, 22);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "회원ID";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(230, 245);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(100, 22);
            this.txtEmail2.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "@";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(111, 245);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 22);
            this.txtEmail1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "이메일";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.zipControl1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cboGender);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpBirthDay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPwdCheck);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mtxPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmail1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(22, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 333);
            this.panel1.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "주소";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "수정하기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Location = new System.Drawing.Point(22, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 250);
            this.panel2.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReserveCancel);
            this.groupBox1.Controls.Add(this.dgvReserve);
            this.groupBox1.Location = new System.Drawing.Point(25, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예매내역";
            // 
            // btnReserveCancel
            // 
            this.btnReserveCancel.Location = new System.Drawing.Point(753, 201);
            this.btnReserveCancel.Name = "btnReserveCancel";
            this.btnReserveCancel.Size = new System.Drawing.Size(82, 25);
            this.btnReserveCancel.TabIndex = 1;
            this.btnReserveCancel.Text = "예매취소";
            this.btnReserveCancel.UseVisualStyleBackColor = true;
            this.btnReserveCancel.Click += new System.EventHandler(this.btnReserveCancel_Click);
            // 
            // dgvReserve
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserve.Location = new System.Drawing.Point(36, 20);
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.RowTemplate.Height = 23;
            this.dgvReserve.Size = new System.Drawing.Size(808, 177);
            this.dgvReserve.TabIndex = 0;
            this.dgvReserve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserve_CellContentClick);
            // 
            // zipControl1
            // 
            this.zipControl1.Address1 = "";
            this.zipControl1.Address2 = "";
            this.zipControl1.Location = new System.Drawing.Point(527, 171);
            this.zipControl1.Name = "zipControl1";
            this.zipControl1.Size = new System.Drawing.Size(253, 97);
            this.zipControl1.TabIndex = 61;
            this.zipControl1.ZipCode = "";
            // 
            // frmMyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMyPage";
            this.Text = "MyPage";
            this.Load += new System.EventHandler(this.frmMyPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPwdCheck;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxPhone;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReserveCancel;
        private System.Windows.Forms.DataGridView dgvReserve;
        private Controls.ZipControl zipControl1;
        private System.Windows.Forms.Label label10;
    }
}