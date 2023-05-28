using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopisa_LIB;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;

namespace shopisa
{
    public partial class FormUser : Form
    {
        public List<User> listUser = new List<User>();
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            listUser = User.BacaData("", "");
            if (listUser.Count > 0)
            {
                dataGridViewBarang.DataSource = listUser;
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewBarang.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool errorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = true;
                            MessageBox.Show("Unable to write data to disk " + ex.Message);
                        }
                    }
                    if (!errorMessage)
                    {
                        try
                        {
                            // Specify a font for the table
                            Font font = FontFactory.GetFont("Arial", 8);

                            // Create two tables, one for encrypted data and one for unencrypted data
                            PdfPTable pTableEncrypted = new PdfPTable(dataGridViewBarang.Columns.Count);
                            pTableEncrypted.DefaultCell.Padding = 2;
                            pTableEncrypted.WidthPercentage = 100;
                            pTableEncrypted.HorizontalAlignment = Element.ALIGN_LEFT;

                            PdfPTable pTableUnencrypted = new PdfPTable(dataGridViewBarang.Columns.Count);
                            pTableUnencrypted.DefaultCell.Padding = 2;
                            pTableUnencrypted.WidthPercentage = 100;
                            pTableUnencrypted.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridViewBarang.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font));
                                pTableUnencrypted.AddCell(pCell);
                                PdfPCell pCellEncrypted = new PdfPCell(new Phrase(col.HeaderText, font));
                                pTableEncrypted.AddCell(pCellEncrypted);
                            }

                            foreach (DataGridViewRow viewRow in dataGridViewBarang.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {

                                    pTableEncrypted.AddCell(new Phrase(dcell.Value.ToString(), font));
                                    if (dcell.OwningColumn.Name == "Password" || dcell.OwningColumn.Name == "Username")
                                    {
                                        pTableUnencrypted.AddCell(new Phrase(User.Decrypt(dcell.Value.ToString()), font));
                                    }
                                    else
                                    {
                                        pTableUnencrypted.AddCell(new Phrase(dcell.Value.ToString(), font));
                                    }
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                using (Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f))
                                {
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(new Paragraph("Decrypted Data"));
                                    document.Add(pTableUnencrypted);
                                    document.Add(new Paragraph("Encrypted Data"));
                                    document.Add(pTableEncrypted);
                                }
                                MessageBox.Show("Data exported successfully", "info");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "info");
            }
        }

    }
}
