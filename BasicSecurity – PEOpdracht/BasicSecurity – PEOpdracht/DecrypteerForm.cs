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
        private bool keyLoad = false;
        public DecrypteerForm()
        {
            InitializeComponent();
            rsa = new RSA();
            des = new DES();
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
                decryptTextButton.Enabled = true;
                decryptTextBox.Enabled = true;
            }
            else
            {
                selectedFileLabel.Text = "No file selected";
                selectedFile = "";
                decryptTextButton.Enabled = false;
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
            
            if (File.Exists(selectedFile) && keyLoad)
            {
                using (TextReader tr = new StreamReader(selectedFile))
                {
                    string fileContent = tr.ReadToEnd();
                    
                   string dec = des.DecrypteerBericht(Encoding.ASCII.GetBytes(fileContent));
                   decryptTextBox.Text = dec;
                }
            }
            else if (!keyLoad && File.Exists(selectedFile))
            {
                MessageBox.Show("There is no or a wrong key selected. Please select another key");
            }
            else{
                MessageBox.Show("No file selected. Please select a file");
            }
        }
        private void decryptFileButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedFile) && keyLoad)
            {
                using (TextReader tr = new StreamReader(selectedFile))
                {

                    string fileContent = tr.ReadToEnd();

                    string dec = des.DecrypteerBericht(Encoding.ASCII.GetBytes(fileContent));
                    using(StreamWriter writer = new StreamWriter(selectedFile + ".Decrypted.txt"))
                        writer.Write(dec);
                    
                }
            }
            else if (!keyLoad && File.Exists(selectedFile))
            {
                MessageBox.Show("There is no or a wrong key selected. Please select another key");
            }
            else
            {
                MessageBox.Show("No file selected. Please select a file");
            }
        }
        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            // 0 = A
            // 1 = B

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
                try { 
                using (TextReader tr = new StreamReader(openFileDialog.FileName))
                {
                    String decryptedKey = rsa.DecrypteerBericht(tr.ReadToEnd());
                    byte[] decryptedBytes = new byte[decryptedKey.Length * sizeof(char)];
                    System.Buffer.BlockCopy(decryptedKey.ToCharArray(), 0, decryptedBytes, 0, decryptedBytes.Length);
                    des.Key = decryptedBytes;
                }
                selectKeyLabel.Text = "Key loaded";
                keyLoad = true;
                }
                catch (Exception ex)
                {
                    selectKeyLabel.Text = "Error with key selection, please try again";
                    keyLoad = false;
                }
            }
            else { 
                selectKeyLabel.Text = "No key loaded";
                keyLoad = false;
            }

        }

       

     

    }
}
