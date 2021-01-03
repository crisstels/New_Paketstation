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
            Console.WriteLine(_text);
        }
        #endregion
    }
}