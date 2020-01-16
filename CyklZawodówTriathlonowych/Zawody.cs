using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Zawody : Miejsca
    {
        string miejsce;
        string data;
        int iloscNumerowStartowych;

        public Zawody(string adres, string wielkosc, int maxStartujacych) : base(adres, wielkosc, maxStartujacych)
        {
        }

        enum DlugoscTrasy{Rekrut, Weteran }
    }
}
