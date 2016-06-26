using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKdvHesapla
{
    public class Sayisal
    {
        public static decimal DecimalYap(string metin)
        {
            // "_ _ _ _,_ _ TL" eğer boşluk bırakılırsa bu gelir bize..

            metin = metin.Replace(" TL", "");
            metin = metin.Trim();

            //tutar = tutar.TrimEnd(',');
            //tutar = tutar.Trim();

            // Virgülden sonra rakam yoksa(virgül son karakter ise) virgülden kurtul.
            // "2  ," şu an ki hali..
            int index = metin.LastIndexOf(',');

            if (index == metin.Length - 1)
            {
                metin = metin.Replace(",", ""); // "2  "
                metin = metin.Trim(); // "2"
            }

            if (metin == "")
            {
                metin = "0";
            }

            // ",_2" şeklinde gelirse patlıyordu. Çözdük...
            metin = metin.Replace(" ", "0");

            decimal decTutar = decimal.Parse(metin);

            return decTutar;
        }
    }
}
