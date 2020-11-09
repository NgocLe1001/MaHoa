using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace cryptography
{
    class Des
    {
        public void EncryptFile(string source, string destination, string sKey)
        {
            FileStream fsInput = new FileStream(source,
                                            FileMode.Open,
                                            FileAccess.Read);

            FileStream fsEncrypted = new FileStream(destination,
                                            FileMode.Create,
                                            FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted,
                                            desencrypt,
                                            CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }
        public void DecryptFile(string source, string destination, string sKey)
        {
            if (source.Contains(".txt"))
            {
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                //A 64 bit key and IV is required for this provider.
                //Set secret key For DES algorithm.
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                //Set initialization vector.
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

                //Create a file stream to read the encrypted file back.
                FileStream fsread = new FileStream(source,
                                               FileMode.Open,
                                               FileAccess.Read);
                //Create a DES decryptor from the DES instance.
                ICryptoTransform desdecrypt = DES.CreateDecryptor();
                //Create crypto stream set to read and do a 
                //DES decryption transform on incoming bytes.
                CryptoStream cryptostreamDecr = new CryptoStream(fsread,
                                                             desdecrypt,
                                                             CryptoStreamMode.Read);
                //Print the contents of the decrypted file.
                StreamWriter fsDecrypted = new StreamWriter(destination);
                fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
                fsDecrypted.Flush();
                fsDecrypted.Close();
            }
            else
            {
                FileStream fsInput = new FileStream(source,
                                                    FileMode.Open,
                                                    FileAccess.Read);

                FileStream fsDecrypted = new FileStream(destination,
                                FileMode.Create,
                                FileAccess.Write);

                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = DES.CreateDecryptor();
                CryptoStream cryptostream = new CryptoStream(fsDecrypted,
                                                    desencrypt,
                                                    CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fsInput.Length];
                fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                //cryptostream.Close();
                fsInput.Close();
                fsDecrypted.Close();
            }
        }
    }
}
