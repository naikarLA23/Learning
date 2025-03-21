//*********************************************************************************************************************************
// File Name			:	EncryptionHandler.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

using System.Security.Cryptography;
using System.Text;

namespace Encryptor
{
    public class EncryptionHandler
    {
        readonly static string  _publickey = "PKey0212";
        readonly static string  _secretkey = "SKey2022";

        public static string Encrypt(string plainText)
        {
            string encryptedText = string.Empty;

            try
            {
    
                byte[] secretkeyByte = Array.Empty<byte>();
                secretkeyByte = Encoding.UTF8.GetBytes(_secretkey);
                byte[] publickeybyte = Array.Empty<byte>();
                publickeybyte = Encoding.UTF8.GetBytes(_publickey);
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(plainText);
                using (DESCryptoServiceProvider desCrptoSerPro = new())
                {
                    MemoryStream memoryStream = new();
                    CryptoStream cryptoSTream = new(memoryStream, 
                                                    desCrptoSerPro.CreateEncryptor(publickeybyte, secretkeyByte), 
                                                    CryptoStreamMode.Write);

                    cryptoSTream.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cryptoSTream.FlushFinalBlock();
                    encryptedText = Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.InnerException);
            }
            return encryptedText;
        }

        public static string Decrypt(string encryptedText)
        {
            string decryptedText = string.Empty;

            try
            {
                byte[] privatekeyByte = Array.Empty<byte>();
                privatekeyByte = Encoding.UTF8.GetBytes(_secretkey);
                byte[] publickeybyte = Array.Empty<byte>();
                publickeybyte = Encoding.UTF8.GetBytes(_publickey);

                byte[] inputbyteArray = new byte[encryptedText.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(encryptedText.Replace(" ", "+"));
                using (DESCryptoServiceProvider desCrptoSerPro = new())
                {
                    MemoryStream memoryStream  = new();
                    CryptoStream cryptoSTream = new(memoryStream,
                                                    desCrptoSerPro.CreateDecryptor(publickeybyte, privatekeyByte),
                                                    CryptoStreamMode.Write);

                    cryptoSTream.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cryptoSTream.FlushFinalBlock();
                    decryptedText = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, e.InnerException);
            }
            return decryptedText;
        }
    }
}
