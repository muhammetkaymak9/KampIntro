﻿namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] 
            { 
                "yazılım geliştirici kampı", 
                "programlamaya başlangıç için temel kurs",
                "java"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                //Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
