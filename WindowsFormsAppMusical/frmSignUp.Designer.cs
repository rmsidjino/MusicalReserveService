
namespace WindowsFormsAppMusical
{
    partial class frmSignUp
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPWDCheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboWoman = new System.Windows.Forms.RadioButton();
            this.rboMan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.zipControl1 = new WindowsFormsAppMusical.Controls.ZipControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(233, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "ID중복체크";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserID.Location = new System.Drawing.Point(127, 28);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(39, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "회원ID";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmail2.Location = new System.Drawing.Point(246, 268);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(100, 22);
            this.txtEmail2.TabIndex = 9;
            // 
            // cboEmail
            // 
            this.cboEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "이메일선택",
            "hanmail.net",
            "naver.com",
            "gmail.com",
            "korea.kr",
            "직접입력"});
            this.cboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmail.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Items.AddRange(new object[] {
            "이메일선택",
            "hanmail.net",
            "naver.com",
            "gmail.com",
            "korea.kr",
            "직접입력"});
            this.cboEmail.Location = new System.Drawing.Point(351, 268);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(121, 23);
            this.cboEmail.TabIndex = 10;
            this.cboEmail.SelectedIndexChanged += new System.EventHandler(this.cboEmail_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(228, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "@";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmail1.Location = new System.Drawing.Point(127, 268);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 22);
            this.txtEmail1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "이메일";
            // 
            // mtxPhone
            // 
            this.mtxPhone.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtxPhone.Location = new System.Drawing.Point(127, 236);
            this.mtxPhone.Mask = "000-9000-0000";
            this.mtxPhone.Name = "mtxPhone";
            this.mtxPhone.Size = new System.Drawing.Size(100, 22);
            this.mtxPhone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(39, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "핸드폰번호";
            // 
            // txtPWD
            // 
            this.txtPWD.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWD.Location = new System.Drawing.Point(127, 60);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(100, 22);
            this.txtPWD.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "비밀번호";
            // 
            // txtPWDCheck
            // 
            this.txtPWDCheck.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWDCheck.Location = new System.Drawing.Point(127, 92);
            this.txtPWDCheck.Name = "txtPWDCheck";
            this.txtPWDCheck.Size = new System.Drawing.Size(100, 22);
            this.txtPWDCheck.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(39, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "비밀번호 확인";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserName.Location = new System.Drawing.Point(127, 124);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(39, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "이름";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(39, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "성별";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(127, 156);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(101, 22);
            this.dtpBirthDay.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(39, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "생일";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(152, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(251, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboWoman);
            this.groupBox1.Controls.Add(this.rboMan);
            this.groupBox1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(127, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rboWoman
            // 
            this.rboWoman.AutoSize = true;
            this.rboWoman.Location = new System.Drawing.Point(65, 14);
            this.rboWoman.Name = "rboWoman";
            this.rboWoman.Size = new System.Drawing.Size(36, 19);
            this.rboWoman.TabIndex = 1;
            this.rboWoman.TabStop = true;
            this.rboWoman.Text = "여";
            this.rboWoman.UseVisualStyleBackColor = true;
            // 
            // rboMan
            // 
            this.rboMan.AutoSize = true;
            this.rboMan.Location = new System.Drawing.Point(8, 14);
            this.rboMan.Name = "rboMan";
            this.rboMan.Size = new System.Drawing.Size(36, 19);
            this.rboMan.TabIndex = 0;
            this.rboMan.TabStop = true;
            this.rboMan.Text = "남";
            this.rboMan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(39, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "주소";
            // 
            // zipControl1
            // 
            this.zipControl1.Address1 = "";
            this.zipControl1.Address2 = "";
            this.zipControl1.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zipControl1.Location = new System.Drawing.Point(127, 302);
            this.zipControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipControl1.Name = "zipControl1";
            this.zipControl1.Size = new System.Drawing.Size(253, 101);
            this.zipControl1.TabIndex = 11;
            this.zipControl1.ZipCode = "";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 502);
            this.Controls.Add(this.zipControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPWDCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.cboEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.label1);
            this.Name = "frmSignUp";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxPhone;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPWDCheck;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboWoman;
        private System.Windows.Forms.RadioButton rboMan;
        private System.Windows.Forms.Label label10;
        private Controls.ZipControl zipControl1;
    }
}