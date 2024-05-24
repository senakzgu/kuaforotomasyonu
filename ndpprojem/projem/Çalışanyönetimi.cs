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
    public partial class Çalışanyönetimi : Form
    {
        public Çalışanyönetimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel newpersonel = new Personel();
            newpersonel.Ad = textBox1.Text;
            newpersonel.Soyad = textBox2.Text;
            newpersonel.Telefon = textBox3.Text;

            using (StreamWriter yazici = new StreamWriter("personel.txt", true))
            {
                yazici.WriteLine(newpersonel.Ad + " " + newpersonel.Soyad + " " + newpersonel.Telefon);
            }

            MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Çalışanyönetimi_Load(object sender, EventArgs e)
        {

        }
    }
}
