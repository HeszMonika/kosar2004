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
            //2. feladat: olvassa be az eredmenyek.csv állomríny sorait és tárolja az adatokat egy olyan
            //összetett adatszerkezetben (p1.vektor, lista stb.), amely használatával a további
            //feladatok megoldhatók! Ügyeljen arra, hogy az állomany első sora az adatok fejlécét tartalmazza!
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
            //3. feladat: Határozza meg és írja ki a képernyőre a minta szerint, hogy a Real Madrid hány
            //mérkőzést játszott hazai, illetve idegen csapatként!
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

            //var hazai = from m in Meccsek where m.Hazai == "Real Madrid" select new { Hazai = m.Hazai };
            //int hazaiDb = hazai.ToList().Count;

            //var idegen = from m in Meccsek where m.Idegen == "Real Madrid" select new { Idegen = m.Idegen };
            //int idegenDb = idegen.ToList().Count;

            //Console.WriteLine($"Hazai: {hazaiDb}, Idegen: {idegenDb}");
        }


        static void NegyedikFeladat()
        {
            //4. feladat: Határozza meg és írja ki a minta szerint, hogy volt-e döntetlen mérkőzés!
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
            //5. feladat: Határozza meg és írja ki a minta szerint, hogy a barcelonai csapatnak mi a pontos
            //neve! (Feltételezheti, hogy a csapat neve tartalmazza Barcelona város nevét, és a
            //csapat játszott otthon is legalább egy mérkőzést.)
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
            //6. feladat: Határozza meg és írja ki a minta szerint, hogy 2004. november 21-én mely csapatok
            //játszottak mérkőzéseket, és milyen eredmény született!
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
            //7. feladat: Hatérozza meg és írja ki a minta szerint, hogy melyek azok a stadionok, amelyek
            //20-nál több alkalommal voltak kislabdamérkőzések helyszínei! A stadionok neve
            //mögött jelenjen meg a mérkőzések száma is! A feltételnek megfelelő stadionok
            //tetszőleges sorrendben jelenhetnek meg.
            Console.WriteLine("7. feladat:");
            var stadionok = from m in Meccsek orderby m.Helyszin group m by m.Helyszin into stadion select stadion;

            foreach (var stadion in stadionok)
            {
                if (stadion.Count() > 20)
                {
                    Console.WriteLine($"\t{stadion.Key}: {stadion.Count()}");
                }
            }
        }


        static void Kiiras()
        {
            //8. feladat: Írja ki a meccsek.txt-be a csapatok nevét és a pontok számát szöveges formában.
            StreamWriter sw = new StreamWriter("meccsek.txt");
            foreach (var m in Meccsek)
            {
                sw.WriteLine(m.Atalakit());
            }
            sw.Close();
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
            Kiiras();


            Console.ReadKey();
        }
    }
}
