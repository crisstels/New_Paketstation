using System;

namespace Paketstation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Paket paket = new Paket();
            Kunde kunde = new Kunde("Peter", "Koeln", 123456, paket);
            kunde.generate_Paket(paket);
            Console.WriteLine(paket.Sendungsnummer);
            Console.WriteLine(kunde.Name);
            
        }
    }
}