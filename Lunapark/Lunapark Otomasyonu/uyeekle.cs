using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lunapark_Otomasyonu
{
    public partial class uyeekle : Form
    {
        SqlConnection uyeeklee = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyeekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uyeeklee.State == ConnectionState.Closed)
            {
                uyeeklee.Open();
            }
            try
            {
                string kayit = " insert into uyeler (isim,soyisim,sifre,telefon,email,boy,kilo,yas,bakiye) values (@i,@si,@s,@t,@e,@b,@k,@y,@bak) ";
                SqlCommand islem = new SqlCommand(kayit, uyeeklee);
                islem.Parameters.AddWithValue("@i", textBox1.Text);
                islem.Parameters.AddWithValue("@si ", textBox2.Text);
                islem.Parameters.AddWithValue("@s", textBox3.Text);
                islem.Parameters.AddWithValue("@t", textBox4.Text);
                islem.Parameters.AddWithValue("@e", textBox5.Text);
                islem.Parameters.AddWithValue("@b", textBox6.Text);
                islem.Parameters.AddWithValue("@k", textBox7.Text);
                islem.Parameters.AddWithValue("@y", textBox8.Text);
                islem.Parameters.AddWithValue("@bak", textBox9.Text);
                islem.ExecuteNonQuery();
                uyeeklee.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch {
                MessageBox.Show("Hata");
                    }
       
        }
    }
}
