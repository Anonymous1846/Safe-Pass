using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    class DataEncryptPassword
    {
        String theTargetPassword;
        String dataHash = "hEy!h@r@#";
        public DataEncryptPassword(String theTargetPassword)
        {
            this.theTargetPassword = theTargetPassword;
        }
        public DataEncryptPassword()
        {
            dataHash = "hEy!h@r@#";
        }
        public String encryptData()
        {
            String theEncryptedString = null;
            //Obtaining Array of Bytes from the String !
            byte[] theByteData = UTF8Encoding.UTF8.GetBytes(theTargetPassword);
            //Using the MD5 Hashing Algorithm
            using (MD5CryptoServiceProvider mD5ServiceProvider=new MD5CryptoServiceProvider())
            {
                byte[] keys = mD5ServiceProvider.ComputeHash(UTF8Encoding.UTF8.GetBytes(dataHash));
                //Triple Data Encryption Standard !
                using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider=new TripleDESCryptoServiceProvider()
                { Key=keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7} )
                {
                    ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
                    byte[] resultBytes = cryptoTransform.TransformFinalBlock(theByteData, 0,theByteData.Length);
                    //The Byte Arrays Converted Back to String !
                    theEncryptedString = Convert.ToBase64String(resultBytes,0,resultBytes.Length);
                }
            }
                return theEncryptedString;
        }
        public String decryptData(String encryptedText)
        {
            String theDecryptedString=null;
            //Obtaining Array of Bytes from the String !
            byte[] theByteData = Convert.FromBase64String(encryptedText);
            //Using the MD5 Hashing Algorithm
            using (MD5CryptoServiceProvider mD5ServiceProvider = new MD5CryptoServiceProvider())
            {
                byte[] keys = mD5ServiceProvider.ComputeHash(UTF8Encoding.UTF8.GetBytes(dataHash));

                //Triple Data Encryption Standard !
                using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
                    byte[] resultBytes = cryptoTransform.TransformFinalBlock(theByteData, 0, theByteData.Length);
                    //The Byte Arrays Converted Back to String !
                    theDecryptedString = UTF8Encoding.UTF8.GetString(resultBytes);
                }
            }
            return theDecryptedString;
        }
    }
}
