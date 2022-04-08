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
    public partial class uyearayuz : Form
    {
        public uyearayuz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyebiletal uyebiletal = new uyebiletal() ;
            uyebiletal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Üye_Şifremi_Değiştir üye_Şifremi_Değiştir = new Üye_Şifremi_Değiştir();
            üye_Şifremi_Değiştir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uyeıcınbıletgoruntuleme uyeıcınbıletgoruntuleme = new uyeıcınbıletgoruntuleme();
            uyeıcınbıletgoruntuleme.Show();
        }
    }
}
