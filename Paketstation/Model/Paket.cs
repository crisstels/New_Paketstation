using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class Paket
    {
        #region Properties
        private String _sendungsnummer;
        private int _gewicht;
        private String _groesse;
        private String _empfaenger;
        private String _absender;
        #endregion

        #region Accessors/Modifiers
        public string Sendungsnummer { get => _sendungsnummer; set => _sendungsnummer = value; }
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        public string Groesse { get => _groesse; set => _groesse = value; }
        public string Empfaenger { get => _empfaenger; set => _empfaenger = value; }
        public string Absender { get => _absender; set => _absender = value; }
        #endregion

        #region Constructor
        public Paket()
        {
            this.Sendungsnummer = "xxxxxxxxxxx";
            this.Gewicht = 0;
            this.Groesse = "0 x 0";
            this.Empfaenger = "Max Mustermann";
            this.Absender = "Max Mustermann";
        }

        public Paket(string sendungsnummer, int gewicht, string groesse, string empfaenger, string absender)
        {
            this.Sendungsnummer = sendungsnummer;
            this.Gewicht = gewicht;
            this.Groesse = groesse;
            this.Empfaenger = empfaenger;
            this.Absender = absender;
 
        }
        #endregion
    }
}