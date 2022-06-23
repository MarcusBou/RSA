using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSASender
{
    internal class RSA
    { 
        public RSAParameters SetParameters(string exponent, string modulus)
        {
            RSAParameters parameters = new RSAParameters();
            parameters.Exponent = Encoding.UTF8.GetBytes(exponent);
            parameters.Modulus = Encoding.UTF8.GetBytes(modulus);
            return parameters;
        }

        public byte[] Encrypt(byte[] DataToEncrypt,RSAParameters parames, bool DoOAEPPadding)
        {
            byte[] Data;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(parames);
                Data = rsa.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return Data;
        }
    }
}
