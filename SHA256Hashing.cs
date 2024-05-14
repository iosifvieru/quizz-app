/*
    Iosif Vieru 2024
    
    Clasa ce implementeaza interfata IEncrypt.

    Metodele decrypt si encrypt sunt neimplementate 
    deoarece aceasta clasa doreste sa implementeze doar hash
    folosind algoritmul SHA256.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    public class SHA256Hashing: IEncrypt
    {

        public SHA256Hashing() { }

        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string input)
        {
            throw new NotImplementedException();
        }

        public string Hash(string input)
        {
            // linia de mai jos creaza un obiect SHA256 din libraria System.Security.Cryptography
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // se calculeaza propriu zis hash-ul stringului de input
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // converteste din byte[] in string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
