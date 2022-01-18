using System;
using System.Collections.Generic;
using System.IO;

namespace SozlukUygulamasi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            {
                Console.WriteLine("İngilizce sözcükler ve Türkçe karşılıkları:");

                var kelimeKarsiligi = new SortedDictionary<string, List<string>>()
            {
                { "Boost", new List<string>() { "Artirmak", "Kaldirmak", "Yukseltmek" } },
                { "Void", new List<string>() { "Gecersiz", "Bosluk", "Faydasiz" } },
           };
                foreach (var kavram in kelimeKarsiligi)
                {
                    Console.Write(kavram.Key);
                    kavram.Value.ForEach(s => Console.Write(","+s));
                    Console.WriteLine();

                }


                string dosyaAdi = @"C:\Users\mnuri\source\repos\SozlukUygulamasi\IngilizceTurkceSozluk.txt";


                foreach (var kavram in kelimeKarsiligi)
                {
                    Console.WriteLine(kavram.Key);
                    kavram.Value.ForEach(s => Console.WriteLine("\t>" + s));
                }
                foreach (string Line in System.IO.File.ReadLines(dosyaAdi))
                {
                    string[] kelimeler = Line.Split(',');
                    if (!kelimeKarsiligi.ContainsKey(kelimeler[0]))
                    {
                        var karsiliklari = new List<string>();
                        for (int i = 1; i < kelimeler.Length; i++)
                        {
                            karsiliklari.Add(kelimeler[i]);
                        }
                        kelimeKarsiligi.Add(kelimeler[0], karsiliklari);
                    }
                }
                Console.WriteLine();
                foreach (var kavram in kelimeKarsiligi)
                {
                    Console.WriteLine(kavram.Key);
                    kavram.Value.ForEach(s => Console.WriteLine("\t>" + s));
                }

                foreach (var kavram in kelimeKarsiligi)
                {
                Console.Write(kavram.Key);
                kavram.Value.ForEach(s => Console.Write("," + s));
                Console.WriteLine();
                }
                

                string[] ceviriler1 = new string[4];
                ceviriler1[0] = "Boost";
                ceviriler1[1] = "Artirmak";
                ceviriler1[2] = "Kaldirmak";
                ceviriler1[3] = "Yukseltmek";
                string line1 = string.Join(',', ceviriler1);
                Console.WriteLine(line1);

                string[] ceviriler2 = new string[4];
                ceviriler2[0] = "Declined";
                ceviriler2[1] = "Azalmak";
                ceviriler2[2] = "Cevirmek";
                ceviriler2[3] = "Curumek";
                string line2 = string.Join(',', ceviriler2);
                Console.WriteLine(line2);

                string[] ceviriler3 = new string[3];
                ceviriler3[0] = "Sway";
                ceviriler3[1] = "Sallanmak";
                ceviriler3[2] = "Dalgalanmak";
                string line3 = string.Join(',', ceviriler3);
                Console.WriteLine(line3);

                var yazilirmi = true;

                foreach (string line in System.IO.File.ReadLines(dosyaAdi))
                {
                    if (line == line1)
                    {
                        yazilirmi = false;
                    }
                }
                if (yazilirmi)

                {
                    StreamWriter writer = File.AppendText(dosyaAdi);
                    writer.WriteLine(line1);
                    writer.Close();

                }
                var yazilmalimi = true;

                foreach (string line in System.IO.File.ReadLines(dosyaAdi))
                {
                    if (line == line2)
                    {
                        yazilmalimi = false;
                    }
                }
                if (yazilmalimi)

                {
                    StreamWriter writer = File.AppendText(dosyaAdi);
                    writer.WriteLine(line2);
                    writer.Close();

                }

            }
              
                Console.ReadKey();
            }

           

    }
}  