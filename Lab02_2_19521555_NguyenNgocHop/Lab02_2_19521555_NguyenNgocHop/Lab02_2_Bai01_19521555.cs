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
    public partial class Lab02_2_Bai01_19521555 : Form
    {
        public Lab02_2_Bai01_19521555()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Chọn File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();

            try
            {
                //Mở File
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                //Đọc file
                StreamReader sr = new StreamReader(fs);
                int count = 0;
                while(sr.ReadLine()!=null)
                {
                    count++;
                }    
                fs.Close();
                MessageBox.Show("There are " + count + " lines in " + ofd.SafeFileName.ToString());
            }
            catch
            {
                MessageBox.Show("Chưa chọn File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
