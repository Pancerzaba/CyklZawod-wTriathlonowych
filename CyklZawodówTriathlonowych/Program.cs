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
            Osoba osoba1 = new Zawodnik("Jan", "Kowalski", "506213987", "Filipa 3/11 olsztyn", 2000);
            Console.WriteLine(osoba1.Imie);





            Console.ReadLine();
        }
    }
}
