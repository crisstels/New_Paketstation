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

        public int ID { get => id; set => id = value; }

        public string Standort { get => _standort; set => _standort = value; }

        public UserInterface Terminal { get => _terminal; set => _terminal = value; }
        
        public Paketfach[] Paketfaches { get => _paketfaches; set => _paketfaches = value; }

        #endregion

        #region Constructor

        public Paketstation()
        {
            this.Standort = "default";
            this.Terminal = _terminal;
            this.ID = 0;
            for (int i = 0; i < 9; i++)
            {
                Paketfaches[i] = new Paketfach();
            }

        }

        #endregion

        #region Worker
        // Die Packstation nimmt ein Paket an
        public void PaketAnnehmen(Paket paket)
        {
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                if (!Paketfaches[i].IstBelegt())
                {
                    Paketfaches[i].Oeffnen();
                    Paketfaches[i].Inhalt = paket;
                    Paketfaches[i].Belegt = true;
                    Paketfaches[i].Schliessen();
                    Console.WriteLine("Ihr Paket wurde erfolgreich abgegeben");
                    return;
                }
            }
            
            Console.WriteLine("Sorry, diese Paketstation ist voll besetzt. Suchen Sie sich bitte eine andere!");
        }

        public void PaketeListen()
        {
            Console.WriteLine("Verfuegbare Pakete: ");
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                Console.WriteLine(Paketfaches[i].Inhalt.Sendungsnummer);
            }
            
        }
        // Es wird überprüft, ob das Paket des Kunden in der Paketstation liegt
        public void Statusabfrage()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string temp = Console.ReadLine();
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                if (Paketfaches[i].Inhalt.Sendungsnummer == temp)
                {
                    Console.WriteLine($"Ihr Paket liegt in Fach {i} ");
                }
            }
        }
        // Kunde nimmt Paket aus der Paketstation
        public void PaketAbgeben()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string temp = Console.ReadLine();
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                if (Paketfaches[i].Inhalt.Sendungsnummer == temp)
                {
                    Paketfaches[i].Oeffnen();
                    Console.WriteLine("Bitte entnehmen Sie Ihr Paket");
                    Paketfaches[i].Schliessen();
                    Paketfaches[i].Belegt = false;
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