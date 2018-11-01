using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.Security
{
    public class Md5Crypto
    {
        public string Md5CryptoService(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string dataCrypto = "";

            using (MD5CryptoServiceProvider md5Crypto = new MD5CryptoServiceProvider())
            {
                byte[] data = md5Crypto.ComputeHash(new UTF8Encoding().GetBytes(inputString));
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                dataCrypto = stringBuilder.ToString();
            }

            return dataCrypto;
        }
    }
}
