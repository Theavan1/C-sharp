using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Araba: Ruhsat
    {
        public string renk;
        public int hız;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        public int YIL
        {
            get { return yil; } set { yil = Math.Abs(value); }
        }
        public string MARKA
        { get { return marka; } set {marka = value.ToUpper(); } }
    }
}
