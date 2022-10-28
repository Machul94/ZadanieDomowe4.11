using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numer;
            Console.WriteLine("Progam sprawdza czy podana przez Ciebie liczba jest parzysta czy nieparzyta.\nPodaj Liczbę: ");
            numer = GetNumer();
            if (numer % 2 == 0)
                Console.WriteLine("Liczba jest parzyta");
            else
                Console.WriteLine("Liczba jest nieparzyta");
            Console.ReadKey();
        }
        public static int GetNumer()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int usersNumber))
                {
                    Console.WriteLine("Wartość niepoprawna, podaj liczbę całkiwitą.");
                    continue;
                }
                return usersNumber;
            }
        }
    }
}

