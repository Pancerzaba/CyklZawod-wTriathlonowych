using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Miejsca
    {
        private string adres;
        private string wielkosc;
        private int maxStartujacych;

        public Miejsca(string adres, string wielkosc, int maxStartujacych)
        {
            this.adres = adres;
            this.wielkosc = wielkosc;
            this.maxStartujacych = maxStartujacych;
        }
    }
}
