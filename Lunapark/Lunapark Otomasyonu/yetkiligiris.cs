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
    public partial class yetkiligiris : Form
    {



        SqlConnection personelle = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yetkiligiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum sifremiunuttum = new sifremiunuttum();
            sifremiunuttum.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticigris yoneticigris = new yoneticigris();
            yoneticigris.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (personelle.State == ConnectionState.Closed)
            {
                personelle.Open();
            }
            SqlCommand sqlcom = new SqlCommand("select * from personel , yonetim ", personelle);
            using (SqlDataReader sqlDataReader = sqlcom.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {

                    if (Convert.ToString(sqlDataReader["persism"]) == textBox1.Text && Convert.ToString(sqlDataReader["persoy"]) == textBox2.Text && Convert.ToString(sqlDataReader["perstel"]) == textBox3.Text && Convert.ToString(sqlDataReader["perssif"]) == textBox4.Text)
                    {
                        personel personele = new personel();
                        personele.lb_ism.Text = textBox1.Text;
                        personele.lb_soy.Text = textBox2.Text;
                        oyuncakduzenle.girissif = textBox4.Text;
                        uyeguncelleme.girissiffre = textBox4.Text;
                        yoneticimail.tel = textBox3.Text;
                        personele.Show();

                        this.Close();

                        return;
                    }
                    else if (Convert.ToString(sqlDataReader["yonism"]) == textBox1.Text && Convert.ToString(sqlDataReader["yonsoy"]) == textBox2.Text && Convert.ToString(sqlDataReader["yontel"]) == textBox3.Text && Convert.ToString(sqlDataReader["yonsif"]) == textBox4.Text)
                    {
                        yoneticiarayuz yoneticiarayuz = new yoneticiarayuz();
                        yoneticiarayuz.lb_yonism.Text = textBox1.Text;
                        yoneticiarayuz.lb_yonsoy.Text = textBox2.Text;
                        oyuncakduzenle.girissif = textBox4.Text;
                        uyeguncelleme.girissiffre = textBox4.Text;
                        yoneticiarayuz.Show();
                        this.Close();
                        return;

                    }
                }
                MessageBox.Show("Bİlgilerinizi Kontrol Ediniz!");
                return;
            }

        }
    }
}
