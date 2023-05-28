using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopisa_LIB;

namespace shopisa
{
    public partial class FormTambahTransaksi : Form
    {
        private User user;
        public List<Barang> listBarang = new List<Barang>();
        public FormTambahTransaksi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTambahTransaksi_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "");

            comboBoxBarang.DataSource = listBarang;
            comboBoxBarang.DisplayMember = "product_name";
            try
            {
                int kodeTerbaru = Transaksi.GenerateNumber();
                textBoxId.Text = kodeTerbaru.ToString();
                textBoxIdPembeli.Text = user.Id.ToString();
                dateTimePickerTanggal.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate kode. Pesan kesalahan : " + ex.Message);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Barang barangDipilih = (Barang)comboBoxBarang.SelectedItem;
                Transaksi t = new Transaksi(int.Parse(textBoxId.Text), dateTimePickerTanggal.Value,
                    user, barangDipilih);
                Transaksi.TambahData(t);
                MessageBox.Show("Transaksi berhasil ditambahkan.", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Error : " + ex.Message,
                    "Kesalahan");
            }
        }

        private void comboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barang barangDipilih = (Barang)comboBoxBarang.SelectedItem;
            labelHarga.Text = barangDipilih.Harga.ToString("C", new CultureInfo("id-ID"));
        }
    }
}
