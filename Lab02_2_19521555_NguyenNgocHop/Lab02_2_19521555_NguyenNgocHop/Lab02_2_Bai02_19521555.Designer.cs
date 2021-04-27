
namespace Lab02_2_19521555_NguyenNgocHop
{
    partial class Lab02_2_Bai02_19521555
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(53, 45);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(255, 127);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "btnWrite";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(375, 45);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(349, 346);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(53, 219);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(255, 127);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "btnRead";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(797, 45);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(298, 346);
            this.rtbRead.TabIndex = 3;
            this.rtbRead.Text = "";
            // 
            // Lab02_2_Bai02_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.rtbRead);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnWrite);
            this.Name = "Lab02_2_Bai02_19521555";
            this.Text = "BU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox rtbRead;
    }
}