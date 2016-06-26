using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKdvHesapla
{
    public class Harcama
    {
        public static int KdvOran { get; private set; } = 18;
        public static void KdvOranDegistir(int yeniDeger)
        {
            if (yeniDeger < 8)
            {
                yeniDeger = 8;
            }

            if (yeniDeger > 24)
            {
                yeniDeger = 24;
            }

            KdvOran = yeniDeger;
        }
        public static decimal TutarDecimalGetir(string tutar)
        {
            return Sayisal.DecimalYap(tutar);
        }

        public string Baslik { get; set; }
        public decimal Tutar { get; set; }  // kdvsiz tutar..
        public decimal ToplamTutar { get; private set; } // kdv li tutar..

        public void ToplamTutarHesapla()
        {
            decimal kdvTutari = Tutar * KdvOran / 100;
            ToplamTutar += kdvTutari + Tutar;
        }

        public override string ToString()
        {
            return Baslik + " - " + ToplamTutar;
        }
    }
}
