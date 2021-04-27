
namespace Lab02_2_19521555_NguyenNgocHop
{
    partial class Lab02_2_Bai05_19521555
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
            this.txtGhi = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGhi
            // 
            this.txtGhi.Location = new System.Drawing.Point(55, 37);
            this.txtGhi.Multiline = true;
            this.txtGhi.Name = "txtGhi";
            this.txtGhi.Size = new System.Drawing.Size(275, 182);
            this.txtGhi.TabIndex = 0;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(436, 37);
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(269, 182);
            this.txtDoc.TabIndex = 1;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(55, 266);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(275, 91);
            this.btnGhi.TabIndex = 2;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(436, 266);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(269, 91);
            this.btnDoc.TabIndex = 3;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // Lab02_2_Bai05_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtGhi);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_2_Bai05_19521555";
            this.Text = "Lab02_2_Bai05_19521555";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhi;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDoc;
    }
}