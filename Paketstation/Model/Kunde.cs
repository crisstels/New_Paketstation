using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Paketstation
{
    public class Kunde
    {
        private string _anschrift;
        private int _kundennummer;
        private string _name;
        private Paket _paket;

        public string Anschrift
        {
            get => _anschrift;
            set => _anschrift = value;
        }

        public int Kundennummer
        {
            get => _kundennummer;
            set => _kundennummer = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Paket Paket1
        {
            get => _paket;
            set => _paket = value;
        }

        public Kunde(string name, string anschrift, int kundennummer, Paket paket)
        {
            Name = name;
            Anschrift = anschrift;
            Kundennummer = kundennummer;
            Paket1 = paket;
        }

        public void generate_Paket(Paket paket)
        {
            Console.WriteLine("Welches Paket moechten Sie einliefern?(Sendungsnummer)");
            paket.Sendungsnummer = Console.ReadLine();
            Console.WriteLine("Gewicht des Pakets ermitteln...");
            paket.Gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("groese eingeben: ");
            paket.Groesse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("empfaenger eingeben");
            paket.Empfaenger = Console.ReadLine();
            Console.WriteLine("absender namen eingeben");
            paket.Absender = Console.ReadLine();

        }
    }
}