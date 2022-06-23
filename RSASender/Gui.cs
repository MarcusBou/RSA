using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSASender
{
    internal class Gui
    {
        RSA rsa;
        public Gui()
        {
            rsa = new RSA();
            Start();
        }
        public void Start()
        {
            Console.Write("Exponent received from reciever: ");
            string exponent = Console.ReadLine();
            Console.Write("Modulus received from reciever: ");
            string modulus = Console.ReadLine();
            if (exponent != null && modulus != null)
            {
                Console.Clear();
                Console.Write("Message you want Encrypted: ");
                string message = Console.ReadLine();
                if (message != null)
                {
                    byte[] crypted = rsa.Encrypt(Encoding.ASCII.GetBytes(message), rsa.SetParameters(exponent, modulus), false);
                    Console.WriteLine(BitConverter.ToString(crypted));
                }
            }
        }
    }
}
