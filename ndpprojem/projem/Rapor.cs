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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projem
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            using (StreamReader okuyucu = new StreamReader("hizmet.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);
                }
            }

            using (StreamReader okuyucu = new StreamReader("personel.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    listBox2.Items.Add(satir);
                }
            }

            using (StreamReader okuyucu = new StreamReader("müsteri.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    listBox3.Items.Add(satir);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
