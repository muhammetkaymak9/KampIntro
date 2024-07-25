namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Çilekssss";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            //type-safe -- tip güvnliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("------------------Metotlar-----------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}

//Do not repeat yourself - DRY
//Clean Code - Best Practice
