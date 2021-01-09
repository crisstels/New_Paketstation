using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class UserInterface
    {
        #region Properties
        private String _text;
        private Paket paket;
        #endregion

        #region Accessor/Modifier

        public string Text { get => _text; set => _text = value; }
        public Paket Paket { get => paket; set => paket = value; }

        #endregion

        #region Construktor

        public UserInterface()
        {
            this.Text = "default";
            this.paket = new Paket();
        }

        public UserInterface(string text, Paket paket)
        {
            this.Text = text;
            this.paket = paket;
        }

        #endregion

        #region Worker
        public void Datenannehmen()
        {
            Console.WriteLine(_text);
        }

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
        #endregion
    }
}