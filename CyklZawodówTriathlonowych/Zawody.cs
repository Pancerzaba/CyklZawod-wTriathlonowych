using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Zawody : Miejsca, IZawody, IOrganizator, IZawodnika
    {
        string nazwaImprezy;
        string miejsce;
        string data;
        int iloscNumerowStartowych;

        public Zawody(string adres, string wielkosc, int maxStartujacych, string nazwaImprezy, string miejsce, string data, int iloscNumerowStartowych) : base(adres, wielkosc, maxStartujacych)
        {
            this.nazwaImprezy = nazwaImprezy;
            this.miejsce = miejsce;
            this.data = data;
            this.iloscNumerowStartowych = iloscNumerowStartowych;
        }

  

        public void WyswietlZawodnikow()
        {

        }
        public void pokazMiejsce()
        {

        }
        public void WyswietlDaneOsobowe()
        {

        }

      
        public void zapiszSie()
        {

        }
        public void zobaczZawody()
        {

        }

        enum DlugoscTrasy{Rekrut, Weteran }
    }
}
