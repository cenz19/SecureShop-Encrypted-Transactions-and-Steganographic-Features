
namespace shopisa
{
    partial class FormTambahTransaksi
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
            this.panelCari = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCariBedasarkan = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTransaksiBarang = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdPembeli = new System.Windows.Forms.TextBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.panelCari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.Lavender;
            this.panelCari.Controls.Add(this.labelHarga);
            this.panelCari.Controls.Add(this.textBoxIdPembeli);
            this.panelCari.Controls.Add(this.label5);
            this.panelCari.Controls.Add(this.dateTimePickerTanggal);
            this.panelCari.Controls.Add(this.label3);
            this.panelCari.Controls.Add(this.comboBoxBarang);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Controls.Add(this.label1);
            this.panelCari.Controls.Add(this.textBoxId);
            this.panelCari.Controls.Add(this.labelCariBedasarkan);
            this.panelCari.Location = new System.Drawing.Point(13, 64);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(392, 288);
            this.panelCari.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanggal :";
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(123, 166);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(223, 24);
            this.comboBoxBarang.TabIndex = 7;
            this.comboBoxBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barang :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(123, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(58, 22);
            this.textBoxId.TabIndex = 2;
            // 
            // labelCariBedasarkan
            // 
            this.labelCariBedasarkan.AutoSize = true;
            this.labelCariBedasarkan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBedasarkan.Location = new System.Drawing.Point(18, 28);
            this.labelCariBedasarkan.Name = "labelCariBedasarkan";
            this.labelCariBedasarkan.Size = new System.Drawing.Size(99, 17);
            this.labelCariBedasarkan.TabIndex = 0;
            this.labelCariBedasarkan.Text = "ID Transaksi:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(13, 358);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 50);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "&BELI";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTransaksiBarang
            // 
            this.labelTransaksiBarang.BackColor = System.Drawing.Color.Navy;
            this.labelTransaksiBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksiBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTransaksiBarang.Location = new System.Drawing.Point(12, 9);
            this.labelTransaksiBarang.Name = "labelTransaksiBarang";
            this.labelTransaksiBarang.Size = new System.Drawing.Size(392, 42);
            this.labelTransaksiBarang.TabIndex = 14;
            this.labelTransaksiBarang.Text = "BELI BARANG";
            this.labelTransaksiBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(245, 358);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(160, 50);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Enabled = false;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(123, 119);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Pembeli:";
            // 
            // textBoxIdPembeli
            // 
            this.textBoxIdPembeli.Enabled = false;
            this.textBoxIdPembeli.Location = new System.Drawing.Point(123, 72);
            this.textBoxIdPembeli.Name = "textBoxIdPembeli";
            this.textBoxIdPembeli.Size = new System.Drawing.Size(58, 22);
            this.textBoxIdPembeli.TabIndex = 14;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(122, 218);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(54, 17);
            this.labelHarga.TabIndex = 15;
            this.labelHarga.Text = "Rp 0 ,-";
            // 
            // FormTambahTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTransaksiBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormTambahTransaksi";
            this.Text = "Form Tambah Transaksi";
            this.Load += new System.EventHandler(this.FormTambahTransaksi_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelCariBedasarkan;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTransaksiBarang;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBarang;
        private System.Windows.Forms.TextBox textBoxIdPembeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Label labelHarga;
    }
}