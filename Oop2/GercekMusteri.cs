using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual
    class GercekMusteri: Musteri  //gerçek müşteri, müşteridir yani müşteride ki özellikleri kullanır
    {
        public string TcNo { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
    }
}
