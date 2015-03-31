using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasicSecurity___PEOpdracht
{
    public partial class Steganography : Form
    {
        public Steganography()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //decrypt button
            toEncrypt.Text = SteganographyClass.extractText((Bitmap)thePicture.Image);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //encrypt button
            if (toEncrypt.Text == "")
            {
                MessageBox.Show("Please enter some text to encrypt in the image. ");

            }
            else
            {
                Bitmap bmp =  SteganographyClass.EncryptBitmap(toEncrypt.Text, new Bitmap(thePicture.Image));
                thePicture.Image = bmp;
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dialog.FileName, ImageFormat.Bmp);
                    toEncrypt.Text = "";
                }
                

            }
            
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                thePicture.ImageLocation = openFileDialog.FileName;
               
                
            }


        }

        private void toEncrypt_TextChanged(object sender, EventArgs e)
        {
            
                berekenMaxSize();
           
            
        }
        private void berekenMaxSize()
        {
            int maxSize = (thePicture.Image.Width * thePicture.Image.Height * 3) / 8;
            maxSizeLabel.Text = maxSize.ToString() + " karakters.";
            currentSizeLabel.Text = toEncrypt.TextLength.ToString();
        }
    }
}
