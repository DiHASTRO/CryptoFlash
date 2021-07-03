using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// Color.FromArgb(41, 215, 255) - голубой
// Color.FromArgb(63, 67, 68) - серый
// Color.FromArgb(82, 239, 107) - зелёный
// Color.FromArgb(223, 48, 48) - красный

namespace CryptoFlash
{
    public partial class Crypto : Form
    {
        string[] driveNames;
        int xForChange;
        int yForChange;
        bool access = false;
        int currentScreen = 0;
        int currentDrive;

        public Crypto()
        {
            InitializeComponent();
            // Screen 0
            this.BackColor = Color.FromArgb(63, 67, 68);
            insertTheKeyLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            insertTheKeyLabel.ForeColor = Color.FromArgb(41, 215, 255);
            
            pressTheKeyLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            pressTheKeyLabel.ForeColor = Color.FromArgb(41, 215, 255);
            
            confirmButton.ButtonRoundRadius = Math.Min(confirmButton.Height, confirmButton.Width);
            confirmButton.BackColor = Color.FromArgb(41, 215, 255);
            confirmButton.BackColor2 = Color.FromArgb(41, 215, 255);
            confirmButton.ForeColor = Color.FromArgb(63, 67, 68);

            reloadButton.BackColor = Color.FromArgb(41, 215, 255);
            reloadButton.BackColor2 = Color.FromArgb(41, 215, 255);

            reloadButton.ForeColor = Color.FromArgb(63, 67, 68);

            // Screen 1
            selectedDriveName.BackColor = Color.FromArgb(41, 215, 255);
            selectedDriveName.ForeColor = Color.FromArgb(63, 67, 68);

            changeDriveLeft.BackColor = Color.FromArgb(41, 215, 255);
            changeDriveLeft.ForeColor = Color.FromArgb(63, 67, 68);

            changeDriveRight.BackColor = Color.FromArgb(41, 215, 255);
            changeDriveRight.ForeColor = Color.FromArgb(63, 67, 68);

            encryptButton.BackColor = Color.FromArgb(223, 48, 48);
            encryptButton.BackColor2 = Color.FromArgb(223, 48, 48);
            encryptButton.ForeColor = Color.FromArgb(63, 67, 68);

            decryptButton.BackColor = Color.FromArgb(82, 239, 107);
            decryptButton.BackColor2 = Color.FromArgb(82, 239, 107);
            decryptButton.ForeColor = Color.FromArgb(63, 67, 68);

            SetScreen(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crypto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (access)
            {
                SetScreen(1);
            } else
            {
                if (Cryptor.CheckKey())
                {
                    KeyImage.Image = CryptoFlash.Properties.Resources.KeyAllowed;

                    insertTheKeyLabel.ForeColor = Color.FromArgb(82, 239, 107);
                    insertTheKeyLabel.Text = "ACCESS ALLOWED";

                    xForChange = this.Size.Width / 2 - insertTheKeyLabel.Size.Width / 2;
                    insertTheKeyLabel.Location = new Point(xForChange, insertTheKeyLabel.Location.Y);

                    pressTheKeyLabel.Text = "";

                    confirmButton.BackColor = Color.FromArgb(82, 239, 107);
                    confirmButton.BackColor2 = Color.FromArgb(82, 239, 107);
                    confirmButton.Text = "GO AHEAD";

                    access = true;
                }
                else
                {
                    KeyImage.Image = CryptoFlash.Properties.Resources.KeyDenied;
                    
                    insertTheKeyLabel.ForeColor = Color.FromArgb(223, 48, 48);
                    insertTheKeyLabel.Text = "ACCESS DENIED";

                    xForChange = this.Size.Width / 2 - insertTheKeyLabel.Size.Width / 2;
                    insertTheKeyLabel.Location = new Point(xForChange, insertTheKeyLabel.Location.Y);

                    pressTheKeyLabel.Text = "";
                    
                    confirmButton.BackColor = Color.FromArgb(223, 48, 48);
                    confirmButton.BackColor2 = Color.FromArgb(223, 48, 48);
                    confirmButton.Text = "TRY AGAIN";
                }
            }
        }

        private void KeyImage_Click(object sender, EventArgs e)
        {

        }

        private void SetScreen(int screenNumber)
        {
            // Setting current screen to the variable
            currentScreen = screenNumber;

            // Disable all items
            insertTheKeyLabel.Visible = false;
            pressTheKeyLabel.Visible = false;
            KeyImage.Visible = false;
            confirmButton.Visible = false;
            selectedDriveName.Visible = false;
            changeDriveLeft.Visible = false;
            changeDriveRight.Visible = false;
            encryptButton.Visible = false;
            decryptButton.Visible = false;

            // Enable the items you want
            if (screenNumber == 0)
            {
                insertTheKeyLabel.Visible = true;
                pressTheKeyLabel.Visible = true;
                KeyImage.Visible = true;
                confirmButton.Visible = true;
            }
            else if (screenNumber == 1)
            {
                insertTheKeyLabel.ForeColor = Color.FromArgb(41, 215, 255);
                insertTheKeyLabel.Text = "SELECT A DRIVE";

                driveNames = Cryptor.GetDrives();
                if (driveNames.Length != 0)
                {
                    selectedDriveName.Text = driveNames[0];
                    currentDrive = 0;

                    changeDriveLeft.BackColor = Color.FromArgb(41, 215, 255);
                    changeDriveRight.BackColor = Color.FromArgb(41, 215, 255);

                    changeDriveLeft.Enabled = true;
                    changeDriveRight.Enabled = true;
                }
                else
                {
                    selectedDriveName.Text = "!!!";

                    pressTheKeyLabel.Text = "THERE IS NO REMOVABLE DRIVES";

                    pressTheKeyLabel.ForeColor = Color.FromArgb(223, 48, 48);
                    pressTheKeyLabel.Visible = true;

                    changeDriveLeft.Enabled = false;
                    changeDriveRight.Enabled = false;

                    changeDriveLeft.BackColor = Color.FromArgb(41 - 25, 215 - 25, 255 - 25);
                    changeDriveRight.BackColor = Color.FromArgb(41 - 25, 215 - 25, 255 - 25);
                }

                xForChange = this.Size.Width / 2 - insertTheKeyLabel.Size.Width / 2;
                insertTheKeyLabel.Location = new Point(xForChange, insertTheKeyLabel.Location.Y);

                insertTheKeyLabel.Visible = true;
                selectedDriveName.Visible = true;
                changeDriveLeft.Visible = true;
                changeDriveRight.Visible = true;
                encryptButton.Visible = true;
                decryptButton.Visible = true;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            SetScreen(currentScreen);
        }

        private void changeDriveLeft_Click(object sender, EventArgs e)
        {
            currentDrive -= 1;
            if (currentDrive < 0)
            {
                currentDrive += driveNames.Length; // Number would negative 1 (-1) then summing gives you number of the last index of the list
            }

            selectedDriveName.Text = driveNames[currentDrive];
        }

        private void changeDriveRight_Click(object sender, EventArgs e)
        {
            currentDrive += 1;
            if (currentDrive > driveNames.Length - 1)
            {
                currentDrive = 0; // Start of the list
            }

            selectedDriveName.Text = driveNames[currentDrive];
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Thread encThread = new Thread(new ThreadStart(encryptionThread));
            encThread.Start();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Thread decThread = new Thread(new ThreadStart(decryptionThread));
            decThread.Start();
        }

        private void encryptionThread()
        {
            this.Invoke((MethodInvoker)delegate
            {
                encryptButton.Enabled = false;
                decryptButton.Enabled = false;

                encryptButton.BackColor = Color.FromArgb(223 - 25, 48 - 25, 48 - 25);
                encryptButton.BackColor2 = Color.FromArgb(223 - 25, 48 - 25, 48 - 25);

                decryptButton.BackColor = Color.FromArgb(82 - 25, 239 - 25, 107 - 25);
                decryptButton.BackColor2 = Color.FromArgb(82 - 25, 239 - 25, 107 - 25);
            });

            Cryptor.Encrypt(driveNames[currentDrive]);

            this.Invoke((MethodInvoker)delegate
            {
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;

                encryptButton.BackColor = Color.FromArgb(223, 48, 48);
                encryptButton.BackColor2 = Color.FromArgb(223, 48, 48);

                decryptButton.BackColor = Color.FromArgb(82, 239, 107);
                decryptButton.BackColor2 = Color.FromArgb(82, 239, 107);
            });
        }

        private void decryptionThread()
        {
            this.Invoke((MethodInvoker)delegate
            {
                encryptButton.Enabled = false;
                decryptButton.Enabled = false;

                encryptButton.BackColor = Color.FromArgb(223 - 25, 48 - 25, 48 - 25);
                encryptButton.BackColor2 = Color.FromArgb(223 - 25, 48 - 25, 48 - 25);

                decryptButton.BackColor = Color.FromArgb(82 - 25, 239 - 25, 107 - 25);
                decryptButton.BackColor2 = Color.FromArgb(82 - 25, 239 - 25, 107 - 25);
            });

            Cryptor.Decrypt(driveNames[currentDrive]);

            this.Invoke((MethodInvoker)delegate
            {
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;

                encryptButton.BackColor = Color.FromArgb(223, 48, 48);
                encryptButton.BackColor2 = Color.FromArgb(223, 48, 48);

                decryptButton.BackColor = Color.FromArgb(82, 239, 107);
                decryptButton.BackColor2 = Color.FromArgb(82, 239, 107);
            });
        }
    }
}
