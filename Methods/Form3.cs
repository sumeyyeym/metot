using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region Örnek 1
        void ParametreliMetot(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {
            ParametreliMetot(int.Parse(txtDeger1.Text));
        }
        #endregion

        #region Örnek 2
        void Islem(int s1, int s2)
        {
            //int sonuc = (s1 + s2) * (s1 + s2) * (s1 + s2);

            int toplam = s1 + s2;
            int sonuc = Convert.ToInt32(Math.Pow(toplam, 3)); //math kütüphanesinden küpünü alma işlemini getirdik
            MessageBox.Show("İşlemin sonucu:" + sonuc);
        }

        private void BtnOrnekDort_Click(object sender, EventArgs e)
        {
            //dışarıdan gelen iki sayının toplamının küpünü mb ile gösteren bir metot
            Islem(int.Parse(txtDeger1.Text), int.Parse(txtDeger2.Text));
        }
        #endregion

        #region Örnek 3
        void SonUc(string yaz)
        {
            /*
             
            if (yaz.Length <= 3)
            {
                MessageBox.Show(yaz);
            }
            else
            {
                yaz = yaz.Substring(yaz.Length - 3);
                MessageBox.Show(yaz);
            }
             
            */

            MessageBox.Show(yaz.Length <= 3 ? yaz : yaz.Substring(yaz.Length - 3));
        }

        private void BtnKirp_Click(object sender, EventArgs e)
        {
            //dışarıdan girilen değerin son 3 harfini mb içeriisnde bir metod yazınız girilen değer 3 harften azsa ya da 3 harfe eşitse direkt olarak tamamını göstersin

            SonUc(txtDeger1.Text);
        }
        #endregion

        #region Örnek 4
        void AyirEkle(string mailler)
        {
            string[] mail = mailler.Split('@');
            foreach (string m in mail)
            {
                listBox1.Items.Add(m);
            }
        }

        private void BtnListBoxaDoldur_Click(object sender, EventArgs e)
        {
            //dışarıdan girilen mailleri ayırarak list boxa ekle
            AyirEkle(txtDeger1.Text);
        }
        #endregion

        void ArkaPlan(string color)
        {
            this.BackColor = Color.FromName(color);
        }

        private void CmbRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSesliKontrolu_Click(object sender, EventArgs e)
        {
            //ODEV
        }

        private void BtnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            ArkaPlan(cmbRenkler.Text);
        }
    }
}
