using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string Mail = "mimail@gmail.com";

            bool esValido = MailService.IsValid(Mail);

            Console.WriteLine("El mail es valido: " + (esValido ? "SI" : "NO"));
        }
    }
}
