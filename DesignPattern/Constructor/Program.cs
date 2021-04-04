using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class program
    {
        static void Main(string[] args)
        {
            Köpek köpek = new Köpek("Dogo Arjantin", 13, 40, 58);
            köpek.SesÇıkar();
            Console.WriteLine("======================================");
            Kedi kedi = new Kedi("British Shorthair", 14, 6, 27);
            kedi.SesÇıkar();

            Console.ReadKey();
        }
    }
    interface sesçıkar
    {
        void SesÇıkar();

    }

    class Hayvan
    {
        private string _tür;
        private int _ömür;
        private int _kilo;
        private int _boy;
        public Hayvan(string tür, int ömür, int kilo, int boy)
        {
            _tür = tür;
            _ömür = ömür;
            _kilo = kilo;
            _boy = boy;

        }

        public string Türü { get; set; }
        public int OrtalamaÖmür { get; set; }
        public int OrtalamaKilo { get; set; }
        public int OrtalamaBoy { get; set; }
    }

    class Kedi : Hayvan, sesçıkar
    {
        public Kedi(string tür, int ömür, int kilo, int boy) : base(tür, ömür, kilo, boy)
        {
            Console.WriteLine("Cins : {0}", tür);
            Console.WriteLine("Ortalama Yaşam Süreleri : {0} Yıl", ömür);
            Console.WriteLine("Ortalama Kilogramları : {0} Kg", kilo);
            Console.WriteLine("Ortalama Boy Uzunlukları : {0} Cm", boy);
        }

        public void SesÇıkar()
        {
            Console.WriteLine("Çıkardağı Ses : Miyav");
        }
    }
    class Köpek : Hayvan, sesçıkar
    {
        public Köpek(string tür, int ömür, int kilo, int boy) : base(tür, ömür, kilo, boy)
        {
            Console.WriteLine("Cins : {0}", tür);
            Console.WriteLine("Ortalama Yaşam Süreleri : {0} Yıl", ömür);
            Console.WriteLine("Ortalama Kilogramları : {0} " + "Kg", kilo);
            Console.WriteLine("Ortalama Boy Uzunlukları :{0} Cm", boy);
        }

        public void SesÇıkar()
        {
            Console.WriteLine("Çıkardağı Ses : Hav Hav");
        }
    }
}

