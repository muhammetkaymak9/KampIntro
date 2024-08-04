namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "122345";
            musteri1.TcNo = "222222222";
            musteri1.Adi = "Muhammet";
            musteri1.Soyadi = "Kaymak";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "122345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12324345672413";

            Musteri musteri3 =  new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();

        }
    }
}
