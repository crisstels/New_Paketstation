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

        public string Text
        {
            get => _text;
            set => _text = value;
        }
        public Paket Paket
        {
            get => paket;
            set => paket = value;
        }

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
            Console.WriteLine("Wenn Sie Ihr Paket abgeben möchten, dann geben Sie folgende Daten ein: ");
            Console.WriteLine("Paketnummer: ");
            paket.Sendungsnummer = Console.ReadLine();
            Console.WriteLine("Absendername: ");
            paket.Absender = Console.ReadLine();
            Console.WriteLine("Gewicht des Pakets: ");
            paket.Gewicht = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Groesse des Pakets: ");
            paket.Groesse = Console.ReadLine();
            Console.WriteLine("Name des Empfaengers: ");
            paket.Empfaenger = Console.ReadLine();
        }
        #endregion
    }
}