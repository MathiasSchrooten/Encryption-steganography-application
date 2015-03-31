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
    public partial class EncrypteerForm : Form
    {
        private DES des;
        private RSA rsa;

        public EncrypteerForm()
        {
            InitializeComponent();

            ambianceControlBox.EnableMaximize = false;
        }

        private void encryptMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                des = new DES();
                rsa = new RSA();

                String encryptedData = des.EncrypteerBericht(messageTextbox.Text);
                String encryptedKey = rsa.EncrypteerBericht(Convert.ToBase64String(des.Key));

                String textFile = "";
                String keyFile = "";

                if (toggleABAmbiance.Toggled == true)
                {
                    textFile = "/A-encryptedText.txt";
                    keyFile = "/A-encryptedDESKey.txt";
                }
                else
                {
                    textFile = "/B-encryptedText.txt";
                    keyFile = "/B-encryptedDESKey.txt";
                }

                StreamWriter writer;
                writer = new StreamWriter(Properties.Settings.Default.SharedFolder + textFile);

                writer.Write(encryptedData);

                writer.Close();

                writer = new StreamWriter(Properties.Settings.Default.SharedFolder + keyFile);

                writer.Write(encryptedKey);

                writer.Close();
            }
            catch (Exception ex)
            {
                errorLabel.Text = "An error has occured: " + ex.Message;
            }
            finally
            {
                succesAmbianceLinkLabel.Visible = true;
            }
        }

        private void messageTextbox_TextChanged(object sender, EventArgs e)
        {
            if (messageTextbox.Text != "")
            {
                encryptMessageButton.Visible = true;
            } 
            else
            {
                encryptMessageButton.Visible = false;
            }
        }

        private void readFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                messageTextbox.Text = reader.ReadToEnd();

                reader.Close();
            }
        }

        private void succesAmbianceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.SharedFolder);
        }
    }
}
