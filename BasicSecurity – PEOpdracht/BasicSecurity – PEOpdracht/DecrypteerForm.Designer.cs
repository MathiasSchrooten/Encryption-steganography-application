namespace BasicSecurity___PEOpdracht
{
    partial class DecrypteerForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFileButton = new Ambiance.Ambiance_Button_1();
            this.selectedFileLabel = new Ambiance.Ambiance_Label();
            this.ambianceThemeContainer = new Ambiance.Ambiance_ThemeContainer();
            this.ambianceControlBox = new Ambiance.Ambiance_ControlBox();
            this.toggleABAmbiance = new Ambiance.Ambiance_AB();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.decryptTextBox = new Ambiance.Ambiance_TextBox();
            this.decryptButton = new Ambiance.Ambiance_Button_1();
            this.ambianceThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.Transparent;
            this.selectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectFileButton.Image = null;
            this.selectFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFileButton.Location = new System.Drawing.Point(23, 59);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(440, 59);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            this.selectFileButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.selectFileButton_DragDrop);
            this.selectFileButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.selectFileButton_DragEnter);
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedFileLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectedFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.selectedFileLabel.Location = new System.Drawing.Point(23, 121);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(113, 20);
            this.selectedFileLabel.TabIndex = 2;
            this.selectedFileLabel.Text = "No selected file";
            // 
            // ambianceThemeContainer
            // 
            this.ambianceThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambianceThemeContainer.Controls.Add(this.decryptButton);
            this.ambianceThemeContainer.Controls.Add(this.decryptTextBox);
            this.ambianceThemeContainer.Controls.Add(this.ambiance_Label1);
            this.ambianceThemeContainer.Controls.Add(this.selectedFileLabel);
            this.ambianceThemeContainer.Controls.Add(this.selectFileButton);
            this.ambianceThemeContainer.Controls.Add(this.ambianceControlBox);
            this.ambianceThemeContainer.Controls.Add(this.toggleABAmbiance);
            this.ambianceThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambianceThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambianceThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.ambianceThemeContainer.Name = "ambianceThemeContainer";
            this.ambianceThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambianceThemeContainer.RoundCorners = true;
            this.ambianceThemeContainer.Sizable = true;
            this.ambianceThemeContainer.Size = new System.Drawing.Size(510, 399);
            this.ambianceThemeContainer.SmartBounds = true;
            this.ambianceThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambianceThemeContainer.TabIndex = 3;
            this.ambianceThemeContainer.Text = "Decrypt";
            // 
            // ambianceControlBox
            // 
            this.ambianceControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ambianceControlBox.EnableMaximize = true;
            this.ambianceControlBox.EnableMinimize = true;
            this.ambianceControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambianceControlBox.Location = new System.Drawing.Point(5, 13);
            this.ambianceControlBox.Name = "ambianceControlBox";
            this.ambianceControlBox.Size = new System.Drawing.Size(64, 22);
            this.ambianceControlBox.TabIndex = 10;
            this.ambianceControlBox.Text = "ambiance_ControlBox1";
            // 
            // toggleABAmbiance
            // 
            this.toggleABAmbiance.Location = new System.Drawing.Point(157, 167);
            this.toggleABAmbiance.Name = "toggleABAmbiance";
            this.toggleABAmbiance.Size = new System.Drawing.Size(79, 27);
            this.toggleABAmbiance.TabIndex = 5;
            this.toggleABAmbiance.Text = "ambiance_AB1";
            this.toggleABAmbiance.Toggled = true;
            this.toggleABAmbiance.Type = Ambiance.Ambiance_AB._Type.AB;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(23, 167);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(128, 20);
            this.ambiance_Label1.TabIndex = 11;
            this.ambiance_Label1.Text = "Decrypt as person";
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.BackColor = System.Drawing.Color.Transparent;
            this.decryptTextBox.Enabled = false;
            this.decryptTextBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.decryptTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.decryptTextBox.Location = new System.Drawing.Point(23, 212);
            this.decryptTextBox.MaxLength = 32767;
            this.decryptTextBox.Multiline = true;
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.ReadOnly = false;
            this.decryptTextBox.Size = new System.Drawing.Size(440, 156);
            this.decryptTextBox.TabIndex = 12;
            this.decryptTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.decryptTextBox.UseSystemPasswordChar = false;
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.Transparent;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decryptButton.Image = null;
            this.decryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptButton.Location = new System.Drawing.Point(276, 167);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(177, 30);
            this.decryptButton.TabIndex = 13;
            this.decryptButton.Text = "Decrypt message";
            this.decryptButton.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // DecrypteerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 399);
            this.Controls.Add(this.ambianceThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "DecrypteerForm";
            this.Text = "Decrypt";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambianceThemeContainer.ResumeLayout(false);
            this.ambianceThemeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Ambiance.Ambiance_Button_1 selectFileButton;
        private Ambiance.Ambiance_Label selectedFileLabel;
        private Ambiance.Ambiance_ThemeContainer ambianceThemeContainer;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_ControlBox ambianceControlBox;
        private Ambiance.Ambiance_AB toggleABAmbiance;
        private Ambiance.Ambiance_Button_1 decryptButton;
        private Ambiance.Ambiance_TextBox decryptTextBox;
    }
}