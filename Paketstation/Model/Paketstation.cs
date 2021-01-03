using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class Paketstation
    {
        #region Properties
        private Paketfach[] _faecher = new Paketfach[9];
        private UserInterface _terminal;
        private String _standort;
        private int ID;
        #endregion

        #region Accessors/Modifiers
        public int ID1 { get => ID; set => ID = value; }
        public string Standort { get => _standort; set => _standort = value; }
        public UserInterface Terminal { get => _terminal; set => _terminal = value; }
        public Paketfach[] Faecher { get => _faecher; set => _faecher = value; }
        #endregion

        #region Worker
        public void Paketannehmen(Paket paket)
        {
            Console.WriteLine("Ihr Paket wurde angenenommen");
        }

        public void PaketeListen()
        {
            Console.WriteLine("Verfuegbare Pakete");
        }
        private void Statusabfrage()
        {
            Console.WriteLine("Status des Pakets");
        }

        public Paket Paketabgeben()
        {
            Paket poaket = new Paket();
            return poaket;
        }
        #endregion
    }
}