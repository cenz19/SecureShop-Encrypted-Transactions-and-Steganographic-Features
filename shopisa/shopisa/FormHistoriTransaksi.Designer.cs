
namespace shopisa
{
    partial class FormHistoriTransaksi
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
            this.textBoxTransaksi = new System.Windows.Forms.TextBox();
            this.comboBoxTransaksi = new System.Windows.Forms.ComboBox();
            this.labelCariBedasarkan = new System.Windows.Forms.Label();
            this.labelTransaksiBarang = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.Lavender;
            this.panelCari.Controls.Add(this.textBoxTransaksi);
            this.panelCari.Controls.Add(this.comboBoxTransaksi);
            this.panelCari.Controls.Add(this.labelCariBedasarkan);
            this.panelCari.Location = new System.Drawing.Point(12, 66);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(776, 70);
            this.panelCari.TabIndex = 9;
            // 
            // textBoxTransaksi
            // 
            this.textBoxTransaksi.Location = new System.Drawing.Point(414, 25);
            this.textBoxTransaksi.Name = "textBoxTransaksi";
            this.textBoxTransaksi.Size = new System.Drawing.Size(330, 22);
            this.textBoxTransaksi.TabIndex = 2;
            this.textBoxTransaksi.TextChanged += new System.EventHandler(this.textBoxTransaksi_TextChanged);
            // 
            // comboBoxTransaksi
            // 
            this.comboBoxTransaksi.FormattingEnabled = true;
            this.comboBoxTransaksi.Items.AddRange(new object[] {
            "tanggal"});
            this.comboBoxTransaksi.Location = new System.Drawing.Point(178, 22);
            this.comboBoxTransaksi.Name = "comboBoxTransaksi";
            this.comboBoxTransaksi.Size = new System.Drawing.Size(219, 24);
            this.comboBoxTransaksi.TabIndex = 1;
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
            // 
            // labelTransaksiBarang
            // 
            this.labelTransaksiBarang.BackColor = System.Drawing.Color.Navy;
            this.labelTransaksiBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksiBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTransaksiBarang.Location = new System.Drawing.Point(12, 11);
            this.labelTransaksiBarang.Name = "labelTransaksiBarang";
            this.labelTransaksiBarang.Size = new System.Drawing.Size(776, 42);
            this.labelTransaksiBarang.TabIndex = 8;
            this.labelTransaksiBarang.Text = "RIWAYAT BELANJA";
            this.labelTransaksiBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(628, 571);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(160, 50);
            this.buttonKeluar.TabIndex = 11;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.RowHeadersWidth = 51;
            this.dataGridViewTransaksi.RowTemplate.Height = 24;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(776, 422);
            this.dataGridViewTransaksi.TabIndex = 10;
            this.dataGridViewTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellContentClick);
            // 
            // FormHistoriTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.labelTransaksiBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewTransaksi);
            this.Name = "FormHistoriTransaksi";
            this.Text = "FormHistoriTransaksi";
            this.Load += new System.EventHandler(this.FormHistoriTransaksi_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxTransaksi;
        private System.Windows.Forms.ComboBox comboBoxTransaksi;
        private System.Windows.Forms.Label labelCariBedasarkan;
        private System.Windows.Forms.Label labelTransaksiBarang;
        private System.Windows.Forms.Button buttonKeluar;
        public System.Windows.Forms.DataGridView dataGridViewTransaksi;
    }
}