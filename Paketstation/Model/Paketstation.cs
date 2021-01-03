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
        private Paketfach[] _paketfaches = new Paketfach[9];
        private UserInterface _terminal;
        private String _standort;
        private int id;
        #endregion

        #region Accessors/Modifiers

        public int ID
        {
            get => ID; 
            set => ID = value;
        }

        public string Standort
        {
            get => _standort; 
            set => _standort = value;
        }

        public UserInterface Terminal
        {
            get => _terminal; 
            set => _terminal = value;
        }
        
        public Paketfach[] Paketfaches
        {
            get => _paketfaches;
            set => _paketfaches = value;
        }

        #endregion

        #region Constructor

        public Paketstation()
        {
            this._standort = "default";
            this._terminal = _terminal;
            this.id = 0;
            for (int i = 0; i < 9; i++)
            {
                _paketfaches[i] = new Paketfach();
            }

        }

        #endregion

        #region Worker
        // Die Packstation nimmt ein Paket an
        public void PaketAnnehmen(Paket paket)
        {
            for (int i = 0; i < _paketfaches.Length; i++)
            {
                if (!_paketfaches[i].IstBelegt())
                {
                    _paketfaches[i].Oeffnen();
                    _paketfaches[i].Inhalt = paket;
                    _paketfaches[i].Belegt = true;
                    _paketfaches[i].Schliessen();
                    Console.WriteLine("Ihr Paket wurde erfolgreich abgegeben");
                    return;
                }
            }
            
            Console.WriteLine("Sorry, diese Paketstation ist voll besetzt. Suchen Sie sich bitte eine andere!");
        }

        public void PaketeListen()
        {
            Console.WriteLine("Verfuegbare Pakete: ");
            for (int i = 0; i < _paketfaches.Length; i++)
            {
                Console.WriteLine(_paketfaches[i].Inhalt.Sendungsnummer);
            }
            
        }
        // Es wird überprüft, ob das Paket des Kunden in der Paketstation liegt
        private void Statusabfrage()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string temp = Console.ReadLine();
            for (int i = 0; i < _paketfaches.Length; i++)
            {
                if (_paketfaches[i].Inhalt.Sendungsnummer == temp)
                {
                    Console.WriteLine("Ihr Paket liegt in Fach %d", i);
                }
            }
        }
        // Kunde nimmt Paket aus der Paketstation
        public void PaketAbgeben()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string temp = Console.ReadLine();
            for (int i = 0; i < _paketfaches.Length; i++)
            {
                if (_paketfaches[i].Inhalt.Sendungsnummer == temp)
                {
                    _paketfaches[i].Oeffnen();
                    Console.WriteLine("Bitte entnehmen Sie Ihr Paket");
                    _paketfaches[i].Schliessen();
                    _paketfaches[i].Belegt = false;
                    return;
                }
            }
        }

        public bool ist_Paketstation_voll()
        {
            return false;
        }
        #endregion
    }
}