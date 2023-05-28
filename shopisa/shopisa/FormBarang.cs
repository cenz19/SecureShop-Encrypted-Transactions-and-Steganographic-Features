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
    public partial class FormBarang : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FormBarang_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "");
            if(listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void textBoxBarang_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxBarang.Text == "nama")
            {
                listBarang = Barang.BacaData("product_name", textBoxBarang.Text);
            }
            else if (comboBoxBarang.Text == "harga")
            {
                listBarang = Barang.BacaData("price", textBoxBarang.Text);
            }

            if(listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormTambahBarang frm = new FormTambahBarang();
            frm.Owner = this;
            frm.Show();
        }

        private void comboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCariBedasarkan_Click(object sender, EventArgs e)
        {

        }

        private void labelTransaksiBarang_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelCari_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
