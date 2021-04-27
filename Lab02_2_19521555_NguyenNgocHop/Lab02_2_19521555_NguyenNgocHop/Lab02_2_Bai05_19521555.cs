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
    public partial class Lab02_2_Bai05_19521555 : Form
    {
        public Lab02_2_Bai05_19521555()
        {
            InitializeComponent();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(fs);

                string s = txtGhi.Text;
                sw.WriteLine(s);
                sw.Flush();

                fs.Close();

                MessageBox.Show("Ghi thành công");
            }    


        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();
                txtDoc.Text = s;

                fs.Close();
            }    
        }
    }
}
