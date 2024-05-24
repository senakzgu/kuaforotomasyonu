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
    public partial class müşteriekle : Form
    {
        public müşteriekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri yenimusteri = new Musteri();
            yenimusteri.Ad = textBox1.Text;
            yenimusteri.Soyad = textBox2.Text;
            yenimusteri.Telefon = textBox3.Text;
            yenimusteri.Tc = textBox4.Text;

            using (StreamWriter yazici = new StreamWriter("müsteri.txt", true))
            {
                yazici.WriteLine(yenimusteri.Ad + " " + yenimusteri.Soyad + " " + yenimusteri.Telefon + " " + yenimusteri.Tc);
            }

            MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void müşteriekle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
