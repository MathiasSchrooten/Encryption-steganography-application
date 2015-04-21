using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSecurity___PEOpdracht
{
    public partial class DecrypteerForm : Form
    {
        private string selectedFile = "";
        private DES des;
        private RSA rsa;
        public DecrypteerForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            selectFileAction(openFileDialog.FileName);

           
        }
        private void selectFileAction(string fileLocation)
        {
            if (fileLocation != "")
            {
                selectedFile = fileLocation;
                selectedFileLabel.Text = "File selected: " + fileLocation;
                decryptButton.Enabled = true;
                decryptTextBox.Enabled = true;
            }
            else
            {
                selectedFileLabel.Text = "No file selected";
                selectedFile = "";
                decryptButton.Enabled = false;
                decryptTextBox.Enabled = false;
            }
        }
        private void selectFileButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void selectFileButton_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    // Code to read the contents of the text file
                    if (File.Exists(fileLoc))
                    {
                        selectFileAction(fileLoc);
                    }
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(selectedFile))
            {
                using (TextReader tr = new StreamReader(selectedFile))
                {
                   // des.Key = 
                   // des.DecrypteerBericht(tr.ReadToEnd());
                }
            }
          //  String encryptedData = des.EncrypteerBericht(messageTextbox.Text);
            String encryptedKey = rsa.EncrypteerBericht(Convert.ToBase64String(des.Key));
        }

        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            // 0 = A
            // 1 = B
            rsa = new RSA();
            des = new DES();
            if (toggleABAmbiance.Toggled == true)
            {
                rsa.Persoon = 0; //set to A
            }
            else
            {
                rsa.Persoon = 1; //set to B
            }
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                using (TextReader tr = new StreamReader(openFileDialog.FileName))
                {
                    String decryptedKey = rsa.DecrypteerBericht(tr.ReadToEnd());
                    byte[] decryptedBytes = new byte[decryptedKey.Length * sizeof(char)];
                    System.Buffer.BlockCopy(decryptedKey.ToCharArray(), 0, decryptedBytes, 0, decryptedBytes.Length);
                    des.Key = decryptedBytes;
                }
                selectKeyLabel.Text = "Key loaded";
            }
            else
                selectKeyLabel.Text = "No key loaded";

        }

     

    }
}
