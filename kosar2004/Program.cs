using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class Program
    {
        static List<Meccs> Meccsek = new List<Meccs>();


        static void MasodikFeladat()
        {
            StreamReader sr = new StreamReader("eredmenyek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Meccsek.Add(new Meccs(sr.ReadLine()));
            }
            sr.Close();
        }


        static void HarmadikFeladat()
        {
            //var hazai = from m in Meccsek where m.Hazai == "Real Madrid" select new { Hazai = m.Hazai };
            //int hazaiDb = hazai.ToList().Count;

            //var idegen = from m in Meccsek where m.Idegen == "Real Madrid" select new { Idegen = m.Idegen };
            //int idegenDb = idegen.ToList().Count;

            //Console.WriteLine($"Hazai: {hazaiDb}, Idegen: {idegenDb}");


            int hanyszorHazai = 0;
            foreach (var m in Meccsek)
            {
                if (m.Hazai == "Real Madrid")
                {
                    hanyszorHazai++;
                }
            }

            int hanyszorIdegen = 0;
            foreach (var m in Meccsek)
            {
                if (m.Hazai == "Real Madrid")
                {
                    hanyszorIdegen++;
                }
            }

            Console.WriteLine($"3. feladat: Hazai: {hanyszorHazai} Idegen: {hanyszorIdegen}");
        }


        static void NegyedikFeladat()
        {
            bool van = false;
            foreach (var m in Meccsek)
            {
                if (m.Hazai_pont == m.Idegen_pont)
                {
                    van = true;
                }
            }
            if (van)
            {
                Console.WriteLine("4. feladat: Van-e döntetlen? Igen.");
            }
            else
            {
                Console.WriteLine("4. feladat: Van-e döntetlen? Nem.");
            }
        }


        static void OtodikFeladat()
        {
            string nev = " ";
            foreach (var m in Meccsek)
            {
                if (m.Hazai.Contains("Barcelona"))
                {
                    nev = m.Hazai;
                }
            }
            Console.WriteLine($"5. feladat: A barcelonai csapat neve: {nev}");
        }


        static void HatodikFeladat()
        {
            Console.WriteLine("6. feladat:");
            foreach (var m in Meccsek)
            {
                if (m.Idopont == "2004-11-21")
                {
                    Console.WriteLine($"\t{m.Hazai} {m.Idegen} ({m.Hazai_pont} : {m.Idegen_pont})");
                }
            }
        }


        static void HetedikFeladat()
        {
            foreach (var m in Meccsek)
            {
                
            }
        }


        static void Main(string[] args)
        {
            MasodikFeladat();
            foreach (var m in Meccsek)
            {
                Console.WriteLine($"{m.Hazai} {m.Idegen} ({m.Hazai_pont} : {m.Idegen_pont})");
            }

            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();


            Console.ReadKey();
        }
    }
}
