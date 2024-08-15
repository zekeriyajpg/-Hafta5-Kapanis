using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        do
        {
            Console.Write("Araba üretmek ister misiniz? (e/h): ");
            cevap = Console.ReadLine().ToLower();

            if (cevap != "e" && cevap != "h")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' harfini giriniz.");
            }

        } while (cevap != "e" && cevap != "h");

        while (cevap == "e")
        {
            Araba yeniAraba = new Araba();

            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

        KapisayisiGir:
            try
            {
                Console.Write("Kapı Sayısı: ");
                yeniAraba.KapiSayisi = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Kapı sayısı sayısal bir değer olmalıdır.");
                goto KapisayisiGir;
            }

            arabalar.Add(yeniAraba);

            Console.Write("Başka bir araba üretmek ister misiniz? (e/h): ");
            cevap = Console.ReadLine().ToLower();

            if (cevap != "e" && cevap != "h")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' harfini giriniz.");
                goto KapisayisiGir;
            }
        }

        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}, Model : {araba.Model}");
        }
    }
}
