using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual Gerçek müşteri ENG hali
    class GercekMusteri: Musteri   // bu olaya miras yani inheritance denir. 
                                   // Tüzel müsteriye sen bir müşteri sınıdfındansın demek oluyor. 
                                   //Müşteride olan özellikler artık tüzel müşteri ve gerçek müşteride vardır demektir.                           
    {
       
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
