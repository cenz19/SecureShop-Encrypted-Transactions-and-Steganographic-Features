using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace shopisa_LIB
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private Jabatan idJabatan;
        

        public User(int id, string username, string password, Jabatan idJabatan)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.idJabatan = idJabatan;
        }

        public User(int id)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Jabatan IdJabatan { get => idJabatan; set => idJabatan = value; }

        public static List<User> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from tuser";
            }
            else
            {
                sql = "select u.id, u.username, u.password, j.role_name " +
                    "from tuser u inner join tjabatan j on u.tRole_id = j.id " +
                    "where " + kriteria +
                    " like '%" + nilaiKriteria + "%'";
            }

            Console.WriteLine("Executing SQL query: " + sql); // Add logging statement

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil == null)
            {
                Console.WriteLine("No rows returned by SQL query."); // Add check for null result set
                return new List<User>();
            }

            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                Jabatan j = new Jabatan(hasil.GetValue(3).ToString());
                User u = new User(int.Parse(hasil.GetValue(0).ToString()),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), j);
                listUser.Add(u);
            }
            return listUser;
        }


        public static Boolean TambahData(User u)
        {
            string sql = "INSERT INTO tuser(id, username, password, tRole_id) VALUES (" +
                         u.Id + ", '" + Encrypt(u.Username.Replace("'", "\\'")) + "', '" +
                         Encrypt(u.Password) + "', " + u.IdJabatan.Id + ")";
            int jumlahDitambahkan = Koneksi.JalankanPerintahDML(sql);
            return jumlahDitambahkan > 0;
        }


        public static User CekLogin(string username, string password)
        {
            string sql = "select U.id, U.username, U.password, U.tRole_id, J.id, J.role_name" +
                " from tuser U inner join tjabatan J on U.tRole_id = J.id" +
                $" where Username='{Encrypt(username)}' AND Password ='{Encrypt(password)}'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Jabatan j = new Jabatan(Convert.ToInt32(hasil["tRole_id"]), hasil["role_name"].ToString());
                User u = new User(Convert.ToInt32(hasil["id"]), hasil["username"].ToString(), hasil["password"].ToString(), j);
                return u;
            }
            return null;
        }

        public static string Encrypt(string text)
        {
            string hash = "ub4y4";
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    string encryptResult = Convert.ToBase64String(result, 0, result.Length);
                    return encryptResult;
                }
            }
        }

        public static string Decrypt(string text)
        {
            string hash = "ub4y4";
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    string decryptResult = UTF8Encoding.UTF8.GetString(result);
                    return decryptResult;
                }
            }
        }


        public static int GenerateNumber()
        {
            // Ambil nilai maksimum dari id pada tabel
            string sql = "SELECT MAX(id) FROM tuser";
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
            return id.ToString();
        }
    }
}
