using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class Controller
    {
        #region Properties
        private Paketstation _station;
        private Kunde _kunde1;
        private UserInterface _io;
        #endregion

        #region Accessors/Modifiers
        public Paketstation Station { get => _station; set => _station = value; }
        public Kunde Kunde1 { get => _kunde1; set => _kunde1 = value; }
        public UserInterface Io { get => _io; set => _io = value; }
        #endregion

        #region Constructor

        public Controller()
        {
            this.Station = new Paketstation();
            this.Kunde1 = new Kunde();
            this.Io = new UserInterface();
            
        }

        public Controller(Paketstation paketstation, Kunde kunde, UserInterface userInterface)
        {
            this.Station = paketstation;
            this.Kunde1 = kunde;
            this.Io = userInterface;
        }

        #endregion

        public void run()
        {
            while (true)
            {
                int auswahl = Io.Menueauswahl();
                if (auswahl == 4)
                {
                    Console.WriteLine("Auf Wiedersehen!");
                    break;
                }
                switch (auswahl)
                {
                    case 1:
                        Statusabfrage();
                        break;
                    case 2:
                        PaketAnnehmen();
                        break;
                    case 3:
                        PaketAusgeben();
                        break;
                    default:
                        Console.WriteLine("falsche eingabe");
                        break;
                }
            }
        }

        public void PaketAnnehmen()
        {
            Console.WriteLine("Sie haben die Funktion Paket verschicken gewaehlt.\n" + 
                              "Geben Sie nun bitte folgende Daten ein: \n");
            Station.PaketAnnehmen(_kunde1.Paketeinliefern());
        }

        public void Statusabfrage()
        {
            Station.Statusabfrage();
        }

        public void PaketAusgeben()
        {
            Station.PaketAbgeben();
        }
    }
}