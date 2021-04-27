
namespace Lab02_2_19521555_NguyenNgocHop
{
    partial class Lab02_2_Bai03_19521555
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTruong = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.rtbOutPut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trường:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(183, 26);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(233, 34);
            this.txtTen.TabIndex = 3;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(183, 76);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(233, 34);
            this.txtLop.TabIndex = 4;
            // 
            // txtTruong
            // 
            this.txtTruong.Location = new System.Drawing.Point(183, 125);
            this.txtTruong.Name = "txtTruong";
            this.txtTruong.Size = new System.Drawing.Size(233, 34);
            this.txtTruong.TabIndex = 5;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(30, 197);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(386, 90);
            this.btnGhi.TabIndex = 6;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(458, 197);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(354, 90);
            this.btnDoc.TabIndex = 7;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // rtbOutPut
            // 
            this.rtbOutPut.Location = new System.Drawing.Point(458, 23);
            this.rtbOutPut.Name = "rtbOutPut";
            this.rtbOutPut.Size = new System.Drawing.Size(354, 133);
            this.rtbOutPut.TabIndex = 8;
            this.rtbOutPut.Text = "";
            // 
            // Lab02_2_Bai03_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 335);
            this.Controls.Add(this.rtbOutPut);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.txtTruong);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_2_Bai03_19521555";
            this.Text = "Lab02_2_Bai03_19521555";
            this.Load += new System.EventHandler(this.Lab02_2_Bai03_19521555_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTruong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.RichTextBox rtbOutPut;
    }
}