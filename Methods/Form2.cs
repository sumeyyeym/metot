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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void DonguluMetot() //METOT KISMIMIZ
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekBir_Click(object sender, EventArgs e)
        {
            DonguluMetot();
        }

        void Degis()
        {
            /*
            this.Height = 400;
            this.Width = 400;
            */
            this.Size = new Size(400, 400); //yukardakinin aynısı ama tek satır hali
            this.BackColor = Color.White;
        }

        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {
            //formun genişliğini 400*400 ve arka plan rengini beyaz yapan metot yazınız
            Degis();
        }
    }
}
