using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLSB_Duong
{
    public partial class DuongLSBTool : Form
    {
        Bitmap picEn, picDe;
        
        SaveFileDialog save = new SaveFileDialog();
        OpenFileDialog select = new OpenFileDialog();

        public DuongLSBTool()
        {
            InitializeComponent();
        } 
        public string getBit(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0').Substring(7, 1);
        }
        private byte setBit(byte b, string mess, ref int a)
        {
            string tam = Convert.ToString(b, 2).PadLeft(8, '0');

            if (a < mess.Length)
            {
                tam = tam.Substring(0, 7) + mess.Substring(a, 1);
                a++;
            }

            else
            {
                tam = tam.Substring(0, 7) + "0";
            }
                

            return Convert.ToByte(tam, 2);
        }
        private void Encode_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if(picEn == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh! ");
                return;
            } else if (tbMess.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông điệp! ");
                return;
            } else
            {
                string mess = string.Empty;
                foreach (char ch in tbMess.Text)
                {
                    mess += Convert.ToString((int)ch, 2).PadLeft(8, '0'); // 
                }
                int a = 0;
                for(int i = 0; i < picEn.Width; i++) // duyet anh
                
                    for(int j = 0; j < picEn.Height; j++)
                    {
                        Color color = picEn.GetPixel(i, j);
                        picEn.SetPixel(i, j, Color.FromArgb(setBit(color.R, mess, ref a), setBit(color.G, mess, ref a), setBit(color.B, mess, ref a)));
                        
                    }
                    picEncode.Image = picEn;
                    save.Filter = "Image Files (*.bmp) | *.bmp";
                    if (save.ShowDialog() == DialogResult.OK){
                        picEn.Save(save.FileName);
                    MessageBox.Show("Lưu file thành công! ");
                    }

                
            }
        }

        private void picSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (picDe == null)
            {

                MessageBox.Show("Bạn chưa chọn ảnh! ");
                return;
            } else
            {
                string kq = string.Empty;
                string tam = string.Empty;
                for(int i = 0; i < picDe.Width; i++)
                    for(int j = 0; j < picDe.Height; j++)
                    {
                        Color color = picDe.GetPixel(i, j);
                        tam += getBit(color.R) + getBit(color.G) + getBit(color.B);
                        if(tam.Length >= 8)
                        {
                            string n = tam.Substring(0, 8);
                            if (n != "00000000")
                            {
                                kq += Convert.ToChar(Convert.ToByte(n, 2));
                            }
                            else
                            {
                                tbMessDecode.Text = kq;
                                return;
                            }
                            tam = tam.Substring(8, tam.Length - 8);
                        }
                    }
                tbMessDecode.Text = kq;
            }
        }

        private void btnSelectDecode_Click(object sender, EventArgs e)
        {
            select.Filter = "Image Files (*.bmp) | *.bmp"; // chi cho phep mo BMP
            if (select.ShowDialog() == DialogResult.OK)
            {
                picDe = new Bitmap(select.FileName);
                picDecode.Image = picDe;
                tbSelectDecode.Text = select.FileName;
            }
        }

        private void picDecode_Click(object sender, EventArgs e)
        {

        }

        private void Decode_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DuongLSBTool_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            select.Filter = "Image Files (*.bmp) | *.bmp"; // chi cho phep mo BMP
            if(select.ShowDialog()== DialogResult.OK)
            {
                picEn = new Bitmap(select.FileName);
                picSelect.Image = picEn;
                tbOpen.Text = select.FileName;
            }
        }
    }
}
