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
    public partial class personelekle : Form
    {
        SqlConnection perseklee = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public personelekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yoneticiarayuz yoneticiarayuz = new yoneticiarayuz();
            yoneticiarayuz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }
        private void ekle()
        {
           
            {
                if (perseklee.State == ConnectionState.Closed)
                {
                    perseklee.Open();
                }
                string kayit = " insert into personel (persism,persoy,persmail,perstel,perssif) values (@pi,@ps,@pm,@pt,@psf) ";
                SqlCommand imslemm = new SqlCommand(kayit, perseklee);
                imslemm.Parameters.AddWithValue("@pi", textBox1.Text);
                imslemm.Parameters.AddWithValue("@ps ", textBox2.Text);
                imslemm.Parameters.AddWithValue("@psf", textBox3.Text);
                imslemm.Parameters.AddWithValue("@pt", textBox4.Text);
                imslemm.Parameters.AddWithValue("@pm", textBox5.Text);
                imslemm.ExecuteNonQuery();
                perseklee.Close();
                MessageBox.Show("Kayıt Başarılı");
                return;
            }
           
            {
             //   MessageBox.Show("Bilgileri Kontol Ediniz.");
            }
        }
    }
}
