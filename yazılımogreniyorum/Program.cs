using System;

namespace yazılımogreniyorum
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi ="Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };  /* bu bir array dir.*/

            Urun urun1 = new Urun();     /* class tanımlamak ıcın ornek olusturuldu. bir class olduğu zaman new'lemek lazım !*/
            urun1.Adi ="Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi ="Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };  /* bu bir array dir. */


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------------METOTLAR----------------");
            // instance-örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Kayısı", 20, "Malatya Kayısısı", 10);
            sepetManager.Ekle2("Armut", 30, "Yeşil Armut", 35);
            sepetManager.Ekle2("Muz", 60, "Manzano Muz", 8);
        }
    }
}
