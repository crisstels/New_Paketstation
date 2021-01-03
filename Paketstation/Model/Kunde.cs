using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class Kunde
    {
        #region Properties
        private Paket _paket;
        private int _kundennummer;
        private String _name;
        private String _adresse;
        #endregion

        #region Accessors/Modifiers
        public int Kundennummer { get => _kundennummer; set => _kundennummer = value; }
        public string Name { get => _name; set => _name = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Paket Paket { get => _paket; set => _paket = value; }
        #endregion

        #region Constructor

        public Kunde()
        {
            this.Kundennummer = 0;
            this.Name = "default";
            this.Adresse = "default";
            this.Paket = new Paket();
        }

        public Kunde(int kundennummer, string name, string adresse, Paket paket)
        {
            this.Kundennummer = kundennummer;
            this.Name = name;
            this.Adresse = adresse;
            this.Paket = paket;
        }

        #endregion

        #region Worker
        public Paket Paketeinliefern()
        {
            Console.WriteLine("Sendungsnummer des Pakets: ");
            Paket.Sendungsnummer = Console.ReadLine();
            Console.WriteLine("Gewicht des Pakets: ");
            Paket.Gewicht = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Groesse des Pakets (zahl x zahl)");
            Paket.Groesse = Console.ReadLine();
            Console.WriteLine("Name des Absenders");
            Paket.Absender = Console.ReadLine();
            Console.WriteLine("Name des Empfaengers: ");
            Paket.Empfaenger = Console.ReadLine();

            return _paket;
        }

        public void Paketabholen(Paket paket)
        {
            Console.WriteLine("Sie haben Ihr Paket erfolgreich abgeholt.");
        }
        #endregion
    }
}