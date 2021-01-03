namespace Paketstation
{
    public class Paket
    {
        private string _sendungsnummer;
        private string _empfaenger;
        private string _absender;
        private double _gewicht;
        private double _groesse;

        public Paket(string sendungsnummer, string empfaenger, string absender, double gewicht, double groesse)
        {
            Sendungsnummer = sendungsnummer;
            Empfaenger = empfaenger;
            Absender = absender;
            Gewicht = gewicht;
            Groesse = groesse;
        }

        public Paket()
        {
            Sendungsnummer = "xxxxxx";
            Empfaenger = "Default";
            Absender = "Default";
            Gewicht = 0;
            Groesse = 0; 
        }
        #region Accessors
        public string Sendungsnummer
        {
            get => _sendungsnummer;
            set => _sendungsnummer = value;
        }

        public string Empfaenger
        {
            get => _empfaenger;
            set => _empfaenger = value;
        }

        public string Absender
        {
            get => _absender;
            set => _absender = value;
        }

        public double Gewicht
        {
            get => _gewicht;
            set => _gewicht = value;
        }

        public double Groesse
        {
            get => _groesse;
            set => _groesse = value;
        }
        #endregion
        
    }
}