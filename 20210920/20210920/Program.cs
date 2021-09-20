using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
        }
        static void feladat1()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }
            Console.ReadLine();
        }
        static void feladat2()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam<0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám pozitív");
            }
            Console.ReadLine();
        }
        static void feladat3()
        {
            Console.WriteLine("Hány fok van kint? :");
            int homerseklet = Convert.ToInt32(Console.ReadLine());
            if (homerseklet<0)
            {
                Console.WriteLine("Fagy van kint");
            }
            else
            {
                Console.WriteLine("Nincs kint fagy");
            }
            Console.ReadLine();
        }
        static void feladat4()
        {
            Console.WriteLine("Kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (-30<szam<40)
            {
                Console.WriteLine("A szám a tartományban van");
            }
            else
            {
                Console.WriteLine("A szám nincs a tartományban");
            }
        }
    }
}
