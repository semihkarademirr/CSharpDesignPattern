using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        public enum DonanımTipi
        {
            RAM,
            İşlemciHızı,
            DahiliHafıza,
            İşletimSistemiTürü,
            EkranÇözünürlüğü
        }
        public enum CihazTipi
        {
            CepTelefonu,
            HibritBilgisayar,
            TabletBilgisayar
        }
        public class Cihaz
        {
            private CihazTipi _cihaztipi;
            private Dictionary<DonanımTipi, string> _cihazparcaları = new Dictionary<DonanımTipi, string>();

            public Cihaz(CihazTipi cihaztipi)
            {
                _cihaztipi = cihaztipi;
            }

            public string this[DonanımTipi key]
            {
                get { return _cihazparcaları[key]; }
                set { _cihazparcaları[key] = value; }
            }
            public void ParcalariGoster()
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("Cihaz Tipi :{0}", _cihaztipi);
                Console.WriteLine("RAM :{0}", this[DonanımTipi.RAM]);
                Console.WriteLine("İŞLEMCİ HIZI :{0}", this[DonanımTipi.İşlemciHızı]);
                Console.WriteLine("DAHİLİ HAFIZA :{0}", this[DonanımTipi.DahiliHafıza]);
                Console.WriteLine("İŞLETİM SİSTEMİ  TÜRÜ :{0}", this[DonanımTipi.İşletimSistemiTürü]);
                Console.WriteLine("EKRAN ÇÖZÜNÜRLÜĞÜ :{0}", this[DonanımTipi.EkranÇözünürlüğü]);
            }
        }

        public abstract class CihazOlusturucu
        {
            public Cihaz Cihaz { get; private set; }
            public CihazOlusturucu(CihazTipi cihaztipi)
            {
                Cihaz = new Cihaz(cihaztipi);
            }
            public abstract void RamOlustur();
            public abstract void İşlemciHızıOlustur();
            public abstract void DahiliHafızaOlustur();
            public abstract void İşletimSistemiTürüOlustur();
            public abstract void EkranÇözünürlüğüOlustur();
        }
   
        public class CepTelefonuOlusturucu :  CihazOlusturucu
        {
            public CepTelefonuOlusturucu() : base(CihazTipi.CepTelefonu)
            {
               
            }
            public override void RamOlustur()
            {
                Cihaz[DonanımTipi.RAM] = "3GB";
            }
            public override void İşlemciHızıOlustur()
            {
                Cihaz[DonanımTipi.İşlemciHızı] = "Apple iPhone X işlemci hızı : 2 x 2,53 + 4 x 1,42 GHz";
            }
            public override void DahiliHafızaOlustur()
            {
                Cihaz[DonanımTipi.DahiliHafıza] = " 64GB";
            }
            public override void İşletimSistemiTürüOlustur()
            {
                Cihaz[DonanımTipi.İşletimSistemiTürü] = "IOS";
            }

            public override void EkranÇözünürlüğüOlustur()
            {
                Cihaz[DonanımTipi.EkranÇözünürlüğü] = ": 5.8-inç 1125 x 2436 OLED ekran / %81.23 ekran-gövde oranı";
            }

        }

        public class HibritBilgisayarOlusturucu : CihazOlusturucu
        {

            public HibritBilgisayarOlusturucu() : base(CihazTipi.HibritBilgisayar)
            {
                
            }
            public override void RamOlustur()
            {
                Cihaz[DonanımTipi.RAM] = "16GB (2x8GB) DDR4L 1.2V 2666MHz SODIMM";
            }
            public override void İşlemciHızıOlustur()
            {
                Cihaz[DonanımTipi.İşlemciHızı] = "Intel® Coffee Lake Core™ i7-9750H 6C/12T; 12MB L3; 8GT/s; 2.6GHz > 4.5GHz; 45W; 14nm";
            }
            public override void DahiliHafızaOlustur()
            {
                Cihaz[DonanımTipi.DahiliHafıza] = "256GB SAMSUNG PM981a M.2 SSD";
            }
            public override void İşletimSistemiTürüOlustur()
            {
                Cihaz[DonanımTipi.İşletimSistemiTürü] = "WİNDOWS 10";
            }
            public override void EkranÇözünürlüğüOlustur()
            {
                Cihaz[DonanımTipi.EkranÇözünürlüğü] = "15,6 FHD 1920x1080 IPS Mat LED Ekran";
            }
        }

        public class TabletBilgisayarOlusturucu : CihazOlusturucu
        {
            public TabletBilgisayarOlusturucu() : base(CihazTipi.TabletBilgisayar)
            {

            }
            public override void RamOlustur()
            {
                Cihaz[DonanımTipi.RAM] = "6GB";
            }
            public override void İşlemciHızıOlustur()
            {
                Cihaz[DonanımTipi.İşlemciHızı] = "	2,4 GHz";
            }
            public override void DahiliHafızaOlustur()
            {
                Cihaz[DonanımTipi.DahiliHafıza] = "128GB";
            }
            public override void İşletimSistemiTürüOlustur()
            {
                Cihaz[DonanımTipi.İşletimSistemiTürü] = "Android";
            }
            public override void EkranÇözünürlüğüOlustur()
            {
                Cihaz[DonanımTipi.EkranÇözünürlüğü] = "10,6 inç  2560 x 1600";
            }
        }
        public class Dukkan
        {
            private CihazOlusturucu _cihazolusturucu;

            public void Olustur(CihazOlusturucu cihazolusturucu)
            {
                _cihazolusturucu = cihazolusturucu;

                _cihazolusturucu.RamOlustur();
                _cihazolusturucu.İşlemciHızıOlustur();
                _cihazolusturucu.DahiliHafızaOlustur();
                _cihazolusturucu.İşletimSistemiTürüOlustur();
                _cihazolusturucu.EkranÇözünürlüğüOlustur();
            }

            public void CihazıGoster()
            {
                _cihazolusturucu.Cihaz.ParcalariGoster();
            }
        }      
    
        static void Main(string[] args)
        {
            var dukkan = new Dukkan();
            dukkan.Olustur(new CepTelefonuOlusturucu());
            dukkan.CihazıGoster();

            dukkan.Olustur(new HibritBilgisayarOlusturucu());
            dukkan.CihazıGoster();

            dukkan.Olustur(new TabletBilgisayarOlusturucu());
            dukkan.CihazıGoster();
            Console.Read();
        }
    }
}
