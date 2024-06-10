using System;
using System.Collections.Generic;
using System.Text;

namespace ErayEmlak
{
    public abstract class Ev
    {
        public int OdaSayisi { get; set; }
        public int KatNumarasi { get; set; }
        public int Alan { get; set; }
        public int Fiyat { get; set; }
        public int Aidat { get; set; }

        public override string ToString()
        {
            return $"Oda Sayısı: {OdaSayisi}, Kat Numarası: {KatNumarasi}, Alan: {Alan}, Fiyat: {Fiyat}, Aidat: {Aidat}";
        }
    }
}


