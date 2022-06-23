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
            RSAParameters parameters = new RSAParameters {
                Exponent = Convert.FromHexString(exponent.Replace("-", "")),
                Modulus = Convert.FromHexString(modulus.Replace("-", ""))
            };
            
            return parameters;
        }

        public byte[] Encrypt(byte[] DataToEncrypt,RSAParameters parames, bool DoOAEPPadding)
        {
            byte[] Data;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(4096))
            {
                rsa.ImportParameters(parames);
                Data = rsa.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return Data;
        }

        public string ConvertToHexString(string message)
        {
            byte[] mess = Encoding.UTF8.GetBytes(message);
            string hex = Convert.ToHexString(mess);
            return hex;
        }
    }
}
