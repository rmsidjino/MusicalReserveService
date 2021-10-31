
namespace WindowsFormsAppMusical
{
    partial class frmSeatMake
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtASeat = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.txtSSeat = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.txtRSeat = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.txtVipSeat = new WindowsFormsAppMusical.Controls.NumTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIP석";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "R석";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "S석";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "A석";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(185, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 255);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(185, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(451, 61);
            this.button2.TabIndex = 13;
            this.button2.Text = "STAGE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(56, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "등록";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtASeat
            // 
            this.txtASeat.Location = new System.Drawing.Point(91, 168);
            this.txtASeat.Name = "txtASeat";
            this.txtASeat.Size = new System.Drawing.Size(44, 21);
            this.txtASeat.TabIndex = 8;
            // 
            // txtSSeat
            // 
            this.txtSSeat.Location = new System.Drawing.Point(91, 133);
            this.txtSSeat.Name = "txtSSeat";
            this.txtSSeat.Size = new System.Drawing.Size(44, 21);
            this.txtSSeat.TabIndex = 6;
            // 
            // txtRSeat
            // 
            this.txtRSeat.Location = new System.Drawing.Point(91, 97);
            this.txtRSeat.Name = "txtRSeat";
            this.txtRSeat.Size = new System.Drawing.Size(44, 21);
            this.txtRSeat.TabIndex = 4;
            // 
            // txtVipSeat
            // 
            this.txtVipSeat.Location = new System.Drawing.Point(91, 60);
            this.txtVipSeat.Name = "txtVipSeat";
            this.txtVipSeat.Size = new System.Drawing.Size(44, 21);
            this.txtVipSeat.TabIndex = 2;
            // 
            // frmSeatMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtASeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSSeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRSeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVipSeat);
            this.Controls.Add(this.label1);
            this.Name = "frmSeatMake";
            this.Text = "frmSeatMade";
            this.Load += new System.EventHandler(this.frmSeatMake_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.NumTextBox txtVipSeat;
        private Controls.NumTextBox txtRSeat;
        private System.Windows.Forms.Label label2;
        private Controls.NumTextBox txtSSeat;
        private System.Windows.Forms.Label label3;
        private Controls.NumTextBox txtASeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}