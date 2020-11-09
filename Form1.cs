using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string OpenDialog()
        {
            string filePath = "";
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            txtFilePathSave.Clear();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                txtFilePath.Text = openFileDialog1.FileName;
                txtFilePathSave.Text = openFileDialog1.FileName.Replace(".", "_Encrypt.");
                rbtnAes.Checked = false;
                rbtnRsa.Checked = false;
                rbtnDes.Checked = false;
            }
            return filePath;
        }


        #region SHA1 Hash Function
        public string GetSha1Hash(string filePath)
        {
            using (FileStream fs = File.OpenRead(filePath))
            {
                SHA1 sha = new SHA1Managed();
                return Convert.ToBase64String(sha.ComputeHash(fs));
            }
        }
        #endregion

        #region MD5 Hash function
        public static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        #endregion

        #region Choose file to encrypt or decrypt
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            txtFileComparePath.Clear();
            txtHashMD5Result2.Clear();
            txtHashSHA1Result2.Clear();
            string filePath = OpenDialog();
            string hashedSHA1 = GetSha1Hash(filePath);
            string hashedMD5 = CalculateMD5(filePath);
            txtHashSHA1Result1.Text = hashedSHA1;
            txtHashMD5Result1.Text = hashedMD5;
        }
        #endregion

        Rsa rsa = new Rsa();
        Aes aes = new Aes();
        Des des = new Des();

        #region Encryption
        private void btnEncypt_Click(object sender, EventArgs e)
        {
            if (rbtnAes.Checked)
            {
                aes.EncryptFile(txtFilePath.Text, txtFilePathSave.Text, txtKeyAes.Text);
            }
            else if (rbtnRsa.Checked)
            {
                txtCrypt.Text = rsa.Encrypt1(txtFilePath.Text);
            }
            else if (rbtnDes.Checked)
            {
                des.EncryptFile(txtFilePath.Text, txtFilePathSave.Text, txtKeyDes.Text);
            }
            else
            {
                MessageBox.Show("Please select method of encryption !");
            }
        }
        #endregion

        #region Decryption
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rbtnAes.Checked)
            {
                aes.DecryptFile(txtFilePath.Text, txtFilePathSave.Text, txtKeyAes.Text);
            }
            else if (rbtnRsa.Checked)
            {
                rsa.Decrypt1(txtCrypt.Text, txtFilePath.Text);
            }
            else if (rbtnDes.Checked)
            {
                des.DecryptFile(txtFilePath.Text, txtFilePathSave.Text, txtKeyDes.Text);
            }
            else
            {
                MessageBox.Show("Please select method of Decryption !");
            }
        }
        #endregion

        #region Compare the result of hash function
        private void btnCompareHashFnc_Click(object sender, EventArgs e)
        {
            string filePath = "";
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            txtFilePathSave.Clear();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                txtFileComparePath.Text = openFileDialog1.FileName;
                rbtnAes.Checked = false;
                rbtnRsa.Checked = false;
                rbtnDes.Checked = false;
                string hashedSHA1 = GetSha1Hash(filePath);
                string hashedMD5 = CalculateMD5(filePath);
                txtHashSHA1Result2.Text = hashedSHA1;
                txtHashMD5Result2.Text = hashedMD5;
            }
            if(txtHashSHA1Result1.Text==txtHashSHA1Result2.Text  && txtHashMD5Result1.Text==txtHashMD5Result2.Text)
            {
                MessageBox.Show("Both SHA1 and MD5 hash result are the same value !");
            }
            else if (txtHashSHA1Result1.Text == txtHashSHA1Result2.Text && txtHashMD5Result1.Text != txtHashMD5Result2.Text)
            {
                MessageBox.Show(" SHA1  hash result are the same value but MD5 is not !");
            }
            else if (txtHashSHA1Result1.Text != txtHashSHA1Result2.Text && txtHashMD5Result1.Text == txtHashMD5Result2.Text)
            {
                MessageBox.Show(" MD5  hash result are the same value but SHA1 is not !");
            }
            else
            {
                MessageBox.Show("Both SHA1 and MD5 hash result are different value !");
            }
        }

        #endregion

        #region MD5 Hash function Of Vũ, Tài,T.Anh nhưng khi ghép với bài các bạn em thấy lỗi nên sử dụng tạm hàm khác ạ,thầy review trước em contact với các bạn sau ạ
        //public static string MD5Hash(string input)
        //{
        //    StringBuilder hash = new StringBuilder();
        //    MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        //    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));          
        //    for (int i = 0; i < bytes.Length; i++)
        //    {
        //        hash.Append(bytes[i].ToString("x2"));
        //    }
        //    return hash.ToString();
        //}
        //public static string MD5Hash(byte[] input)
        //{
        //    StringBuilder hash = new StringBuilder();
        //    MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        //    byte[] bytes = md5provider.ComputeHash(input);
        //    for (int i = 0; i < bytes.Length; i++)
        //    {
        //        hash.Append(bytes[i].ToString("x2"));
        //    }
        //    return hash.ToString();
        //}
        #endregion

        
    }
}
