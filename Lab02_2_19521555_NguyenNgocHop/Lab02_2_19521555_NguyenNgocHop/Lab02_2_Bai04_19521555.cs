using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab02_2_19521555_NguyenNgocHop
{
    public partial class Lab02_2_Bai04_19521555 : Form
    {
        public Lab02_2_Bai04_19521555()
        {
            InitializeComponent();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //Chọn File
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                //Mở File
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);

                //Ghi File
                StreamWriter sr = new StreamWriter(fs);

                if(cbGhiNho.Checked == true)
                {
                    sr.WriteLine(txtTenDangNhap.Text);
                    sr.WriteLine(txtMatKhau.Text);
                    sr.WriteLine("1");
                    sr.Flush();     //Ghi từng dòng vào file
                }    
                else
                {
                    sr.WriteLine("0");
                    sr.Flush();
                }

                //Đóng File
                fs.Close();
                MessageBox.Show("Ghi xong");
            }    
        }
    }
}
