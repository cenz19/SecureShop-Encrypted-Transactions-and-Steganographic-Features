using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopisa_LIB;

namespace shopisa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();

                User u = User.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                if (!(u is null))
                {
                    FormUtama frm = (FormUtama)this.Owner;
                    frm.user = u;

                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelSteganography.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxOpenFile.Text);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLenght = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLenght)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;

                    }
                }
            }
            textBoxUsername.Text = message;
            textBoxPassword.Text = message;
        }

        private void radioButtonManual_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonManual.Checked == true)
            {
                radioButtonStegano.Checked = false;
                panelSteganography.Enabled = false;
                panelManual.Enabled = true;
            }
        }

        private void radioButtonStegano_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonStegano.Checked == true)
            {
                radioButtonManual.Checked = false;
                panelSteganography.Enabled = true;
                panelManual.Enabled = false;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png) | *.png";
            openDialog.InitialDirectory = @"C:";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxOpenFile.Text;
            }
        }
    }
}
