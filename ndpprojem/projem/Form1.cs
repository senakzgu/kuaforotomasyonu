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
namespace projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            müşteriekle musteriekle = new müşteriekle();
            musteriekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Çalışanyönetimi calisanyonetimi = new Çalışanyönetimi();
            calisanyonetimi.ShowDialog();



        }
        public void button2_Click(object sender, EventArgs e)
        {

            Randevu randevu = new Randevu();
            randevu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hizmetyönetimi hizmetyönetimi = new Hizmetyönetimi();
            hizmetyönetimi.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kaydedilmişrandevular kaydedilmişrandevular = new kaydedilmişrandevular();
            kaydedilmişrandevular.ShowDialog();
        }
    }
}
