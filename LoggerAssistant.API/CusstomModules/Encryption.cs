using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAssistant.API.CusstomModules
{
    public class Encryption
    {
        private readonly HMACSHA512 _sha = new HMACSHA512(Encoding.UTF8.GetBytes("VerySecure")); // TODO: Move secret key into appsettings.json

        public byte[] Hash(string password, byte[] salt)
        {
            var bytes = Encoding.UTF8.GetBytes(password);

            var allBytes = new byte[bytes.Length + salt.Length];
            Buffer.BlockCopy(bytes, 0, allBytes, 0, bytes.Length);
            Buffer.BlockCopy(salt, 0, allBytes, bytes.Length, salt.Length);

            return _sha.ComputeHash(allBytes);
        }
    }
}
