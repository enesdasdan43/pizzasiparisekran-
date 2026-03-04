using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSiparisToplam.Enabled = false;
            double toplamfiyat = 0;
            int adet = 0;
          
            if (int.TryParse(txtAdet.Text, out adet) && adet > 0)
            {
                string secilenboyut = cbEbat.SelectedItem.ToString();
                if (secilenboyut == "Double Small 100Tl")
                {
                    toplamfiyat += 100 * adet;
                }
                else if (secilenboyut == "Small 120Tl")
                {
                    toplamfiyat += 120 * adet;
                }
                else if (secilenboyut == "Medium 150TL")
                {
                    toplamfiyat += 120 * adet;
                    
                }
                else if (secilenboyut == "Large 210Tl")
                {
                    toplamfiyat += 210 * adet;
                }
                else if (secilenboyut == "Double Large 250Tl")
                {
                    toplamfiyat += 250 * adet;
                }

                if (radioButton1.Checked)
                {
                    toplamfiyat += 15 * adet;
                }
            }

            txtSiparisToplam.Text = toplamfiyat.ToString() + "Tl";




        }
    }
}
