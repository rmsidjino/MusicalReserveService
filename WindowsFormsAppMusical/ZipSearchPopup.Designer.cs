
namespace WindowsFormsAppMusical
{
    partial class ZipSearchPopup
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
            this.txtJibunZipcode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadZipcode = new System.Windows.Forms.TextBox();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.btnJibun = new System.Windows.Forms.Button();
            this.btnRoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvZip = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJibunZipcode
            // 
            this.txtJibunZipcode.Location = new System.Drawing.Point(145, 497);
            this.txtJibunZipcode.Name = "txtJibunZipcode";
            this.txtJibunZipcode.Size = new System.Drawing.Size(66, 21);
            this.txtJibunZipcode.TabIndex = 32;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Location = new System.Drawing.Point(217, 497);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(261, 21);
            this.txtJibunAddr2.TabIndex = 31;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Location = new System.Drawing.Point(145, 470);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(333, 21);
            this.txtJibunAddr1.TabIndex = 30;
            // 
            // txtRoadZipcode
            // 
            this.txtRoadZipcode.Location = new System.Drawing.Point(145, 434);
            this.txtRoadZipcode.Name = "txtRoadZipcode";
            this.txtRoadZipcode.Size = new System.Drawing.Size(66, 21);
            this.txtRoadZipcode.TabIndex = 29;
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Location = new System.Drawing.Point(217, 434);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(261, 21);
            this.txtRoadAddr2.TabIndex = 28;
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Location = new System.Drawing.Point(145, 407);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(333, 21);
            this.txtRoadAddr1.TabIndex = 27;
            // 
            // btnJibun
            // 
            this.btnJibun.Location = new System.Drawing.Point(36, 476);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(87, 41);
            this.btnJibun.TabIndex = 26;
            this.btnJibun.Text = "  지번주소   확인";
            this.btnJibun.UseVisualStyleBackColor = true;
            this.btnJibun.Click += new System.EventHandler(this.btnJibun_Click);
            // 
            // btnRoad
            // 
            this.btnRoad.Location = new System.Drawing.Point(36, 412);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(87, 41);
            this.btnRoad.TabIndex = 25;
            this.btnRoad.Text = "도로명주소   확인";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "도로명(지번) 주소검색";
            // 
            // dgvZip
            // 
            this.dgvZip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZip.Location = new System.Drawing.Point(12, 34);
            this.dgvZip.Name = "dgvZip";
            this.dgvZip.RowHeadersVisible = false;
            this.dgvZip.RowTemplate.Height = 23;
            this.dgvZip.Size = new System.Drawing.Size(506, 362);
            this.dgvZip.TabIndex = 23;
            this.dgvZip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZip_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(369, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(189, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 21);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // ZipSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 537);
            this.Controls.Add(this.txtJibunZipcode);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.txtRoadZipcode);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "ZipSearchPopup";
            this.Text = "우편번호검색";
            this.Load += new System.EventHandler(this.ZipSearchPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJibunZipcode;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.TextBox txtRoadZipcode;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.Button btnJibun;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvZip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}