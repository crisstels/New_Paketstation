using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    public class Paketstation
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

        public UserInterface Terminal{ get => _terminal; set => _terminal = value; }

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
                    Thread.Sleep(2000);
                    Paketfaches[i].Inhalt = paket;
                    Paketfaches[i].Belegt = true;
                    Thread.Sleep(2000);
                    Paketfaches[i].Schliessen();
                    Thread.Sleep(2000);
                    Console.WriteLine("Ihr Paket wurde erfolgreich abgegeben");
                    Thread.Sleep(2000);
                    return;
                }
            }

            Console.WriteLine("Sorry, diese Paketstation ist voll besetzt. Suchen Sie sich bitte eine andere!");
        }

        // Es wird überprüft, ob das Paket des Kunden in der Paketstation liegt
        public void Statusabfrage()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string temp = Console.ReadLine();
            int index = FindePaketNachSendungsnummer(temp);
            if (index >= 0)
            {
                Console.WriteLine($"Ihr Paket liegt in Fach {index} ");
            }
            else
            {
                Console.WriteLine($"Ihr Paket mit der Sendungsnummer {temp} liegt nicht in dieser Paketstation");
            }
        }
        // Die Paketstation wird anhand der Sendungsnummer das Paket des Kunden suchen
        public int FindePaketNachSendungsnummer(string nummer)
        {
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                if (Paketfaches[i].Belegt)
                {
                    if (Paketfaches[i].Inhalt.Sendungsnummer.Equals(nummer))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        // Kunde nimmt Paket aus der Paketstation
        public Paket PaketAbgeben()
        {
            Console.WriteLine("Bitte geben Sie die Sendungsnummer Ihres Paketes ein: ");
            string nummer = Console.ReadLine();
            for (int i = 0; i < Paketfaches.Length; i++)
            {
                if (Paketfaches[i].Inhalt.Sendungsnummer == nummer)
                {
                    Paketfaches[i].Oeffnen();
                    Thread.Sleep(2000);
                    Console.WriteLine("Bitte entnehmen Sie Ihr Paket");
                    Thread.Sleep(2000);
                    Paketfaches[i].Schliessen();
                    Paketfaches[i].Belegt = false;
                    Thread.Sleep(2000);
                    return Paketfaches[i].Inhalt;
                }
            }
            
            return null;
        }
        
        #endregion
    }
}