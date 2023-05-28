using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shopisa_LIB
{
    public class Barang
    {
        private int id;
        private string nama;
        private int harga;

        public Barang(int id, string nama, int harga)
        {
            this.Id = id;
            this.Nama = nama;
            this.Harga = harga;
        }

        public Barang(string nama)
        {
            this.nama = nama;
        }

        public int Harga { get => harga; set => harga = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Id { get => id; set => id = value; }

        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if(kriteria == "")
            {
                sql = "select * from tbarang";
            }
            else
            {
                sql = "select * from tbarang where " + kriteria +
                    " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang> listBarang = new List<Barang>();
            while (hasil.Read() == true)
            {
                Barang b = new Barang(int.Parse(hasil["id"].ToString()),
                    hasil["product_name"].ToString(),
                    int.Parse(hasil["price"].ToString()));
                listBarang.Add(b);
            }
            return listBarang;
        }

        public static void TambahData(Barang b)
        {
            string sql = "insert into tbarang(id, product_name, price) values" +
                " ('" + b.Id + "','" + b.Nama.Replace("'","\\'") 
                + "','" + b.harga + "')";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static int GenerateNumber()
        {
            // Ambil nilai maksimum dari id pada tabel
            string sql = "SELECT MAX(id) FROM tbarang";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int maxId = 0;
            if (hasil.Read())
            {
                if (hasil.IsDBNull(0))
                {
                    maxId = 0;
                }
                else
                {
                    maxId = hasil.GetInt32(0);
                }
            }

            int newNumber = maxId + 1;
            return newNumber;
        }

        public override string ToString()
        {
            return Nama;
        }

    }
}
