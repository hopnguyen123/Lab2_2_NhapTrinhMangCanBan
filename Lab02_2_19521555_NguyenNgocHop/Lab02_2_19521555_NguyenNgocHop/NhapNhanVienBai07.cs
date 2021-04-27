using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab02_2_19521555_NguyenNgocHop
{
    public partial class NhapNhanVienBai07 : Form
    {
        public NhapNhanVienBai07()
        {
            InitializeComponent();
        }

        public int Ktra;    //1: -> nhập, 2: -> Xuất
        
        private void NhapNhanVienBai07_Load(object sender, EventArgs e)
        {
            if (Ktra == 1)
            {
                btnXuat.Enabled = false;

                btnNhap.Enabled = true;
                txtMaNV.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                txtLuongCung.Enabled = true;
                txtPhuCap.Enabled = true;
            }
            else if (Ktra == 2)
            {
                btnXuat.Enabled = true;

                btnNhap.Enabled = false;
                txtMaNV.Enabled = false;
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtLuongCung.Enabled = false;
                txtPhuCap.Enabled = false;
            }
        }

        //Tạo 1 lớp chứa nhân viên
        [Serializable]
        public class NhanVien
        {
            public string MaNV = "";
            public string HoTen = "";
            public string SDT = "";
            public long LuongCung = 0;
            public long PhuCap = 0;
            public long TongLUong = 0;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Giải mã dữ liệu ->  lưu vào listFromFile
            List<NhanVien> listFromFile = new List<NhanVien>();
            using (Stream fileStream = new FileStream("INPUT07.txt", FileMode.Open))
            {
                IFormatter bFormatter = new BinaryFormatter();
                while (fileStream.Position != fileStream.Length)
                {
                    listFromFile.Add((NhanVien)bFormatter.Deserialize(fileStream));
                }

            }

            //Tính Tổng Lương => gán vào mảng String, và xuất ra màn hình
            string[] ChuoiOutPut = new string[listFromFile.Count];
            for (int i = 0; i < listFromFile.Count; i++)
            {
                long TongLuong = 0;
                string Chuoi = "";
                TongLuong = listFromFile[i].LuongCung + listFromFile[i].PhuCap;
                Chuoi = Chuoi + listFromFile[i].MaNV + " - " + listFromFile[i].HoTen + " - " + listFromFile[i].SDT + " - " + listFromFile[i].LuongCung.ToString() + " - " + listFromFile[i].PhuCap.ToString() + " - " + TongLuong.ToString();
                rtbOutPut.Text = rtbOutPut.Text + Chuoi + '\n';
                ChuoiOutPut[i] = Chuoi;
            }

            //Xuất từng phần tử trong mảng String[] ChuoiOutPut => File OUTPUT04.txt
            if (!File.Exists("OUTPUT07.txt"))
            {
                File.Create("OUTPUT07.txt").Close();
                using (StreamWriter sw = File.AppendText("OUTPUT07.txt"))
                {
                    for (int i = 0; i < ChuoiOutPut.Length; i++)
                    {
                        sw.WriteLine(ChuoiOutPut[i]);
                    }
                }
            }
            else
            {
                File.WriteAllText("OUTPUT07.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("OUTPUT07.txt"))
                {
                    for (int i = 0; i < ChuoiOutPut.Length; i++)
                    {
                        sw.WriteLine(ChuoiOutPut[i]);
                    }
                }
            }

            MessageBox.Show("Xuất File thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            long LuongCung, PhuCap;
            bool check = true;

            //Kiểm tra Mã Nhân Viên
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã Nhân Viên bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                txtMaNV.Focus();
            }

            //Kiểm Tra Họ Tên
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ Tên bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                check = false;
            }
            else
            {
                for (int i = 0; i < txtHoTen.Text.Length; i++)
                {
                    if (((txtHoTen.Text[i] < 'a' || txtHoTen.Text[i] > 'z') && (txtHoTen.Text[i] < 'A' || txtHoTen.Text[i] > 'Z')) && (txtHoTen.Text[i] != ' '))
                    {
                        MessageBox.Show("Họ Tên không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHoTen.Clear();
                        txtHoTen.Focus();
                        i = txtHoTen.Text.Length;
                        check = false;
                    }
                }
            }

            //Kiểm Tra Số Điện Thoại
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện Thoại bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                txtSDT.Focus();
            }
            else
            {
                for (int i = 0; i < txtSDT.Text.Length; i++)
                {
                    if (txtSDT.Text[i] < '0' || txtSDT.Text[i] > '9')
                    {
                        MessageBox.Show("Số Điện Thoại không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = txtSDT.Text.Length;
                        txtSDT.Clear();
                        txtSDT.Focus();
                        check = false;
                    }
                }
            }

            //Kiểm Tra Lương Cứng
            try
            {
                LuongCung = long.Parse(txtLuongCung.Text);

                if (LuongCung < 0)
                {
                    MessageBox.Show("Lương Cứng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLuongCung.Clear();
                    txtLuongCung.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Lương Cứng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongCung.Clear();
                txtLuongCung.Focus();
                check = false;
            }

            //Kiểm Tra Phụ Cấp
            try
            {
                PhuCap = long.Parse(txtPhuCap.Text);

                if (PhuCap < 0)
                {
                    MessageBox.Show("Phụ cấp không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhuCap.Clear();
                    txtPhuCap.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Phụ Cấp không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhuCap.Clear();
                txtPhuCap.Focus();
                check = false;
            }

            //Nếu các giá trị nhập vào chính xác
            if (check == true)
            {
                //Tạo 1 đối tượng lưu trữ các giá trị nhập vào
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtHoTen.Text;
                nv.SDT = txtSDT.Text;
                nv.LuongCung = long.Parse(txtLuongCung.Text);
                nv.PhuCap = long.Parse(txtPhuCap.Text);

                //Mã hoá từng nhân viên -> Lưu vào File
                Stream stream = new FileStream("INPUT07.txt", FileMode.Append, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, nv);
                stream.Close();

                MessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
