using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Zawody
    {
        string miejsce;
        string data;
        int iloscNumerowStartowych;

        public Zawody(string miejsce, string data, int iloscNumerowStartowych)
        {
            this.miejsce = miejsce;
            this.data = data;
            this.iloscNumerowStartowych = iloscNumerowStartowych;
        }

        enum DlugoscTrasy{Rekrut, Weteran }
    }
}
