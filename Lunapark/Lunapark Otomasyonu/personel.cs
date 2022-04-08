using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunapark_Otomasyonu
{
    public partial class personel : Form
    { 
        public personel()
        {
            InitializeComponent();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            yetkiligiris yetkiligiris = new yetkiligiris();
            yetkiligiris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yoneticimail yoneticimail = new yoneticimail();
            yoneticimail.Show();
            this.Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            oyuncakekle oyuncakekle = new oyuncakekle();
            oyuncakekle.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyuncakduzenle oyuncakduzenle = new oyuncakduzenle();
            oyuncakduzenle.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            uyeekle uyeekle = new uyeekle();
            uyeekle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uyebakiyeduzenle uyebakiyeduzenle = new uyebakiyeduzenle();
            uyebakiyeduzenle.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            biletgoruntule biletgoruntule = new biletgoruntule();
            biletgoruntule.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uyecıkar uyecıkar = new uyecıkar();
            uyecıkar.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeguncelleme uyeguncelleme = new uyeguncelleme();
            uyeguncelleme.Show();
        }
    }
}
