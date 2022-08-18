// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { };
// Mesela burada sadece string leri dizide tanımlayabilirz ama ürün fiyatını da kaatmak istersem class kulanmak zorundayım.


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1,urun2};
// burası dizi tanımı manuel olarak yazıyoruz. diziler çoğul isimlendirillri
// foreach yazınca urunler diye bi dizim var onun her elemanını tek tek gez demmiş oluyoruz genelde foreach ile yaparız kaç tane sayıda olursa olsun
// ilk Urun veri tipi olarak neyle çalışacağını bilmek için (Var) da yazılabilir
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console .WriteLine(urun.Aciklama); 
    
}

Console.WriteLine("----------------Metotlar---------------");
// class çağır ve örneğini oluştur.
// instance -  class örnek

SepetManager SepetManager = new SepetManager();
SepetManager.Ekle(urun1);
SepetManager.Ekle(urun2);




//ÇIKTI OLARAK ARTIK : TEBRİKLER SEPETİNİZE EKLENDİ : ELMA    YAZAR
//ÇIKTI OLARAK ARTIK : TEBRİKLER SEPETİNİZE EKLENDİ : KARPUZ    YAZAR


// 5 farklı yerde sepete eklendi yazdı atıyorum bi şey değiştirceez tebrikler sepete eklendi yazıcaz her sayfadan değiştirmeye gerek yok
// sepetmanager kısmından oraya tebrikler yazarsak ve tekrar çalıştırırsak otomatik bütün sayfalardaki yazı değişir.


// dont repeat yourself -DRY-  Clean Code - Best Practice
