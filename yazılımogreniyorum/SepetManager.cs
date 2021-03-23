using System;
using System.Collections.Generic;
using System.Text;

namespace yazılımogreniyorum
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi! :" + urun.Adi /*+ " "+ urun.Fiyati + " "+urun.Aciklama +" "+ urun.StokAdedi*/);
        }

        public void Ekle2(string urunAdi, double fİyati, string aciklama, int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi! :" + urunAdi/* +" " +fİyati +" "+ aciklama +" "+ StokAdedi*/);
        }
    }
}
