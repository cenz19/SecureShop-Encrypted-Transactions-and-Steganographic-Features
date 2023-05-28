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
    public partial class FormRegister : Form
    {
        public List<Jabatan> listJabatan = new List<Jabatan>();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            panelSteganography.Enabled = false;
            //tampilkan semua jabatan yang ada di tabel jabatan
            listJabatan = Jabatan.BacaData("", "");

            //isikan ke comboBoxJabatan
            comboBoxJabatan.DataSource = listJabatan;
            comboBoxJabatan.DisplayMember = "role_name";
            try
            {
                int kodeTerbaru = User.GenerateNumber();
                textBoxid.Text = kodeTerbaru.ToString();
                textBoxUsername.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate kode. Pesan kesalahan : " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxUlangPassword.Text)
            {
                try
                {
                    Jabatan jabatanDipilih = (Jabatan)comboBoxJabatan.SelectedItem;
                    User u = new User(int.Parse(textBoxid.Text), textBoxUsername.Text, textBoxPassword.Text, jabatanDipilih);

                    Boolean status = User.TambahData(u);
                    if (status == true)
                    {
                        MessageBox.Show("Data berhasil ditambahkan");
                    }
                    else
                    {
                        MessageBox.Show("Data gagal ditambahkan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan. Pesan Kesalahan: " + ex.Message, "Kesalahan");
                }
            }
            else
            {
                MessageBox.Show("Password yang dimasukan tidak sama !");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxOpenFile.Text);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < textBoxEnterMessage.TextLength)
                    {
                        Console.WriteLine("R=[" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G=[" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B=[" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(textBoxEnterMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter : " + letter + " value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxEnterMessage.TextLength));
                    }
                }
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png) | *.png";
            saveFile.InitialDirectory = @"C:";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxOpenFile.Text;

                img.Save(textBoxOpenFile.Text);
            }
            string text = textBoxEnterMessage.Text;
            textBoxUsername.Text = text;
            textBoxPassword.Text = text;
            textBoxUlangPassword.Text = text;
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
                panelManual.Enabled = false;
                panelSteganography.Enabled = true;
            }
        }
    }
}
