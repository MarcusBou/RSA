using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAReceiver
{
    
    internal class Gui
    {
        RSA rsa;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public Gui()
        {
            rsa = new RSA();
            Start();
        }

        private void Start()
        {
            Console.WriteLine("Copy and paste the text into sender!");
            Console.WriteLine("Encoding.Unicode.GetString: " + Convert.ToHexString(rsa.RSAParameters.Exponent));
            Console.WriteLine("Encoding.Unicode.GetString: " + Convert.ToHexString(rsa.RSAParameters.Modulus));
            Console.WriteLine("Continue press any button...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Copy encrypted text from Sender");
            Console.Write("Encryption you want decrypted: ");
            string encryptedText = Console.ReadLine().Replace("-", "");
            if (encryptedText != null)
            {
                Console.WriteLine("Decrypted: " + Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromHexString(encryptedText),false)));
            }
            Console.ReadKey();
        }
    }
}
