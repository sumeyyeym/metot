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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //metod overloada açıklama ekleme işlemi

        /// <summary>
        /// Verilen kullanıcı adına göre hotmail.com adresi teslim edilir.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakarak kullanıcı adı ve soyadı parametresi veriniz.</param>

        void MailOlustur(string user) // bir tane parametre verdik çünkü aşağıdaki metoddan farklılaşması gerek. iki tane de parametre verilebilirdi ancak verilecek bu parametrein aşağıdaki ile aynı olmaması gerek. yoksa ikisi de ayrışamaz.
        {
            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1].ToLower()}@hotmail.com";
            MessageBox.Show(mail);
        }

        /// <summary>
        /// Verilen kullanıcı adına ve seçilen domain adresine göre mail adresi teslim edilir.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakarak kullanıcı adı ve soyadı parametresi veriniz.</param>
        /// <param name="domain">Geçerli bir sunucu adı seçiniz.</param>

        void MailOlustur(string user, string domain)
        {
            //user = user.Replace("ı", "i").Replace("ç", "c").Replace("ü", "u").Replace("ğ", "g").Replace("ö", "o").Replace("ş", "s").Replace(" ",".");
            //user = user.ToLower();
            //MessageBox.Show("Mail adresiniz: " + user + "@" + domain);

            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1].ToLower()}@{domain}";
            MessageBox.Show(mail);
        }

        private void BtnMailOlustur_Click(object sender, EventArgs e)
        {
            if (cmbSunucuAdlari.SelectedIndex == -1) //yai diyor ki eğer kombo boxta herhangi bir seçenek seçilmemişse. selected index, seçilen seçeneğin indexi. -1 olma sebebi de indexlerin 0dan başlaması
            {
                MailOlustur(txtMailKullaniciAdi.Text);
            }
            else
            {
                MailOlustur(txtMailKullaniciAdi.Text, cmbSunucuAdlari.Text);
            }            
        }
    }
}
