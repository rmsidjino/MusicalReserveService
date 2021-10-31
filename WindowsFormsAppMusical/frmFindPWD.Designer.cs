
namespace WindowsFormsAppMusical
{
    partial class frmFindPWD
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindPWD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.btnCancel.Location = new System.Drawing.Point(187, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFindPWD
            // 
            this.btnFindPWD.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.btnFindPWD.Location = new System.Drawing.Point(43, 187);
            this.btnFindPWD.Name = "btnFindPWD";
            this.btnFindPWD.Size = new System.Drawing.Size(108, 32);
            this.btnFindPWD.TabIndex = 30;
            this.btnFindPWD.Text = "비밀번호찾기";
            this.btnFindPWD.UseVisualStyleBackColor = true;
            this.btnFindPWD.Click += new System.EventHandler(this.btnFindPWD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.label5.Location = new System.Drawing.Point(55, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "이메일";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.txtEmail.Location = new System.Drawing.Point(111, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 24);
            this.txtEmail.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.label3.Location = new System.Drawing.Point(69, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.label4.Location = new System.Drawing.Point(27, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "회원아이디";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.txtUserName.Location = new System.Drawing.Point(111, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 24);
            this.txtUserName.TabIndex = 25;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("나눔고딕", 11F);
            this.txtUserID.Location = new System.Drawing.Point(111, 38);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 24);
            this.txtUserID.TabIndex = 24;
            // 
            // frmFindPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindPWD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Name = "frmFindPWD";
            this.Text = "frmFindPWD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindPWD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
    }
}