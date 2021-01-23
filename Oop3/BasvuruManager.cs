using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //Method injection  burada hangi kredi ve hnagi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme
            // gibi gibi birçok simülasyon yapılır

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
