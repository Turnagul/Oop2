using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Turnagül";
            musteri1.Soyadi = "Gögüs Korkmaz";
            musteri1.TcNo = "122345663";
            musteri1.Id = 01;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 02;
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama io";
            musteri2.VergiNo = "545656";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();




            

        }
    }
}
