using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Stringİfadeler
{
    class Program
    {
        static void Main(string[] args)
        {
            MetinIşlemleri singleton1 = MetinIşlemleri.Instance();
            MetinIşlemleri singleton2 = MetinIşlemleri.Instance();
            MetinIşlemleri singleton3 = MetinIşlemleri.Instance();
            MetinIşlemleri singleton4 = MetinIşlemleri.Instance();

            Console.WriteLine("Girmek İstediğiniz Metini Yazınız :");
            string metin = Console.ReadLine();
            Console.WriteLine("Aranacak Olan Metini Giriniz :");
            string arananmetin = Console.ReadLine();

            var metinişlemleri = MetinIşlemleri.Instance();
            metinişlemleri.Girilenmetininbüyükhali(metin);
            metinişlemleri.Girilenmetininküçükhali(metin);
            metinişlemleri.Girilenmetinintershali(metin);
            metinişlemleri.GirilenmetininkacDefayazılması(metin, arananmetin);
            Console.ReadKey();

        }
    }

    class MetinIşlemleri
    {
        private static MetinIşlemleri _metinİşlemleri;
        private MetinIşlemleri()
        {

        }

        public static MetinIşlemleri Instance()
        {
            if (_metinİşlemleri == null)
            {
                _metinİşlemleri = new MetinIşlemleri();
            }
            return _metinİşlemleri;
        }
        public void Girilenmetininbüyükhali(string metin)
        {
            Console.Write("Girilen Metin'in Büyük Harfli Hali : ");
            Console.WriteLine(metin.ToUpper());
        }
        public void Girilenmetininküçükhali(string metin)
        {
            Console.Write("Girilen Metin'in Küçük Harfli Hali : ");
            Console.WriteLine(metin.ToLower());
        }
        public void Girilenmetinintershali(string metin)
        {
            Console.Write("Ters Çevirilen Metin : ");
            char[] _tersi = metin.ToCharArray();
            Array.Reverse(_tersi);
            Console.WriteLine(new String(_tersi));
        }
        public void GirilenmetininkacDefayazılması(string metin, string aranan)
        {
            int yazıuzunluk = metin.Length;
            int yeniyazıuzunluk = metin.Replace(aranan, null).Length;
            int kacDefa = (yazıuzunluk - yeniyazıuzunluk) / aranan.Length;
            Console.WriteLine(kacDefa + "Adet Bulunmaktadır");
        }

    }

}