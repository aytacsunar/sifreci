using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreciAytac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // herhangi birşey olabilir
        //     private const string passPhrase = "1254544";


        // herhangi birşey olabilir
        private const string saltValue = "BiricikKaricimBenim";


        // SHA1 ya da MD5
        private const string hashAlgorithm = "SHA1";


        // herhangi bir sayı olabilir
        private const int passwordIterations = 2;


        // 16 byte olmalı
        private const string initVector = "@1B2c3Dq@5F6x7H8";


        // kaç bit şifreleme?
        private const int keySize = 256;

        private string Sifrele(string plainText, string Anahtar)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(Anahtar, saltValueBytes, hashAlgorithm, passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }


        private string SifreCoz(string cipherText, string Anahtar)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(Anahtar, saltValueBytes, hashAlgorithm, passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

            return plainText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifrelenmismetin = string.Empty;
            try
            {
                sifrelenmismetin = Sifrele(txtSifrelenecekMetin.Text.Trim(), txtAnahtar.Text.Trim());
            }
            catch (Exception)
            {
                sifrelenmismetin = "Beklenmeyen hata oluştu!";
                MessageBox.Show("Hata oluştu!");
            }
            txtSifrelenmisMetin.Text = sifrelenmismetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cozulmusmetin = string.Empty;
            try
            {
                cozulmusmetin = SifreCoz(txtSifreCozulecekMetin.Text.Trim(), txtAnahtar.Text.Trim());
            }
            catch (Exception)
            {
                cozulmusmetin = "Beklenmeyen hata oluştu!";
                MessageBox.Show("Hata oluştu!");
            }
            txtSifreCozulmusMetin.Text = cozulmusmetin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya";
            string okunandosya = string.Empty;
            DialogResult cevap = openFileDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                StreamReader okuyucu = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("UTF-8"));
                okunandosya = okuyucu.ReadToEnd();
                textBox1.Text = openFileDialog1.FileName;
                okuyucu.Close();
            }
            try
            {
                okunandosya = SifreCoz(okunandosya, txtAnahtar.Text.Trim());
            }
            catch (Exception)
            {
                okunandosya = "Beklenmeyen hata oluştu!";
                MessageBox.Show("Hata oluştu!");
            }
            txtDosyaIcerigi.Text = okunandosya;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Dosyayı Kaydet";
            saveFileDialog1.DefaultExt = "txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                StreamWriter DosyaKaydet = new StreamWriter(saveFileDialog1.FileName);
                string sifrelenmisyazi = Sifrele(txtSifreciDosya.Text.Trim(), txtAnahtar.Text.Trim());
                DosyaKaydet.WriteLine(sifrelenmisyazi);
                MessageBox.Show("Dosya Kaydedildi...!!!");
                DosyaKaydet.Close();
                textBox3.Text = saveFileDialog1.FileName;
            }
        }


    }
}
