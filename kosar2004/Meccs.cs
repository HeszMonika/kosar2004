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
    }
}