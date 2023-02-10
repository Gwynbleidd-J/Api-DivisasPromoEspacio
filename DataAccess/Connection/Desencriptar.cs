using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Connection
{
    public class Desencriptar
    {
        public string Desencriptarllave(string cadena)
        {
            Byte[] IV = ASCIIEncoding.ASCII.GetBytes("qualityi");
            Byte[] EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");
            Byte[] buffer = Convert.FromBase64String(cadena);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;
            string regreso = $@"{Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))}";
            return regreso;
        }
    }
}
