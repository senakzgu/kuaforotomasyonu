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
using static System.Windows.Forms.DataFormats;

namespace projem
{
    public partial class Hizmetyönetimi : Form
    {
        

       

        public Hizmetyönetimi()
        {
            InitializeComponent();
            
        
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Hizmet hizmet = new Hizmet();
            hizmet.hizmetadi = textBox1.Text;
            hizmet.hizmetsaati = textBox2.Text;
            hizmet.hizmetücreti = textBox3.Text;

            using (StreamWriter yazici = new StreamWriter("hizmet.txt", true))
            {
                yazici .WriteLine(hizmet.hizmetadi + " " + hizmet.hizmetsaati + " " + hizmet.hizmetücreti);
            }

            
            

            MessageBox.Show("Hizmet başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
