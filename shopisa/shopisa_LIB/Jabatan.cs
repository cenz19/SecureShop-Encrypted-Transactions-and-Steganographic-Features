using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shopisa_LIB
{
    public class Jabatan
    {
        private int id;
        private string nama;

        public Jabatan(string nama)
        {
            this.nama = nama;
        }

        public Jabatan(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public static List<Jabatan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")//jika tidak ada kriteria yang diisikan
            {
                sql = "Select * from tjabatan";
            }
            else
            {
                sql = "select * from tjabatan where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Jabatan> listJabatan = new List<Jabatan>();
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Jabatan j = new Jabatan(int.Parse(hasil["id"].ToString()), hasil["role_name"].ToString());
                listJabatan.Add(j);
            }
            return listJabatan;
        }
        public override string ToString()
        {
            return Nama;
        }
    }
}
