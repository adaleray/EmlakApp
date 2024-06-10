using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ErayEmlak
{
    public class KiralikEv : Ev
    {
        public int Depozito { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Depozito: {Depozito}";
        }

        public static KiralikEv YeniKiralikEvGirisi()
        {
            Console.WriteLine("Kiralık Ev Bilgileri Giriniz");
            Console.Write("1. Evin odasayısı: ");
            int odaSayisi = int.Parse(Console.ReadLine());

            Console.Write("1. Evin Kat numarası: ");
            int katNumarasi = int.Parse(Console.ReadLine());

            Console.Write("1. Evin Alanı: ");
            int alan = int.Parse(Console.ReadLine());

            Console.Write("1. Evin Kirası: ");
            int kira = int.Parse(Console.ReadLine());

            Console.Write("1. Evin Depozitosu: ");
            int depozito = int.Parse(Console.ReadLine());

            Console.Write("1. Evin Aidatı: ");
            int aidat = int.Parse(Console.ReadLine());

            Console.WriteLine("Tamam/Devam?");
            string onay = Console.ReadLine();
            if (onay.ToUpper() == "TAMAM")
            {
                return new KiralikEv
                {
                    OdaSayisi = odaSayisi,
                    KatNumarasi = katNumarasi,
                    Alan = alan,
                    Fiyat = kira,
                    Depozito = depozito,
                    Aidat = aidat
                };
            }

            return null;
        }

        public static void DosyayaKaydet(KiralikEv ev, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{ev.OdaSayisi},{ev.KatNumarasi},{ev.Alan},{ev.Fiyat},{ev.Depozito},{ev.Aidat}");
            }
        }

        public static void EvleriGoruntule(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] evBilgileri = line.Split(',');
                        KiralikEv ev = new KiralikEv
                        {
                            OdaSayisi = int.Parse(evBilgileri[0]),
                            KatNumarasi = int.Parse(evBilgileri[1]),
                            Alan = int.Parse(evBilgileri[2]),
                            Fiyat = int.Parse(evBilgileri[3]),
                            Depozito = int.Parse(evBilgileri[4]),
                            Aidat = int.Parse(evBilgileri[5])
                        };
                        Console.WriteLine(ev.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Kayıtlı ev bulunamadı.");
            }
        }
    }
}