using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    public interface IEncrypt
    {
        string Encrypt(string input);
        string Decrypt(string input);
        string Hash(string input);
    }
}
