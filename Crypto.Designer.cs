using System;

namespace CryptoFlash
{
    partial class Crypto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypto));
            this.insertTheKeyLabel = new System.Windows.Forms.Label();
            this.pressTheKeyLabel = new System.Windows.Forms.Label();
            this.selectedDriveName = new System.Windows.Forms.Label();
            this.changeDriveLeft = new System.Windows.Forms.Button();
            this.changeDriveRight = new System.Windows.Forms.Button();
            this.KeyImage = new System.Windows.Forms.PictureBox();
            this.encryptButton = new CryptoFlash.RoundButton();
            this.decryptButton = new CryptoFlash.RoundButton();
            this.reloadButton = new CryptoFlash.RoundButton();
            this.confirmButton = new CryptoFlash.RoundButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // insertTheKeyLabel
            // 
            this.insertTheKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertTheKeyLabel.AutoSize = true;
            this.insertTheKeyLabel.Font = new System.Drawing.Font("Sowjetschablone", 55F);
            this.insertTheKeyLabel.Location = new System.Drawing.Point(162, 9);
            this.insertTheKeyLabel.Name = "insertTheKeyLabel";
            this.insertTheKeyLabel.Size = new System.Drawing.Size(506, 78);
            this.insertTheKeyLabel.TabIndex = 2;
            this.insertTheKeyLabel.Text = "INSERT THE KEY";
            this.insertTheKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insertTheKeyLabel.Visible = false;
            this.insertTheKeyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pressTheKeyLabel
            // 
            this.pressTheKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pressTheKeyLabel.Font = new System.Drawing.Font("Sowjetschablone", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressTheKeyLabel.Location = new System.Drawing.Point(12, 97);
            this.pressTheKeyLabel.Name = "pressTheKeyLabel";
            this.pressTheKeyLabel.Size = new System.Drawing.Size(786, 40);
            this.pressTheKeyLabel.TabIndex = 3;
            this.pressTheKeyLabel.Text = "THEN PRESS THE KEY";
            this.pressTheKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressTheKeyLabel.Visible = false;
            // 
            // selectedDriveName
            // 
            this.selectedDriveName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDriveName.Font = new System.Drawing.Font("Sowjetschablone", 50F);
            this.selectedDriveName.Location = new System.Drawing.Point(349, 161);
            this.selectedDriveName.Name = "selectedDriveName";
            this.selectedDriveName.Size = new System.Drawing.Size(124, 124);
            this.selectedDriveName.TabIndex = 5;
            this.selectedDriveName.Text = ":\\D";
            this.selectedDriveName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectedDriveName.Visible = false;
            this.selectedDriveName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // changeDriveLeft
            // 
            this.changeDriveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDriveLeft.FlatAppearance.BorderSize = 0;
            this.changeDriveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDriveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.changeDriveLeft.Location = new System.Drawing.Point(302, 187);
            this.changeDriveLeft.Name = "changeDriveLeft";
            this.changeDriveLeft.Size = new System.Drawing.Size(41, 73);
            this.changeDriveLeft.TabIndex = 6;
            this.changeDriveLeft.Text = "◂";
            this.changeDriveLeft.UseVisualStyleBackColor = true;
            this.changeDriveLeft.Visible = false;
            this.changeDriveLeft.Click += new System.EventHandler(this.changeDriveLeft_Click);
            // 
            // changeDriveRight
            // 
            this.changeDriveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDriveRight.FlatAppearance.BorderSize = 0;
            this.changeDriveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDriveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.changeDriveRight.Location = new System.Drawing.Point(479, 187);
            this.changeDriveRight.Name = "changeDriveRight";
            this.changeDriveRight.Size = new System.Drawing.Size(41, 73);
            this.changeDriveRight.TabIndex = 7;
            this.changeDriveRight.Text = "▸";
            this.changeDriveRight.UseVisualStyleBackColor = true;
            this.changeDriveRight.Visible = false;
            this.changeDriveRight.Click += new System.EventHandler(this.changeDriveRight_Click);
            // 
            // KeyImage
            // 
            this.KeyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyImage.Image = global::CryptoFlash.Properties.Resources.Key;
            this.KeyImage.Location = new System.Drawing.Point(12, 161);
            this.KeyImage.Name = "KeyImage";
            this.KeyImage.Size = new System.Drawing.Size(786, 124);
            this.KeyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyImage.TabIndex = 0;
            this.KeyImage.TabStop = false;
            this.KeyImage.Visible = false;
            this.KeyImage.WaitOnLoad = true;
            this.KeyImage.Click += new System.EventHandler(this.KeyImage_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptButton.BackColor = System.Drawing.Color.Gainsboro;
            this.encryptButton.BackColor2 = System.Drawing.Color.Silver;
            this.encryptButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.encryptButton.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.encryptButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.encryptButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.encryptButton.ButtonPressedColor = System.Drawing.Color.Red;
            this.encryptButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.encryptButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.encryptButton.ButtonRoundRadius = 30;
            this.encryptButton.Font = new System.Drawing.Font("Sowjetschablone", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.Location = new System.Drawing.Point(81, 353);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(262, 85);
            this.encryptButton.TabIndex = 11;
            this.encryptButton.Text = "ENCRYPT";
            this.encryptButton.Visible = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptButton.BackColor = System.Drawing.Color.Gainsboro;
            this.decryptButton.BackColor2 = System.Drawing.Color.Silver;
            this.decryptButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.decryptButton.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.decryptButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.decryptButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.decryptButton.ButtonPressedColor = System.Drawing.Color.Red;
            this.decryptButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.decryptButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.decryptButton.ButtonRoundRadius = 30;
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.decryptButton.Font = new System.Drawing.Font("Sowjetschablone", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(479, 353);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(262, 85);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "DECRYPT";
            this.decryptButton.Visible = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Gainsboro;
            this.reloadButton.BackColor2 = System.Drawing.Color.Silver;
            this.reloadButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.reloadButton.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.reloadButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.reloadButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.reloadButton.ButtonPressedColor = System.Drawing.Color.Red;
            this.reloadButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.reloadButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.reloadButton.ButtonRoundRadius = 30;
            this.reloadButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.reloadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reloadButton.Location = new System.Drawing.Point(765, 0);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reloadButton.Size = new System.Drawing.Size(43, 42);
            this.reloadButton.TabIndex = 8;
            this.reloadButton.Text = "⟳";
            this.reloadButton.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BackColor = System.Drawing.Color.Gainsboro;
            this.confirmButton.BackColor2 = System.Drawing.Color.Silver;
            this.confirmButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.confirmButton.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.confirmButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.confirmButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.confirmButton.ButtonPressedColor = System.Drawing.Color.Red;
            this.confirmButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.confirmButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.confirmButton.ButtonRoundRadius = 30;
            this.confirmButton.Font = new System.Drawing.Font("Sowjetschablone", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.Location = new System.Drawing.Point(274, 353);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(262, 85);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.changeDriveRight);
            this.Controls.Add(this.changeDriveLeft);
            this.Controls.Add(this.selectedDriveName);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.pressTheKeyLabel);
            this.Controls.Add(this.insertTheKeyLabel);
            this.Controls.Add(this.KeyImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 503);
            this.MinimumSize = new System.Drawing.Size(830, 503);
            this.Name = "Crypto";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Crypto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KeyImage;
        private System.Windows.Forms.Label insertTheKeyLabel;
        private System.Windows.Forms.Label pressTheKeyLabel;
        private RoundButton confirmButton;
        private System.Windows.Forms.Label selectedDriveName;
        private System.Windows.Forms.Button changeDriveLeft;
        private System.Windows.Forms.Button changeDriveRight;
        private RoundButton reloadButton;
        private RoundButton decryptButton;
        private RoundButton encryptButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}