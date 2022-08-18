using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Urun
    {
        // classlaın  property özellik kullanımı var 2. de manager kullanımı
        // menegarlar operasyon tutar ortak kod  mesela sepete ekle butonu eticaret sitesi
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int MyProperty { get; set; }

    }
}
