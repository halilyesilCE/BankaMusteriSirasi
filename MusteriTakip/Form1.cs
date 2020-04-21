using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Musteri musteri1 = new Musteri(0);
        Musteri musteri2 = new Musteri(1);
        Musteri musteri3 = new Musteri(2); 
        Musteri musteri4 = new Musteri(3);
        Musteri musteri5 = new Musteri(4);
        Musteri musteri6 = new Musteri(5);
        Musteri musteri7 = new Musteri(6);
        Musteri musteri8 = new Musteri(7);
        Musteri musteri9 = new Musteri(8);
        Musteri musteri10 = new Musteri(9);
        Musteri musteri11 = new Musteri(10);
        Musteri musteri12 = new Musteri(11);
        Musteri musteri13 = new Musteri(12);
        Musteri musteri14 = new Musteri(13);
        Musteri musteri15 = new Musteri(14);
        Musteri musteri16 = new Musteri(15);
        Musteri musteri17 = new Musteri(16);
        Musteri musteri18 = new Musteri(17);
        Musteri musteri19 = new Musteri(18);
        Musteri musteri20 = new Musteri(19);
        private void btnDaireselKuyruk_Click(object sender, EventArgs e)
        {
            DaireselKuyruk daireselkuyruk = new DaireselKuyruk(20);
            daireselkuyruk.Insert(musteri1);
            daireselkuyruk.Insert(musteri2);
            daireselkuyruk.Insert(musteri3);
            daireselkuyruk.Insert(musteri4);
            daireselkuyruk.Insert(musteri5);
            daireselkuyruk.Insert(musteri6);
            daireselkuyruk.Insert(musteri7);
            daireselkuyruk.Insert(musteri8);
            daireselkuyruk.Insert(musteri9);
            daireselkuyruk.Insert(musteri10);
            daireselkuyruk.Insert(musteri11);
            daireselkuyruk.Insert(musteri12);
            daireselkuyruk.Insert(musteri13);
            daireselkuyruk.Insert(musteri14);
            daireselkuyruk.Insert(musteri15);
            daireselkuyruk.Insert(musteri16);
            daireselkuyruk.Insert(musteri17);
            daireselkuyruk.Insert(musteri18);
            daireselkuyruk.Insert(musteri19);
            daireselkuyruk.Insert(musteri20);
            for (int i = 0; i < 20; i++)
            {
                Musteri musteri = (Musteri)daireselkuyruk.Remove();
                MessageBox.Show(musteri.MusteriNo + "No'lu " + musteri.IslemSuresi + " işlem süreli musterinin toplam islem Tamamlama Süresi " + daireselkuyruk.TamamlamaSuresi);
            }
            MessageBox.Show("Ortalama Islem Tamamlama Süresi " + daireselkuyruk.OrtalamaIslemTamamlanmaSuresi);
        }

        private void btnOncelikKuyruk_Click(object sender, EventArgs e)
        {

            OncelikKuyruk oncelikKuyruk = new OncelikKuyruk(20);
            oncelikKuyruk.Insert(musteri1);
            oncelikKuyruk.Insert(musteri2);
            oncelikKuyruk.Insert(musteri3);
            oncelikKuyruk.Insert(musteri4);
            oncelikKuyruk.Insert(musteri5);
            oncelikKuyruk.Insert(musteri6);
            oncelikKuyruk.Insert(musteri7);
            oncelikKuyruk.Insert(musteri8);
            oncelikKuyruk.Insert(musteri9);
            oncelikKuyruk.Insert(musteri10);
            oncelikKuyruk.Insert(musteri11);
            oncelikKuyruk.Insert(musteri12);
            oncelikKuyruk.Insert(musteri13);
            oncelikKuyruk.Insert(musteri14);
            oncelikKuyruk.Insert(musteri15);
            oncelikKuyruk.Insert(musteri16);
            oncelikKuyruk.Insert(musteri17);
            oncelikKuyruk.Insert(musteri18);
            oncelikKuyruk.Insert(musteri19);
            oncelikKuyruk.Insert(musteri20);
            for (int i = 0; i < 20; i++)
            {
                Musteri musteri = (Musteri)oncelikKuyruk.Remove();
                MessageBox.Show(musteri.MusteriNo + "No'lu " + musteri.IslemSuresi + " işlem süreli musterinin toplam islem Tamamlama Süresi " + oncelikKuyruk.TamamlamaSuresi);
            }
            MessageBox.Show("Ortalama Islem Tamamlama Süresi " + oncelikKuyruk.OrtalamaIslemTamamlamaSuresiHesapla());

        }
    }
}
