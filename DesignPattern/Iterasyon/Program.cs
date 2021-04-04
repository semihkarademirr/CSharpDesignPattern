using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterasyon
{
    class Program
    {
        class Ders
        {
            public Ders(string ad, int kredi)
            {
                Ad = ad;
                Kredi = kredi;
            }
            public string Ad { get; set; }
            public int Kredi { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generic koleksiyon :\n");
            var ders = new DersCollection<Ders>
            {
                new Ders("Nesneye Yönelik Programlama",5),
                new Ders("Yüksek Matematik",5),
                new Ders("Sektöre Giriş",3),
                new Ders("Ayrık Matematik",4),
                new Ders("Türk Dili",2),
                new Ders("İşletmenin Temel İlkeleri",4),
                
            };

            foreach (var drs in ders.Basamak(0, 6, 1))
            {
                Console.WriteLine("Ders:" + drs.Ad);
                Console.WriteLine("Kredi:" + drs.Kredi);

            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Koleksiyonun Tersten Yazılışı : ");
            Console.WriteLine();

            foreach (var drs in ders.TerstenBasamak(5, 0, 1))
            {
                Console.WriteLine("Ders:" + drs.Ad);
                Console.WriteLine("Kredi:" + drs.Kredi);

            }

            var count = ders.Count();
            ders.Reverse();

            Console.WriteLine("\nKoleksiyonun toplam eleman sayısı :" + count);
            Console.ReadKey();
        }
    }

   
    class DersCollection<T> : IEnumerable<T>
    {
        private List<T> derss = new List<T>();

        public int Count
        {
            get { return derss.Count; }
        }

        public void Add(T t)
        {
            derss.Add(t);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return derss[i];
            }
        }

        public IEnumerable<T> BackToFront
        {
            get
            {
                for (int i = Count - 1; i >= 0; i--)
                {
                    yield return derss[i];
                }
            }
        }
        public IEnumerable<T> FrontToBack
        {
            get
            {
                return this;
            }
        }
        public IEnumerable<T> Basamak(int başlanıç, int bitiş, int basamak)
        {
            for (int i = başlanıç; i < bitiş; i += basamak)
            {
                yield return derss[i];
            }
        }

        public IEnumerable<T> TerstenBasamak(int bitiş, int başlanıç, int basamak)
        {
            for (int i = bitiş; i >= başlanıç; i -= basamak)
            {
                yield return derss[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}