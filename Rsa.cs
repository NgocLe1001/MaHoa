using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace cryptography
{
    class Rsa
    {
        public static byte[] fileToByte(string inputFile)
        {
            FileStream stream = File.OpenRead(inputFile);
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();
            return fileBytes;
        }
        public static void ByteToFile(byte[] fileBytes, string outputFile)
        {
            using (Stream file = File.OpenWrite(outputFile))
            {
                file.Write(fileBytes, 0, fileBytes.Length);
            }
        }
       
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }
        //giải mã
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }
       
        RSACryptoServiceProvider rsaClient = new RSACryptoServiceProvider(2048);
        public string Encrypt1(string inputFile)
        {
            byte[] file_byte = fileToByte(inputFile);

            int length = file_byte.Length;
            string cypher = "";
            int startPoint = 0;
            while (startPoint < (length - 241))
            {
                byte[] segment = new ArraySegment<byte>(file_byte, startPoint, 241).ToArray();
                startPoint += 241;
                byte[] encrypted = rsaClient.Encrypt(segment, false);
                cypher += Convert.ToBase64String(encrypted) + "|";
            }
            byte[] segment1 = new ArraySegment<byte>(file_byte, startPoint, length - startPoint).ToArray();
            byte[] encrypted1 = rsaClient.Encrypt(segment1, false);
            cypher += Convert.ToBase64String(encrypted1);
            return cypher;
        }
        public void Decrypt1(string cypher, string outputFile)
        {
            List<byte> testplains = new List<byte>();
            string[] test = cypher.Split('|');

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != string.Empty && test[i] != "")
                {
                    byte[] a = Convert.FromBase64String(test[i]);
                    var plain = rsaClient.Decrypt(a, false);
                    testplains.AddRange(plain);
                }
            }
            ByteToFile(testplains.ToArray(), outputFile);
        }
    
    }
}
