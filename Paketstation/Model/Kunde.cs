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

        #region Worker
        public Paket Paketeinliefern()
        {
            return this.Paket;
        }

        public void Paketabholen(Paket paket)
        {
            Console.WriteLine("Sie haben Ihr Paket erfolgreich abgeholt.");
        }
        #endregion
    }
}