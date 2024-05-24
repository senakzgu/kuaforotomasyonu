/*
                                SAKARYA ÜNİVERSİTESİ 
                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                         NESNEYE DAYALI PROGRAMLAMA DERSİ
                              2023-2024 BAHAR DÖNEMİ
                   


              ÖDEV NUMARASI : 3
              ÖĞRENCİ ADI : SENA KUZĞU
              ÖĞRENCİ NUMARASI : G231210385
              DERSİN ALINDIĞI GRUP : 2B

 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime randevutarihi = dateTimePicker1.Value;
            string saat = comboBox2.SelectedItem.ToString();
            string hizmet = comboBoxhizmet.SelectedItem.ToString();
            string personel = comboBox3.SelectedItem.ToString();
            string musteri = comboBox1.SelectedItem.ToString();

            using (StreamWriter yazici = new StreamWriter("randevu.txt", true))
            {
                yazici.WriteLine(musteri + "|" + hizmet + "|" + personel + "|" + randevutarihi + "|" + saat);
            }

            MessageBox.Show("Randevu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            using (StreamReader okuyucu =new StreamReader("hizmet.txt") )

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    comboBoxhizmet.Items.Add(satir);
                }
            }

            using (StreamReader okuyucu = new StreamReader("personel.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    comboBox3.Items.Add(satir);
                }
            }

            using (StreamReader okuyucu = new StreamReader("müsteri.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    comboBox1.Items.Add(satir);
                }
            }


            
        }
    }
}
