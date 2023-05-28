using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shopisa_LIB
{
    public class Transaksi
    {
        private int id;
        private DateTime tanggal;
        private User userId;
        private Barang barangId;

        public Transaksi(int id, DateTime tanggal, User userId, Barang barangId)
        {
            this.id = id;
            this.tanggal = tanggal;
            this.userId = userId;
            this.barangId = barangId;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public User UserId { get => userId; set => userId = value; }
        public Barang BarangId { get => barangId; set => barangId = value; }

        public static List<Transaksi> BacaData(string kriteria, string nilaiKriteria, int idUser)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT * FROM tnotabeli WHERE tUser_id=" + idUser;
            }
            else
            {
                sql = "SELECT n.id, n.tanggal, u.id, b.id " +
                    "FROM tnotabeli n " +
                    "INNER JOIN tuser u ON n.tUser_id = u.id " +
                    "INNER JOIN tbarang b ON n.tBarang_id = b.id " +
                    "WHERE n.tUser_id =" + idUser + " AND " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Transaksi> listTransaksi = new List<Transaksi>();
            while (hasil.Read() == true)
            {
                User u = new User(int.Parse(hasil.GetValue(2).ToString()));

                Barang b = new Barang(hasil.GetValue(3).ToString());

                Transaksi t = new Transaksi(int.Parse(hasil.GetValue(0).ToString()),
                                            DateTime.Parse(hasil.GetValue(1).ToString()), u, b);

                listTransaksi.Add(t);
            }
            return listTransaksi;
        }

        public static void TambahData(Transaksi t)
        {
            string sql = "INSERT INTO tnotabeli(tanggal, tUser_id, tBarang_id) VALUES ('" + t.Tanggal.ToString("yyyy-MM-dd") + "', " + t.UserId.Id + ", " + t.BarangId.Id + ")";
            Koneksi.JalankanPerintahDML(sql);
        }


        public static int GenerateNumber()
        {
            // Ambil nilai maksimum dari id pada tabel
            string sql = "SELECT MAX(id) FROM tnotabeli";
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
    }
}
