
namespace WindowsFormsAppMusical
{
    partial class frmReserve3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.txtTotTicket = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGrade.Location = new System.Drawing.Point(31, 48);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(51, 15);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "등급선택";
            // 
            // btnBefore
            // 
            this.btnBefore.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBefore.Location = new System.Drawing.Point(452, 376);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 23);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "이전단계";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.Location = new System.Drawing.Point(533, 376);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "결제하기";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotPrice.Location = new System.Drawing.Point(233, 376);
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.Size = new System.Drawing.Size(192, 22);
            this.txtTotPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(141, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "최종 결제금액";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCaculate);
            this.panel1.Controls.Add(this.txtTotTicket);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblGrade);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 301);
            this.panel1.TabIndex = 6;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCaculate.Location = new System.Drawing.Point(502, 257);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(75, 23);
            this.btnCaculate.TabIndex = 7;
            this.btnCaculate.Text = "유형확정";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // txtTotTicket
            // 
            this.txtTotTicket.Font = new System.Drawing.Font("예스 고딕 레귤러", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotTicket.Location = new System.Drawing.Point(502, 48);
            this.txtTotTicket.Name = "txtTotTicket";
            this.txtTotTicket.Size = new System.Drawing.Size(63, 22);
            this.txtTotTicket.TabIndex = 5;
            // 
            // frmReserve3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotPrice);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBefore);
            this.Name = "frmReserve3";
            this.Text = "결제하기";
            this.Load += new System.EventHandler(this.frmReserve3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotTicket;
        private System.Windows.Forms.Button btnCaculate;
    }
}