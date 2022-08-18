using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // sepete ürün ekleme işlenmi 
        // normal paratez () metot çalışıyo demek
        // syntax
        // ekleyi çağırınca o süslü parantez bloğu içi defalarca çalışır ister 1 satır olsun ister 100
         public void Ekle( Urun urun )
        {
            Console.WriteLine("Sepete Eklendi");
            // şöylede oluır
            Console.WriteLine("tebrikler sepetinize eklendi : " + urun.Adi);
            // ne şekil istersek öyle yaparız

            

            }

           public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
            {
                Console.WriteLine("tebrikler sepetinize eklendi : " + urunAdi);
            }

            
        // yukarıdaki farklı bir yapış şekli ama yanlış çünkü daha sonra buradan bir şey eklemek istedik mesela stokadedi diğer taraf eror verir
        // her sayfadan ayrı ayrıdeğişirmek gerekir ama bizim yaptımız türden yaparsak yani Urun urun yazıpp yapmak lazım ve stokadedi eklemek istediğimzide tek yapmamız gereken şey
        //urun.cs kısmına public int StokAdedi {get set } eklemek olur çünkü ddirek tümden Urun e eklemiş oluruz
        //buna "encapsulation" denir. kapsülleme yani ayrı aryı yazılanı bir düzene sokup yazmak.


        }
    }

