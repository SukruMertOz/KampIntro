using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //Syntax
        public void Ekle(Urun urun) { Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi); }
        public void Ekle2(string UrunAdi,string aciklama,double fiyat,int stokAdedi) { Console.WriteLine("Tebrikler. Sepete Eklendi : " + UrunAdi); }

    }
}
