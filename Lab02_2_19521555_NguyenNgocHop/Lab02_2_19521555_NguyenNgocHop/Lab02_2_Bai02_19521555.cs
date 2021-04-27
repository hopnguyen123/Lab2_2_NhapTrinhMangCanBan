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
    public partial class Lab02_2_Bai02_19521555 : Form
    {
        public Lab02_2_Bai02_19521555()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Chọn File để lưu
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.ShowDialog();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                //Mở File
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);

                //Ghi File
                BinaryWriter bw = new BinaryWriter(fs);

                int i = 25;
                double d = 3.12;
                bool b = true;
                string s = "I am HOp";
                string k = "Binary Writer KHÔNG LÀM BIẾNG ĐỔI STRING KHI GHI XUỐNG FILE";

                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
                bw.Write(k);

                //Đóng File
                fs.Close();

                MessageBox.Show("Đã Ghi xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Chon File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                //Mở File
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                //Đọc File
                BinaryReader br = new BinaryReader(fs);
                int a = br.ReadInt32();
                double d = br.ReadDouble();
                bool b = br.ReadBoolean();
                string s = br.ReadString();
                string k = br.ReadString();
                rtbRead.Text = a.ToString() + " - " + d.ToString() + " - " + b.ToString() + " - " + s + "\n" + k;

                //Đóng File
                fs.Close();
            }    
        }
    }
}
