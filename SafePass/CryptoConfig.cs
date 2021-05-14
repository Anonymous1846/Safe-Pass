using System;
using System.Text;
using System.Security.Cryptography;//methods for crypto and hashing (SHA256)

namespace SafePass
{
    class CryptoConfig
    {
        String theTargetPassword;
        AesCryptoServiceProvider aesCryptoServiceProvider;
        public CryptoConfig(String theTargetPassword)
        {
            aesCryptoServiceProvider = new AesCryptoServiceProvider();
            this.theTargetPassword = theTargetPassword;
            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = 256;
            aesCryptoServiceProvider.Mode = CipherMode.CBC;
            aesCryptoServiceProvider.Key = ASCIIEncoding.ASCII.GetBytes("q1Q@W#e4r5tVh*90OkN&7^56ybCVxzX0");
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            aesCryptoServiceProvider.IV= ASCIIEncoding.ASCII.GetBytes("yU8912@3$%fGVCer");
        }
        
        //used for obtaining the sha256 digest for the user master password !
        public string getHashedData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            //similar to context mgr in  python !
            using (SHA256 sha256hash = SHA256.Create())
            {
                //computing to bytes array !
                byte[] BytesStream = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(theTargetPassword));
                //convert bytes array to string!
                
                for (int i =0;i<BytesStream.Length;i++)
                {
                    stringBuilder.Append(BytesStream[i].ToString("x2"));
                }
            }
                return stringBuilder.ToString();
        }
        public String encryptData()
        {
            ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor();
            byte[] enc_bytes = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(theTargetPassword), 0, theTargetPassword.Length);
            string encryptedData = Convert.ToBase64String(enc_bytes);
            return encryptedData;
        }
        public String getDecryptedData()
        {

            ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor();
            byte[] dec_bytes = Convert.FromBase64String(theTargetPassword);
            byte[] decBytes = cryptoTransform.TransformFinalBlock(dec_bytes,0,dec_bytes.Length);
            string decryptedText = ASCIIEncoding.ASCII.GetString(decBytes);
            return decryptedText;
        }
    }
}
