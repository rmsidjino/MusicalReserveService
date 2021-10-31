
namespace WindowsFormsAppMusical
{
    partial class frmActorInfo
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
            this.ptbActor = new System.Windows.Forms.PictureBox();
            this.btnImageInsert = new System.Windows.Forms.Button();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActorId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvActor = new System.Windows.Forms.DataGridView();
            this.txtActorAge = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtActorAge);
            this.groupBox1.Controls.Add(this.ptbActor);
            this.groupBox1.Controls.Add(this.btnImageInsert);
            this.groupBox1.Controls.Add(this.txtActorName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtActorId);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(510, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 405);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "배우 정보";
            // 
            // ptbActor
            // 
            this.ptbActor.Location = new System.Drawing.Point(260, 81);
            this.ptbActor.Name = "ptbActor";
            this.ptbActor.Size = new System.Drawing.Size(144, 165);
            this.ptbActor.TabIndex = 31;
            this.ptbActor.TabStop = false;
            // 
            // btnImageInsert
            // 
            this.btnImageInsert.Location = new System.Drawing.Point(283, 265);
            this.btnImageInsert.Name = "btnImageInsert";
            this.btnImageInsert.Size = new System.Drawing.Size(100, 21);
            this.btnImageInsert.TabIndex = 4;
            this.btnImageInsert.Text = "이미지 등록";
            this.btnImageInsert.UseVisualStyleBackColor = true;
            this.btnImageInsert.Click += new System.EventHandler(this.btnImageInsert_Click);
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(124, 135);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(100, 21);
            this.txtActorName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "배우 나이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "배우ID";
            // 
            // txtActorId
            // 
            this.txtActorId.Location = new System.Drawing.Point(124, 94);
            this.txtActorId.Name = "txtActorId";
            this.txtActorId.Size = new System.Drawing.Size(100, 21);
            this.txtActorId.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(141, 339);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(74, 34);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "조회";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(50, 339);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 34);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "등록";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "배우 이름";
            // 
            // dgvActor
            // 
            this.dgvActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActor.Location = new System.Drawing.Point(26, 23);
            this.dgvActor.Name = "dgvActor";
            this.dgvActor.RowTemplate.Height = 23;
            this.dgvActor.Size = new System.Drawing.Size(457, 405);
            this.dgvActor.TabIndex = 2;
            this.dgvActor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActor_CellDoubleClick);
            // 
            // txtActorAge
            // 
            this.txtActorAge.Location = new System.Drawing.Point(124, 177);
            this.txtActorAge.Name = "txtActorAge";
            this.txtActorAge.Size = new System.Drawing.Size(100, 21);
            this.txtActorAge.TabIndex = 3;
            // 
            // frmActorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvActor);
            this.Name = "frmActorInfo";
            this.Text = "배우정보관리";
            this.Load += new System.EventHandler(this.frmActorInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActorId;
        private System.Windows.Forms.PictureBox ptbActor;
        private System.Windows.Forms.Button btnImageInsert;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.Label label1;
        private Controls.NumTextBox txtActorAge;
    }
}