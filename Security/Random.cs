using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.Security
{
    public class Random
    {
        private static Random random = new Random();

        public string Salt()
        {
            string salt = "";
            StringBuilder stringBuilder = new StringBuilder();

            using (RNGCryptoServiceProvider rngC = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[10];
                for (int i = 0; i < 6; i++)
                {
                    rngC.GetBytes(data);
                    char c = (char) data[0];
                    stringBuilder.Append(c);
                }

                salt = stringBuilder.ToString();
            }

            return salt;
        }
    }
}
