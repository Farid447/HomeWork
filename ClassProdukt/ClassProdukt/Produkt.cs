using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProdukt
{
    public class Produkt
    {
        public string ad;
        public string brendad;
        public double qiymet;
        public Produkt(string ad, string brendad, double qiymet)
        {
            this.ad = ad;
            this.brendad = brendad;
            this.qiymet = qiymet;
        }
    }
}

