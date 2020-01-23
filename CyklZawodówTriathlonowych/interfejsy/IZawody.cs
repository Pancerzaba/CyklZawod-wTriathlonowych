using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    interface IZawody:Zawody
    {
        void WyswietlZawodnikow();

        void pokazMiejsce();
    }
}
