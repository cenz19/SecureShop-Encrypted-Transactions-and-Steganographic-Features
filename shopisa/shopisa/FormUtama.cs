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
    public partial class FormUtama : Form
    {
        public User user;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi();
                FormLogin frm = new FormLogin();
                frm.Owner = this;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    labelKode.Text = user.Id.ToString();
                    labelPengguna.Text = User.Decrypt(user.Username);
                    switch (user.IdJabatan.Id)
                    {
                        case 1:
                            managemenAkunToolStripMenuItem.Visible = true;
                            break;
                        case 2:
                            beliBarangToolStripBeliBarang.Visible = true;
                            historiPembelianToolStripMenuItem.Visible = true;
                            break;
                        case 3:
                            barangToolStripMenuItemDaftarBarang.Visible = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Gagal Login");
                    Application.Exit();
                }

                MessageBox.Show("Koneksi berhasil", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            }
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBarang"];

            if (form == null)
            {
                FormBarang frm = new FormBarang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void beliBarangToolStripBeliBarang_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahTransaksi"];

            if (form == null)
            {
                FormTambahTransaksi frm = new FormTambahTransaksi(user);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void historiPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormHistoriTransaksi"];

            if (form == null)
            {
                FormHistoriTransaksi frm = new FormHistoriTransaksi(user);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void managemenAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormUser"];
            if (form == null)
            {
                FormUser frm = new FormUser();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
