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
    public partial class Lab02_2_Bai06_19521555 : Form
    {
        public Lab02_2_Bai06_19521555()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Chọn File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();


            //Tạo 1 mảng string lưu từng dòng của file INPUT.txt
            string[] line = File.ReadAllLines(ofd.FileName);

            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            int dem = 1;
            string so;

            string[] line_output = new string[line.Length];  //Mảng string-> lưu những dòng để in ra OUTPUT.txt

            //Xét mỗi dòng của INPUT.txt
            foreach (string s in line)
            {
                so = "";

                 //Xét từng kí tự trong mỗi dòng
                 for (int i = 0; i < s.Length; i++)
                 {
                     if (s[i] == '=')
                     {
                         for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    so += s[j];
                            }

                         if (dem == 1)
                            {
                                A = double.Parse(so);
                            }
                         else if (dem == 2)
                            {
                                B = double.Parse(so);
                            }
                         else if (dem == 3)
                            {
                                C = double.Parse(so);
                            }
                         else if (dem == 4)
                            {
                                D = double.Parse(so);
                            }
                         dem++;
                         i = s.Length;
                     }
                 }
            }

                string chuoi1 = A.ToString() + "+" + B.ToString() + "=" + (A + B).ToString();
                string chuoi2 = C.ToString() + "-" + D.ToString() + "=" + (C - D).ToString();
                string chuoi3 = A.ToString() + "*" + B.ToString() + "=" + (A * B).ToString();
                if(D!=0)
            {
                string chuoi4 = C.ToString() + "/" + D.ToString() + "=" + (C / D).ToString();
                line_output[3] = chuoi4;
            }    
                else
            {
                MessageBox.Show("D không hợp lệ");
                line_output[3] = "D không hợp lệ";
            }    
                

                line_output[0] = chuoi1;
                line_output[1] = chuoi2;
                line_output[2] = chuoi3;
                

                //Ghi File
                if (!File.Exists("OUTPUT06.txt"))
                {
                    File.Create("OUTPUT03.txt").Close();
                    using (StreamWriter sw = File.AppendText("OUTPUT06.txt"))
                    {
                        for (int i = 0; i < line_output.Length; i++)
                        {
                            sw.WriteLine(line_output[i]);
                        }

                    }
                }
                else
                {
                    File.WriteAllText("OUTPUT06.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText("OUTPUT06.txt"))
                    {
                        for (int i = 0; i < line_output.Length; i++)
                        {
                            sw.WriteLine(line_output[i]);
                        }
                    }
                }

                MessageBox.Show("Đọc và ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
