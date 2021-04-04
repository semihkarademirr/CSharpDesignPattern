using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory

{
    public abstract class bölgeler
    {

        public abstract void Draw();
    }

    class karadenizbölgesi : bölgeler
    {
        public override void Draw()
        {
            Console.WriteLine("Düzce, Bolu, Zonguldak, Karabük, Kastamonu, Çorum, Sinop, Amasya, Tokat, Samsun, Ordu, " +
                "\nGiresun, Trabzon, Rize, Gümüşhane, Bayburt ve Artvin illeri Karadeniz Bölgesi’nde yer almaktadır.");
            Console.WriteLine("********");
        }
    }

    class egebölgesi : bölgeler
    {
        public override void Draw()
        {
            Console.WriteLine("İzmir, Manisa, Aydın, Muğla, Denizli, Uşak," +
                "Kütahya ve Afyon Ege Bölgesi illeridir.");
            Console.WriteLine("********");
        }

    }

    class marmarabölgesi : bölgeler
    {
        public override void Draw()
        {
            Console.WriteLine("Bursa, İstanbul, Çanakkale, Tekirdağ, Edirne, " +
                "\nKırklareli, Bilecik, Balıkesir, Yalova, Sakarya ve Kocaeli illeri de Marmara Bölgesinde yer almaktadır.");
            
        }
    }

    enum bölgetipi
    {
        karadeniz,
        ege,
        marmara
    }

    class Creator
    {

        public bölgeler bölgelerFactory(bölgetipi bölgetipi)
        {
            bölgeler bölgeler = null;

            switch (bölgetipi)
            {
                case bölgetipi.karadeniz:
                    bölgeler = new karadenizbölgesi();
                    break;

                case bölgetipi.ege:
                    bölgeler = new egebölgesi();
                    break;

                case bölgetipi.marmara:
                    bölgeler = new marmarabölgesi();
                    break;

            }

            return bölgeler;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Creator creator = new Creator();

            bölgeler bölgelerkaradeniz = creator.bölgelerFactory(bölgetipi.karadeniz);
            bölgeler bölgelerege = creator.bölgelerFactory(bölgetipi.ege);
            bölgeler bölgelermarmara = creator.bölgelerFactory(bölgetipi.marmara);

            bölgelerkaradeniz.Draw();
            bölgelerege.Draw();
            bölgelermarmara.Draw();

            Console.ReadKey();
        }

    }
}