using System;
using System.Collections.Generic;
using System.Linq;
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
        internal Paketstation Station { get => _station; set => _station = value; }
        internal Kunde Kunde1 { get => _kunde1; set => _kunde1 = value; }
        internal UserInterface Io { get => _io; set => _io = value; }
        #endregion
    }
}