
namespace shopisa
{
    partial class FormBarang
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
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.labelCariBedasarkan = new System.Windows.Forms.Label();
            this.labelTransaksiBarang = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.Lavender;
            this.panelCari.Controls.Add(this.textBoxBarang);
            this.panelCari.Controls.Add(this.comboBoxBarang);
            this.panelCari.Controls.Add(this.labelCariBedasarkan);
            this.panelCari.Location = new System.Drawing.Point(12, 66);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(776, 70);
            this.panelCari.TabIndex = 5;
            this.panelCari.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCari_Paint);
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.Location = new System.Drawing.Point(414, 25);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.Size = new System.Drawing.Size(330, 22);
            this.textBoxBarang.TabIndex = 2;
            this.textBoxBarang.TextChanged += new System.EventHandler(this.textBoxBarang_TextChanged);
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Items.AddRange(new object[] {
            "nama",
            "harga"});
            this.comboBoxBarang.Location = new System.Drawing.Point(178, 22);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(219, 24);
            this.comboBoxBarang.TabIndex = 1;
            this.comboBoxBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarang_SelectedIndexChanged);
            // 
            // labelCariBedasarkan
            // 
            this.labelCariBedasarkan.AutoSize = true;
            this.labelCariBedasarkan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBedasarkan.Location = new System.Drawing.Point(25, 25);
            this.labelCariBedasarkan.Name = "labelCariBedasarkan";
            this.labelCariBedasarkan.Size = new System.Drawing.Size(135, 17);
            this.labelCariBedasarkan.TabIndex = 0;
            this.labelCariBedasarkan.Text = "Cari Berdasarkan :";
            this.labelCariBedasarkan.Click += new System.EventHandler(this.labelCariBedasarkan_Click);
            // 
            // labelTransaksiBarang
            // 
            this.labelTransaksiBarang.BackColor = System.Drawing.Color.Navy;
            this.labelTransaksiBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksiBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTransaksiBarang.Location = new System.Drawing.Point(12, 11);
            this.labelTransaksiBarang.Name = "labelTransaksiBarang";
            this.labelTransaksiBarang.Size = new System.Drawing.Size(776, 42);
            this.labelTransaksiBarang.TabIndex = 4;
            this.labelTransaksiBarang.Text = "DAFTAR BARANG";
            this.labelTransaksiBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTransaksiBarang.Click += new System.EventHandler(this.labelTransaksiBarang_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(628, 390);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(160, 50);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(776, 240);
            this.dataGridViewBarang.TabIndex = 6;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(12, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(237, 50);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Tambah Barang";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.labelTransaksiBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewBarang);
            this.Name = "FormBarang";
            this.Text = "Form Transaksi Barang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxBarang;
        private System.Windows.Forms.ComboBox comboBoxBarang;
        private System.Windows.Forms.Label labelCariBedasarkan;
        private System.Windows.Forms.Label labelTransaksiBarang;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Button buttonAdd;
    }
}