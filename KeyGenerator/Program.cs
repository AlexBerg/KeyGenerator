using System;
using System.Security.Cryptography;

namespace SymmetricKeyGenerator
{
    class Program
    {
        static void Main()
        {
            byte[] secretKey = new byte[64];
            using (var provider = new RNGCryptoServiceProvider())
            {
                while (true)
                {
                    provider.GetBytes(secretKey);
                    var key = Convert.ToBase64String(secretKey);

                    Console.WriteLine($"Key: {key}");
                    Console.WriteLine("Enter r to generate a new key and any other key to quit....");
                    var input = Console.ReadLine();
                    if (input != "r")
                        break;
                }
            }
        }
    }
}
