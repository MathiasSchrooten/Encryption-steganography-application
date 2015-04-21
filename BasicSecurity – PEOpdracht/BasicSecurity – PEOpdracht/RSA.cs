using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BasicSecurity___PEOpdracht
{
    class RSA
    {
        // 0 = A
        // 1 = B
        private int persoon = 0;

        public int Persoon
        {
            get { return persoon;}
            set { persoon = value; }
        }

        public String EncrypteerBericht(String message)
        {
            String encryptedDataString = "";

            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data. 
                byte[] dataToEncrypt = System.Text.Encoding.Unicode.GetBytes(message);
                byte[] encryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate 
                //public and private key data. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    //StreamWriter writer = new StreamWriter("PrivateB.txt");
                    //writer.Write(RSA.ToXmlString(true));
                    //writer.Close();

                    //writer = new StreamWriter("PublicB.txt");
                    //writer.Write(RSA.ToXmlString(false));
                    //writer.Close();

                    StreamReader reader;

                    if (persoon == 0)
                    {
                        reader = new StreamReader(Properties.Settings.Default.SharedFolder +  "/Keys/PublicB.txt");
                    }
                    else
                    {
                        reader = new StreamReader(Properties.Settings.Default.SharedFolder + "/Keys/PublicA.txt");
                    }

                    String key = reader.ReadLine();

                    reader.Close();

                    RSA.FromXmlString(key);

                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                    //encryptedData = RSA.Encrypt(dataToEncrypt, false);

                    //Console.WriteLine("Priv key RSA = {0}", RSA.ToXmlString(true)); //Work in progress
                    //Console.WriteLine("Pub key RSA = {0}", RSA.ToXmlString(false)); //Work in progress
                    //Display the encrypted plaintext to the console. 
                    encryptedDataString = Convert.ToBase64String(encryptedData);
                }
            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did 
                //not succeed.
                Console.WriteLine("Encryption failed.");
            }

            return encryptedDataString;
        }

        public String DecrypteerBericht(String encrypted)
        {
            String decryptedDataString = "";
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data. 
                byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate 
                //public and private key data. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    StreamReader reader;

                    if (persoon == 0)
                    {
                        reader = new StreamReader(Properties.Settings.Default.SharedFolder + "/Keys/PrivateA.txt");
                    }
                    else
                    {
                        reader = new StreamReader(Properties.Settings.Default.SharedFolder + "/Keys/PrivateB.txt");
                    }

                    String key = reader.ReadLine();

                    reader.Close();

                    RSA.FromXmlString(key);
                    byte[] Encrbytes = new byte[encrypted.Length * sizeof(char)];
                    System.Buffer.BlockCopy(encrypted.ToCharArray(), 0, Encrbytes, 0, Encrbytes.Length);
                    //Pass the data to DECRYPT, the private key information  
                    //(using RSACryptoServiceProvider.ExportParameters(true), 
                    //and a boolean flag specifying no OAEP padding.
                    decryptedData = RSADecrypt(Encrbytes, RSA.ExportParameters(true), false);

                    //Display the decrypted plaintext to the console. 
                    Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));
                    decryptedDataString = Convert.ToString(decryptedData);
                }
            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did 
                //not succeed.
                Console.WriteLine("Encryption failed.");

            }
            return decryptedDataString;
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs 
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs 
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }
    }
}
