using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    public class UserInterface
    {
        #region Properties
        private String _text;
        #endregion

        #region Accessor/Modifier

        public string Text { get => _text; set => _text = value; }

        #endregion

        #region Constructor

        public UserInterface()
        {
            this.Text = "default";
        }

        public UserInterface(string text)
        {
            this.Text = text;
        }

        #endregion

        #region Worker
        // Zeigt auf der Konsole Text an
        public void Datenannehmen()
        {
            Console.WriteLine(_text);
        }
        // Zeigt auf der Konsole das Menü an
        public int Menueauswahl()
        {
            Console.WriteLine("Willkommen zu unserer Paketstation\n" + "Wie kann ich Ihnen weiterhelfen?");
            Console.WriteLine("1 Statusabfrage des Pakets");
            Console.WriteLine("2 Paket verschicken");
            Console.WriteLine("3 Paket abholen");
            Console.WriteLine("4 beenden");

            int auswahl = Convert.ToInt16(Console.ReadLine());

            return auswahl;


        }
        // Die Daten des Kunden werden aufgenommen
        public Paket Dateneingabe()
        {
            Paket paket = new Paket();
            Console.WriteLine("Sendungsnummer des Pakets: ");
            paket.Sendungsnummer = Console.ReadLine();
            Console.WriteLine("Gewicht des Pakets: ");
            paket.Gewicht = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Groesse des Pakets (zahl x zahl)");
            paket.Groesse = Console.ReadLine();
            Console.WriteLine("Name des Absenders");
            paket.Absender = Console.ReadLine();
            Console.WriteLine("Name des Empfaengers: ");
            paket.Empfaenger = Console.ReadLine();

            return paket;
        }
        #endregion
    }
}