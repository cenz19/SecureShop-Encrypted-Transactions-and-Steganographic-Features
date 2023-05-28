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
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormBarang frm = (FormBarang)this.Owner;
            frm.FormBarang_Load(sender, e);
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Barang b = new Barang(int.Parse(textBoxId.Text), textBoxNama.Text,
                int.Parse(textBoxHarga.Text));
                Barang.TambahData(b);
                MessageBox.Show("Barang sudah tersimpan.", "Info");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Error : " + ex.Message,
                    "Kesalahan");
            }
        }

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            int kodeTerbaru = Barang.GenerateNumber();
            textBoxId.Text = kodeTerbaru.ToString();
        }
    }
}
