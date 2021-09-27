using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat12();
            feladat13();

            Console.ReadLine();
        }
        static void feladat12()
        {
            Console.WriteLine("Kérek egy számot 1-12-ig");
            int szam = Convert.ToInt32(Console.ReadLine());
            int honap = szam;
            switch (honap)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Október");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Rossz számot adtál meg");
                    break;

            }
        }
        static void feladat13()
        {
            Console.WriteLine("Kérek egy számot 1-12-ig");
            int szam = Convert.ToInt32(Console.ReadLine());
            int honap = szam;
            switch (honap)
            {
                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                    Console.WriteLine("Tavasz");
                    break;
                case 4:
                    Console.WriteLine("Tavasz");
                    break;
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                    Console.WriteLine("Nyár");
                    break;
                case 7:
                    Console.WriteLine("Nyár");
                    break;
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                    Console.WriteLine("Ősz");
                    break;
                case 10:
                    Console.WriteLine("Ősz");
                    break;
                case 11:
                    Console.WriteLine("Ősz");
                    break;
                case 12:
                    Console.WriteLine("Tél");
                    break;
                default:
                    Console.WriteLine("Rossz számot adtál meg");
                    break;
            }
        }
        
    }
}
