using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SınavOdev_0.Models;

namespace SınavOdev_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AnaYemek> yemek = new List<AnaYemek>
            {
                new AnaYemek{Ad ="İskender",Fiyat=210},
                new AnaYemek{Ad ="Lahmacun",Fiyat=50},
                new AnaYemek{Ad ="Kıymalı Pide",Fiyat=170},
                new AnaYemek{Ad ="Beyti",Fiyat=230},
                new AnaYemek{Ad ="Adana Kebap",Fiyat=180},

            };
            cmbAnaYemek.DataSource = yemek;
            cmbAnaYemek.SelectedIndex = -1;

          
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis(txtMasaNo.Text);
           
            if (txtMasaNo.Text.Length == 0)
            {
                MessageBox.Show("Lütfen oturduğunuz masa no giriniz");


            }
            s.SecilenAnaYemek = cmbAnaYemek.SelectedItem as AnaYemek;

            if (cmbAnaYemek.SelectedItem == null)
            {
                MessageBox.Show("Lütfen istediğiniz bir şey seçiniz");
            }
            
                

                foreach (CheckBox item in gbTatlilar.Controls)
                {
                    if (item.Checked)
                    {
                        TatliVeIcecek eks = new TatliVeIcecek(item.Text, Convert.ToDecimal(item.Tag));
                        s.Ekstralar.Add(eks);

                    }

                }
                foreach (CheckBox item in gbIcecekler.Controls)
                {
                    if (item.Checked)
                    {
                        TatliVeIcecek eks = new TatliVeIcecek(item.Text, Convert.ToDecimal(item.Tag));
                        s.Ekstralar.Add(eks);

                    }


                }
                foreach (CheckBox item in gbAra.Controls)
                {
                    if (item.Checked)
                    {
                        TatliVeIcecek eks = new TatliVeIcecek(item.Text, Convert.ToDecimal(item.Tag));
                        s.Ekstralar.Add(eks);

                    }
               
                }
            s.Tutar();
            lstIcerik.Items.Add(s);
           
            


        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            decimal ciro = 0;

            foreach (Siparis item in lstIcerik.Items)
            {
                ciro += Convert.ToDecimal(item.Fiyat);

            }
            MessageBox.Show($"Toplam ciro => {ciro:C2}");
        }
    }
}
