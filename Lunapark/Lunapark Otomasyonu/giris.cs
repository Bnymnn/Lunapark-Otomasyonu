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
    public partial class Giriş : Form
    {
        SqlConnection oyuncak = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Giriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yetkiligiris yetkiligiris = new yetkiligiris();
            yetkiligiris.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            onerisikayet onerisikayet = new onerisikayet();
            onerisikayet.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from oyuncak where ıd like '" + textBox5.Text + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int a = Convert.ToInt32(sqlDataReader["oynminboy"]);
                int b = Convert.ToInt32(sqlDataReader["oynmaxboy"]);
                int c = Convert.ToInt32(sqlDataReader["oynminkil"]);
                int d = Convert.ToInt32(sqlDataReader["oynmaxkil"]);
                int f = Convert.ToInt32(sqlDataReader["oynminyas"]);
              
                int boy = Convert.ToInt32(textBox2.Text);
                int kil = Convert.ToInt32(textBox3.Text);
                int yas = Convert.ToInt32(textBox4.Text);
                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
                {
                    if (boy >= a)
                    {
                        if (boy <= b)
                        {
                            if (kil >= c)
                            {
                                if (kil <= d)
                                {
                                    if (yas >= f)
                                    {
                                        MessageBox.Show("Tebrikler "+ textBox1.Text+ " Gerekli Şartları Sağlamaktasın. Üyeliğiniz  Veya Personellerimiz Aracılığıyla Biletinizi Alıp Eğlenmeye Başlayabilirisiniz!");
                                    }
                                    else MessageBox.Show("Üzgünüz, Gerekli Yaş Aralığının Altındasınız.");

                                }
                                else MessageBox.Show("Üzgünüz , Gerekli Kilo Aralığının Üstündesiniz.");

                            }
                            else MessageBox.Show("Üzgünüz , Gerekli Kilo Aralığının Altındasınız.");

                        }
                        else MessageBox.Show("Üzgünüz , Gerekli Boy Aralığının Üstündesiniz.");

                    }
                    else MessageBox.Show("Üzgünüz , Gerekli Boy Aralığının Altındasınız.");
                } 
                else MessageBox.Show("Lütfen Bilgilerinizin Hepsini Doldurduğunuzda Emin Olunuz");
                    
            }
            sqlDataReader.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            uyegiris uyegiris = new uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (listView1.SelectedItems.Count > 0)
            {
                textBox5.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }
        private void hazirlik()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from oyuncak", oyuncak);
            SqlDataReader oku = sqlcomm.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["oynis"].ToString());
                ekle.SubItems.Add(oku["oynminboy"].ToString());
                ekle.SubItems.Add(oku["oynmaxboy"].ToString());
                ekle.SubItems.Add(oku["oynminkil"].ToString());
                ekle.SubItems.Add(oku["oynmaxkil"].ToString());
                ekle.SubItems.Add(oku["oynminyas"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                listView1.Items.Add(ekle);



            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hazirlik();
            oyuncak.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from oyuncak where ıd like '" + textBox5.Text + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox6.Text = sqlDataReader["oynis"].ToString();
                string a = sqlDataReader["oynminboy"].ToString();
                string b = sqlDataReader["oynmaxboy"].ToString();
                string c = sqlDataReader["oynminkil"].ToString();
                string d = sqlDataReader["oynmaxkil"].ToString();
                string f = sqlDataReader["oynminyas"].ToString();
                textBox7.Text = a + "Cm - " + b + "Cm";
                textBox8.Text = c + "Kg - " + d + "Kg";
                textBox9.Text = f + " Yaş";
                sqlDataReader.Close();
                return;
            }
            sqlDataReader.Close();

        }
        private void sorgus()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from oyuncak where ıd like '" + textBox5.Text + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {

                string a = sqlDataReader["oynminboy"].ToString();
                string b = sqlDataReader["oynmaxboy"].ToString();
                string c = sqlDataReader["oynminkil"].ToString();
                string d = sqlDataReader["oynmaxkil"].ToString();
                string f = sqlDataReader["oynminyas"].ToString();

                sqlDataReader.Close();
                return;
            }
            sqlDataReader.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
        private void seçim()
        {
            textBox5.Text = listView1.Items[0].Text;
        }
    }   
}

