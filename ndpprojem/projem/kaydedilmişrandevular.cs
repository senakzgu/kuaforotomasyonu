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
using System.IO;

namespace projem
{
    public partial class kaydedilmişrandevular : Form
    {
        public kaydedilmişrandevular()
        {
            InitializeComponent();
        }

        private void kaydedilmişrandevular_Load(object sender, EventArgs e)
        {
            using (StreamReader okuyucu = new StreamReader("randevu.txt"))

            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);

                string dosyaYolu = "randevu.txt";

                try
                {

                    // Dosyayı oku ve satırları bir listeye aktar
                    var satirlar = File.ReadAllLines(dosyaYolu).ToList();

                    // Seçilen indeksi kontrol et
                    if (selectedIndex < satirlar.Count)
                    {
                        // Listedeki seçilen indeksteki satırı sil
                        satirlar.RemoveAt(selectedIndex);

                        // Dosyayı yeniden yaz
                        File.WriteAllLines(dosyaYolu, satirlar);

                        MessageBox.Show("Seçilen öğe başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Seçilen indeks dosyada mevcut değil.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }


            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir öğe seçiniz!");
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    int selectedIndex = listBox1.SelectedIndex;

                    // ListBox'tan seçilen öğenin metnini al
                    string selectedText = textBox1.Text;

                    // ListBox'taki seçilen öğeyi güncelle
                    listBox1.Items[selectedIndex] = selectedText;

                    // Dosya yolu
                    string dosyaYolu = "randevu.txt";

                    try
                    {
                        // Dosyayı oku ve satırları bir listeye aktar
                        var satirlar = File.ReadAllLines(dosyaYolu).ToList();

                        // Seçilen indeksi kontrol et
                        if (selectedIndex < satirlar.Count)
                        {
                            // Seçilen öğenin metnini güncelle
                            satirlar[selectedIndex] = selectedText;

                            // Dosyayı güncel satırlarla yeniden yaz
                            File.WriteAllLines(dosyaYolu, satirlar);

                            MessageBox.Show("Seçilen öğe başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Seçilen indeks dosyada mevcut değil.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir metin giriniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir öğe seçiniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ListBox'tan seçilen öğenin metnini TextBox'a yaz
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
