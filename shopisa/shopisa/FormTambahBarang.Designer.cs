
namespace shopisa
{
    partial class FormTambahBarang
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
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCariBedasarkan = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTransaksiBarang = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panelCari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.Lavender;
            this.panelCari.Controls.Add(this.textBoxHarga);
            this.panelCari.Controls.Add(this.textBoxNama);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Controls.Add(this.label1);
            this.panelCari.Controls.Add(this.textBoxId);
            this.panelCari.Controls.Add(this.labelCariBedasarkan);
            this.panelCari.Location = new System.Drawing.Point(12, 66);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(392, 178);
            this.panelCari.TabIndex = 10;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(100, 129);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(246, 22);
            this.textBoxHarga.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(100, 77);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(246, 22);
            this.textBoxNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(100, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(58, 22);
            this.textBoxId.TabIndex = 2;
            // 
            // labelCariBedasarkan
            // 
            this.labelCariBedasarkan.AutoSize = true;
            this.labelCariBedasarkan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBedasarkan.Location = new System.Drawing.Point(18, 25);
            this.labelCariBedasarkan.Name = "labelCariBedasarkan";
            this.labelCariBedasarkan.Size = new System.Drawing.Size(34, 17);
            this.labelCariBedasarkan.TabIndex = 0;
            this.labelCariBedasarkan.Text = "ID :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(12, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 50);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "&SIMPAN";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTransaksiBarang
            // 
            this.labelTransaksiBarang.BackColor = System.Drawing.Color.Navy;
            this.labelTransaksiBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksiBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTransaksiBarang.Location = new System.Drawing.Point(12, 11);
            this.labelTransaksiBarang.Name = "labelTransaksiBarang";
            this.labelTransaksiBarang.Size = new System.Drawing.Size(392, 42);
            this.labelTransaksiBarang.TabIndex = 9;
            this.labelTransaksiBarang.Text = "TAMBAH BARANG";
            this.labelTransaksiBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(244, 262);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(160, 50);
            this.buttonKeluar.TabIndex = 12;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 328);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTransaksiBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormTambahBarang";
            this.Text = "FormTambahBarang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelCariBedasarkan;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTransaksiBarang;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}