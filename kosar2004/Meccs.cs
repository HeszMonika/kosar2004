using System;

namespace kosar2004
{
    internal class Meccs
    {
        public string Hazai { get; private set; }
        public string Idegen { get; private set; }
        public int Hazai_pont { get; private set; }
        public int Idegen_pont { get; private set; }
        public string Helyszin { get; private set; }
        public string Idopont { get; private set; }


        public Meccs(string Hazai, string Idegen, int Hazai_pont, int Idegen_pont, string Helyszin, string Idopont)
        {
            this.Hazai = Hazai;
            this.Idegen = Idegen;
            this.Hazai_pont = Hazai_pont;
            this.Idegen_pont = Idegen_pont;
            this.Helyszin = Helyszin;
            this.Idopont = Idopont;
        }


        public Meccs(string sor)
        {
            string[] a = sor.Split(';');
            Hazai = a[0];
            Idegen = a[1];
            Hazai_pont = Convert.ToInt32(a[2]);
            Idegen_pont = Convert.ToInt32(a[3]);
            Helyszin = a[4];
            Idopont = a[5];
        }


        public string Atalakit()
        {
            string tmp = Hazai + " - " + Idegen + " " + "(" + Convert.ToString(Hazai_pont) + " : " + Convert.ToString(Idegen_pont) + ")";
            return tmp;
        }
    }
}