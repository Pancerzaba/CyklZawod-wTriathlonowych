using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski", "546564", "Olsztyn", 1992);
            Console.WriteLine(osoba1.Imie);
            IOrganizator osoba2 = new Organizator("Adam", "Kot", "505124", "Olsztyn", 1998);
            IZawodnika osoba3 = new Zawodnik("Arek", "miś", "505453", "Wilno", 1946);

            IZawody zawody1 = new Zawody("służewiec", "duze", 10000, "Maraton XLP", "Tor Wyscigow Konnych", "15.06.2020", 100);

            osoba2.WyswietlDaneOsobowe();
            osoba3.WyswietlDaneOsobowe();
            osoba3.ZapiszSie();
            osoba3.IleLat();





            Console.ReadLine();
        }
    }
}
