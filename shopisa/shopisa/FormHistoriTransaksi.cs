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
    public partial class FormHistoriTransaksi : Form
    {
        private User user;
        public List<Transaksi> listTransaksi = new List<Transaksi>();
        public FormHistoriTransaksi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHistoriTransaksi_Load(object sender, EventArgs e)
        {

            labelTransaksiBarang.Text = "RIWAYAT BELANJA (User ID : " + user.Id +")";
            listTransaksi = Transaksi.BacaData("", "", user.Id);
            if (listTransaksi.Count > 0)
            {
                dataGridViewTransaksi.DataSource = listTransaksi;
            }
            else
            {
                dataGridViewTransaksi.DataSource = null;
            }
        }

        private void dataGridViewTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTransaksi_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTransaksi.Text == "tanggal")
            {
                listTransaksi = Transaksi.BacaData("n.tanggal", textBoxTransaksi.Text, user.Id);
            }

            if (listTransaksi.Count > 0)
            {
                dataGridViewTransaksi.DataSource = listTransaksi;
            }
            else
            {
                dataGridViewTransaksi.DataSource = null;
            }
        }
    }
}
