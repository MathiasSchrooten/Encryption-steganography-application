namespace BasicSecurity___PEOpdracht
{
    partial class Steganography
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptButton = new System.Windows.Forms.Button();
            this.toEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.thePicture = new System.Windows.Forms.PictureBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxSizeLabel = new System.Windows.Forms.Label();
            this.currentSizeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(339, 274);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(64, 19);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toEncrypt
            // 
            this.toEncrypt.Location = new System.Drawing.Point(339, 102);
            this.toEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toEncrypt.Multiline = true;
            this.toEncrypt.Name = "toEncrypt";
            this.toEncrypt.Size = new System.Drawing.Size(137, 109);
            this.toEncrypt.TabIndex = 1;
            this.toEncrypt.TextChanged += new System.EventHandler(this.toEncrypt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message to encrypt:";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(407, 274);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(68, 19);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // thePicture
            // 
            this.thePicture.Location = new System.Drawing.Point(19, 10);
            this.thePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thePicture.Name = "thePicture";
            this.thePicture.Size = new System.Drawing.Size(304, 283);
            this.thePicture.TabIndex = 4;
            this.thePicture.TabStop = false;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(339, 10);
            this.fileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(136, 19);
            this.fileButton.TabIndex = 5;
            this.fileButton.Text = "Choose file";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maximum message size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current message size:";
            // 
            // maxSizeLabel
            // 
            this.maxSizeLabel.AutoSize = true;
            this.maxSizeLabel.Location = new System.Drawing.Point(460, 249);
            this.maxSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxSizeLabel.Name = "maxSizeLabel";
            this.maxSizeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxSizeLabel.TabIndex = 8;
            // 
            // currentSizeLabel
            // 
            this.currentSizeLabel.AutoSize = true;
            this.currentSizeLabel.Location = new System.Drawing.Point(460, 223);
            this.currentSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentSizeLabel.Name = "currentSizeLabel";
            this.currentSizeLabel.Size = new System.Drawing.Size(35, 13);
            this.currentSizeLabel.TabIndex = 9;
            this.currentSizeLabel.Text = "label4";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(60, 306);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(136, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "This image is not encrypted";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 383);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.currentSizeLabel);
            this.Controls.Add(this.maxSizeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.thePicture);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toEncrypt);
            this.Controls.Add(this.encryptButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Steganography";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.thePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox toEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.PictureBox thePicture;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxSizeLabel;
        private System.Windows.Forms.Label currentSizeLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}