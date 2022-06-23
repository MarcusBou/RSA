using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAReceiver
{
    internal class RSA
    {
        private RSACryptoServiceProvider rsa;
        private RSAParameters rsaParameters;
        public RSAParameters RSAParameters { get { return rsaParameters; } }
        public RSA()
        {
            this.rsa = new RSACryptoServiceProvider(4096);
            this.rsaParameters = this.rsa.ExportParameters(false);
        }

        
        public byte[] Decrypt(byte[] DataToEncrypt, bool DoOAEPPadding)
        {
            byte[] Data;
            Console.WriteLine(rsa.KeySize);
            Console.WriteLine(DataToEncrypt.Length);
            Data = rsa.Decrypt(DataToEncrypt, DoOAEPPadding);
            return Data;
        }
    }
}