namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type-safety
            //Do not repeat yourself
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }


            if (sistemeGirisYapmisMi == true )
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
