using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    public class Musteri
    {
        public int MusteriNo { get; set; }
        public int IslemSuresi { get; set; }
        public Musteri(int musteriNo)
        {
            Random rastgele = new Random();
            IslemSuresi = rastgele.Next(60,600);
            System.Threading.Thread.Sleep(500);
            this.MusteriNo = musteriNo;
        }





    }
}
