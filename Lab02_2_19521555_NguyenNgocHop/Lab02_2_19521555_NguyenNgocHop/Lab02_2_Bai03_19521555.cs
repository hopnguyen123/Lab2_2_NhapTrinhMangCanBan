using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab02_2_19521555_NguyenNgocHop
{
    public partial class Lab02_2_Bai03_19521555 : Form
    {
        public Lab02_2_Bai03_19521555()
        {
            InitializeComponent();
        }

        private void Lab02_2_Bai03_19521555_Load(object sender, EventArgs e)
        {

        }

        [Serializable()]
        class HocSinh
        {
            public string Ten;
            public string Lop;
            public string Truong;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //Chọn file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                //Mở File
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                
                //Ghi file
                BinaryFormatter bf = new BinaryFormatter();

                HocSinh hs = new HocSinh();
                hs.Ten = txtTen.Text;
                hs.Lop = txtLop.Text;
                hs.Truong = txtTruong.Text;

                bf.Serialize(fs, hs);

                //Đóng File
                fs.Close();

                MessageBox.Show("Đã ghi xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            //Chọn file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                //Mở file
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                //Đọc File
                BinaryFormatter br = new BinaryFormatter();
                HocSinh hs = (HocSinh)br.Deserialize(fs);

                rtbOutPut.Text = hs.Ten + "\n" + hs.Lop + "\n" + hs.Truong;

                //Đóng File
                fs.Close();
            }    
        }
    }
}
