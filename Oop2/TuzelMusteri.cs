using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate Tüzel müşteri ENG hali
    class TuzelMusteri:Musteri  // bu olaya miras yani inheritance denir. 
       // Tüzel müsteriye sen bir müşteri sınıdfındansın demek oluyor. 
       //Müşteride olan özellikler artık tüzel müşteri ve gerçek müşteride vardır demektir.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
