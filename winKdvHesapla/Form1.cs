using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winKdvHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Harcama harcamam = new Harcama();
            harcamam.Baslik = txtBaslik.Text;

            string hamTutar = txtTutar.Text;
            hamTutar = hamTutar.Trim(); // Başta ve sondaki boşluktan kurtarır.
            hamTutar = hamTutar.Substring(0, hamTutar.Length - 3);  // Sondaki " TL" 'den kurtuluruz.
            //hamTutar = hamTutar.Replace(" TL", "");
            //hamTutar = hamTutar.Replace(',', '.'); // "," kısmı "." olur.

            harcamam.Tutar = decimal.Parse(hamTutar);
            harcamam.ToplamTutarHesapla();

            lstHarcamalar.Items.Add(harcamam);

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {
            decimal decTutar = Harcama.TutarDecimalGetir(txtTutar.Text);

            decimal kdv = decTutar * Harcama.KdvOran / 100;
            decimal toplam = kdv + decTutar;

            txtToplam.Text = toplam.ToString();
        }
    }
}
