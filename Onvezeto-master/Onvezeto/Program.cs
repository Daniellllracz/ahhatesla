using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Onvezeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();
            StreamReader sr = new StreamReader(@"..\..\..\src\autoadat.txt");

            Console.WriteLine("2.Feladat: Fajl beolvasas");
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine();
                Auto auto = new Auto(sor);
                autok.Add(auto);
            }

            //kiiras
            //foreach (Auto auto in autok)
            //{
            //    Console.WriteLine("Auto: {0} {1} {2} {3} {4}",auto.azonosito,auto.teljeseitmeny,auto.tomeg,auto.gyorsulas,auto.beavatkozas);
            //}

            Console.WriteLine();
            //3.Feladat

            int leggyorsabb = autok.Min(auto => auto.gyorsulas);

            foreach (Auto auto in autok)
            {
                if (auto.gyorsulas == leggyorsabb)
                {
                    Console.WriteLine("3.Feladat: {0} {1} {2} {3} {4}", auto.azonosito, auto.teljeseitmeny, auto.tomeg, auto.gyorsulas, auto.beavatkozas);
                }
                else {}
            }

            Console.WriteLine();
            //4.Feladat

            int onallotlan = autok.Max(auto => auto.beavatkozas);

            foreach (Auto auto in autok)
            {
                if (auto.beavatkozas == onallotlan)
                {
                    Console.WriteLine("4.Feladat: {0}", auto.azonosito);
                }
                else { }
            }

            Console.WriteLine();
            //5.Feladat

            double atlagtomeg = autok.Average(auto => auto.tomeg);
            Console.WriteLine("5.Feladat: {0}",atlagtomeg);

            Console.WriteLine();
            //6.Feladat

            int id = 0;

            using (StreamWriter sw = new StreamWriter(@"..\..\..\src\new_file.txt")) 
            {
                foreach (Auto auto in autok)
                {
                    sw.Write(id);
                    sw.Write(" ");
                    sw.Write(auto.tomeg * 1000);
                    sw.WriteLine("kg");
                    id++;
                }
            }

            Console.ReadLine();
        }
    }
}
