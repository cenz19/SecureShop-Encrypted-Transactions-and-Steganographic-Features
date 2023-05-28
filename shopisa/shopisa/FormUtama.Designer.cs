
namespace shopisa
{
    partial class FormUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managemenAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beliBarangToolStripBeliBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.historiPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItemDaftarBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarSistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPengguna = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managemenAkunToolStripMenuItem,
            this.beliBarangToolStripBeliBarang,
            this.historiPembelianToolStripMenuItem,
            this.barangToolStripMenuItemDaftarBarang,
            this.keluarSistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1469, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managemenAkunToolStripMenuItem
            // 
            this.managemenAkunToolStripMenuItem.Name = "managemenAkunToolStripMenuItem";
            this.managemenAkunToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.managemenAkunToolStripMenuItem.Text = "Managemen Akun";
            this.managemenAkunToolStripMenuItem.Visible = false;
            this.managemenAkunToolStripMenuItem.Click += new System.EventHandler(this.managemenAkunToolStripMenuItem_Click);
            // 
            // beliBarangToolStripBeliBarang
            // 
            this.beliBarangToolStripBeliBarang.Name = "beliBarangToolStripBeliBarang";
            this.beliBarangToolStripBeliBarang.Size = new System.Drawing.Size(99, 24);
            this.beliBarangToolStripBeliBarang.Text = "Beli Barang";
            this.beliBarangToolStripBeliBarang.Visible = false;
            this.beliBarangToolStripBeliBarang.Click += new System.EventHandler(this.beliBarangToolStripBeliBarang_Click);
            // 
            // historiPembelianToolStripMenuItem
            // 
            this.historiPembelianToolStripMenuItem.Name = "historiPembelianToolStripMenuItem";
            this.historiPembelianToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.historiPembelianToolStripMenuItem.Text = "Histori Pembelian";
            this.historiPembelianToolStripMenuItem.Visible = false;
            this.historiPembelianToolStripMenuItem.Click += new System.EventHandler(this.historiPembelianToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItemDaftarBarang
            // 
            this.barangToolStripMenuItemDaftarBarang.Name = "barangToolStripMenuItemDaftarBarang";
            this.barangToolStripMenuItemDaftarBarang.Size = new System.Drawing.Size(70, 24);
            this.barangToolStripMenuItemDaftarBarang.Text = "Barang";
            this.barangToolStripMenuItemDaftarBarang.Visible = false;
            this.barangToolStripMenuItemDaftarBarang.Click += new System.EventHandler(this.barangToolStripMenuItem1_Click);
            // 
            // keluarSistemToolStripMenuItem
            // 
            this.keluarSistemToolStripMenuItem.Name = "keluarSistemToolStripMenuItem";
            this.keluarSistemToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.keluarSistemToolStripMenuItem.Text = "Keluar Sistem";
            this.keluarSistemToolStripMenuItem.Click += new System.EventHandler(this.keluarSistemToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1017, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anda Login Sebagai :";
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.Location = new System.Drawing.Point(1173, 9);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(41, 17);
            this.labelKode.TabIndex = 2;
            this.labelKode.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // labelPengguna
            // 
            this.labelPengguna.AutoSize = true;
            this.labelPengguna.Location = new System.Drawing.Point(1240, 9);
            this.labelPengguna.Name = "labelPengguna";
            this.labelPengguna.Size = new System.Drawing.Size(114, 17);
            this.labelPengguna.TabIndex = 4;
            this.labelPengguna.Text = "Nama Pengguna";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 646);
            this.Controls.Add(this.labelPengguna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beliBarangToolStripBeliBarang;
        private System.Windows.Forms.ToolStripMenuItem historiPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarSistemToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPengguna;
        private System.Windows.Forms.ToolStripMenuItem managemenAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItemDaftarBarang;
    }
}

