using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation { 
    class Paketfach
    {
        #region Properties
        private Paket _inhalt;
        private int _nummer;
        private bool _status;
        private bool _belegt;
        #endregion

        #region Accessors/Modifiers
        public int Nummer { get => _nummer; set => _nummer = value; }
        public bool Status { get => _status; set => _status = value; }
        public bool Belegt { get => _belegt; set => _belegt = value; }
        internal Paket Inhalt { get => _inhalt; set => _inhalt = value; }
        #endregion

        #region Constructor

        public Paketfach()
        {
            this._nummer = 0;
            this._status = true;
            this._belegt = false;
            this.Inhalt = new Paket();
        }

        public Paketfach(int nummer, bool status, bool belegt, Paket inhalt)
        {
            this._nummer = nummer;
            this._status = status;
            this._belegt = belegt;
            this._inhalt = inhalt;
        }

        #endregion

        public void Oeffnen()
        {
            this.Status = true;
            Console.WriteLine("Fach wird geoeffnet....");
        }

        public void Schliessen()
        {
            this.Status = false;
            Console.WriteLine("Fach wird geschlossen...");
        }

        public bool IstBelegt()
        {
            return this.Belegt;
        }
    }
}