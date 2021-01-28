/* Autor: Natalie Hasselmann
*  Klasse: IA219
*  Dateiname: Kunde.cs
*  Datum: 28.01.2021
+  Beschreibung: Bildet einen Kunden ab
*  Letze Aenderung: 28.01.2021 Aggregation wurde hinzugefügt
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    public class Kunde
    {
        #region Properties
        private Paket _paket1;
        private int _kundennummer;
        private String _name;
        private String _adresse;
        #endregion

        #region Accessors/Modifiers
        public int Kundennummer { get => _kundennummer; set => _kundennummer = value; }
        public string Name { get => _name; set => _name = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Paket Paket1 { get => _paket1; set => _paket1 = value; }
        #endregion

        #region Constructor

        public Kunde()
        {
            this.Kundennummer = 0;
            this.Name = "default";
            this.Adresse = "default";
            this.Paket1 = new Paket();
        }

        public Kunde(int kundennummer, string name, string adresse, Paket paket1)
        {
            this.Kundennummer = kundennummer;
            this.Name = name;
            this.Adresse = adresse;
            this.Paket1 = paket1;
        }

        #endregion

        #region Worker
        //Der Kunde gibt sein Paket bei der Paketstation ab
        public Paket PaketAbgeben()
        {
            if (Paket1 == null)
                throw new Exception("Sie besitzen kein Paket zum abholen!");

            Paket res = Paket1;
            Paket1 = null;
            return res;
        }
        // Der Kunde holt ein Paket von der Paketstation ab
        public void PaketAbholen(Paket paket)
        {
            if (paket != null)
            {
                if (Paket1 != null)
                    throw new Exception("Sie können nur ein Paket gleichzeitig besitzen!");

                Paket1 = paket ;
            }
        }
        #endregion
    }
}