namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Muhammet";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ahmet";
            kurs1.IzlenmeOrani = 28;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Adem";
            kurs2.IzlenmeOrani = 38;

            /*Console.WriteLine(kurs1.KursAdi);*/

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
