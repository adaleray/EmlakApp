using ErayEmlak;
using System;
using System.Collections.Generic;
using System.IO;


namespace ErayProgram

{
    class Program
    {
        static void Main(string[] args)
        {
            List<KiralikEv> kiralikEvler = new List<KiralikEv>();
            List<SatilikEv> satilikEvler = new List<SatilikEv>();
            string kiralikFilePath = "kiralik_evler_Eray.txt";
            string satilikFilePath = "satilik_evler_Eray.txt";

            while (true)
            {
                Console.WriteLine("Emlakçı Uygulaması");
                Console.WriteLine("1- Kiralık Ev");
                Console.WriteLine("2- Satılık Ev");
                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    KiralikEvIslemleri(kiralikFilePath, kiralikEvler);
                }
                else if (secim == 2)
                {
                    SatilikEvIslemleri(satilikFilePath, satilikEvler);
                }

                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                string devamMi = Console.ReadLine();
                if (devamMi.ToUpper() != "E")
                {
                    Console.WriteLine("Başarıyla çıkış yaptınız.");
                    break;
                }
            }
        }

        static void KiralikEvIslemleri(string filePath, List<KiralikEv> kiralikEvler)
        {
            Console.WriteLine("1- Kayıtlı ev görüntüleme");
            Console.WriteLine("2- Yeni ev girişi");
            int kiralikSecim = int.Parse(Console.ReadLine());

            if (kiralikSecim == 1)
            {
                KiralikEv.EvleriGoruntule(filePath);
            }
            else if (kiralikSecim == 2)
            {
                var yeniEv = KiralikEv.YeniKiralikEvGirisi();
                if (yeniEv != null)
                {
                    kiralikEvler.Add(yeniEv);
                    KiralikEv.DosyayaKaydet(yeniEv, filePath);
                    Console.WriteLine("Girilen Evlerin bilgileri dosyaya kaydedildi.");
                }
            }
        }

        static void SatilikEvIslemleri(string filePath, List<SatilikEv> satilikEvler)
        {
            Console.WriteLine("1- Kayıtlı ev görüntüleme");
            Console.WriteLine("2- Yeni ev girişi");
            int satilikSecim = int.Parse(Console.ReadLine());

            if (satilikSecim == 1)
            {
                SatilikEv.EvleriGoruntule(filePath);
            }
            else if (satilikSecim == 2)
            {
                var yeniEv = SatilikEv.YeniSatilikEvGirisi();
                if (yeniEv != null)
                {
                    satilikEvler.Add(yeniEv);
                    SatilikEv.DosyayaKaydet(yeniEv, filePath);
                    Console.WriteLine("Girilen Evlerin bilgileri dosyaya kaydedildi.");
                }
            }
        }
    }
}