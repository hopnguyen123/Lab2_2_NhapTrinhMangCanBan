using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab02_2_19521555_NguyenNgocHop
{
    public partial class Lab02_2_Bai07_19521555 : Form
    {
        public Lab02_2_Bai07_19521555()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            bool check = true;
            int SoLuong=0;
            try
            {
                SoLuong = int.Parse(txtSoLuong.Text);

                if(SoLuong<0)
                {
                    MessageBox.Show("Số lượng nhân viên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Số lượng Nhân viên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Clear();
                txtSoLuong.Focus();
                check = false;
            }

            if(check ==true)
            {
                for (int i = 1; i <= SoLuong; i++)
                {
                    NhapNhanVienBai07 NhapSV = new NhapNhanVienBai07();
                    NhapSV.Ktra = 1;
                    NhapSV.ShowDialog();
                }
            }    
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            NhapNhanVienBai07 Xuat = new NhapNhanVienBai07();
            Xuat.Ktra = 2;
            Xuat.ShowDialog();
        }
    }
}
