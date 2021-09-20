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
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            feladat8();


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
            if (szam < 0)
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
            if (homerseklet < 0)
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
            if (-30 < szam && szam < 40)
            {
                Console.WriteLine("A szám a tartományban van");
            }
            else
            {
                Console.WriteLine("A szám nincs a tartományban");
            }
            Console.ReadLine();
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 16)
            {
                szam = szam * 16;
                Console.WriteLine(szam);
            }
            else if (szam >= 16)
            {
                szam = szam / 3;
                Console.WriteLine(szam);
            }
            Console.ReadLine();
        }
        static void feladat6()
        {
            Console.WriteLine("Kérek egy számot 10 és 50 között :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (10 <= szam && szam <= 19)
            {
                Console.WriteLine("Tizesek közé tartozik");
            }
            else if (20 <= szam && szam <= 29)
            {
                Console.WriteLine("huszasok közé tartozik");
            }
            else if (30 <= szam && szam <= 39)
            {
                Console.WriteLine("Harmincasok közé tartozik");
            }
            else if (40 <= szam && szam <= 49)
            {
                Console.WriteLine("negyvenesek közé tartozik");
            }
            Console.ReadLine();
        }
        static void feladat7()
        {
            Console.WriteLine("Kérek egy számot : ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (12 < szam && szam < 25 && szam % 2 == 0)
            {
                Console.WriteLine("A tartományban lévő szám páros");
            }
            else
            {
                Console.WriteLine("A szám nincs a tartományban vagy nem páros");
            }
            Console.ReadLine();
        }
        static void feladat8()
        {
            Console.WriteLine("Kérem a víz hőmérsékletét");
            int szam = Convert.ToInt32(Console.ReadLine());
            if(szam<0)
            {
                Console.WriteLine("A víz szilárd halmazállapotú");
            }
            else if(0<=szam && szam<100)
            {
                Console.WriteLine("A víz folyékony halmazállapotú");
            }
            else if(100<=szam)
            {
                Console.WriteLine("A víz gáz halmazállapotú");
            }
            Console.ReadLine();
        }
        
        
        

        

    }
}
