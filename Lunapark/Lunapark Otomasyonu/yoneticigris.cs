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
    public partial class yoneticigris : Form
    {
        SqlConnection yonetici  = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yoneticigris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            yetkiligiris yetkiligiris = new yetkiligiris();
            yetkiligiris.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yonetici.State == ConnectionState.Closed)
            {
                yonetici.Open();
            }
            SqlCommand sqlcom = new SqlCommand("select * from yonetim", yonetici);
            using (SqlDataReader sqlDataReader = sqlcom.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader["yonism"]) == textBox1.Text && Convert.ToString(sqlDataReader["yonsoy"]) == textBox2.Text && Convert.ToString(sqlDataReader["yontel"]) == textBox3.Text && Convert.ToString(sqlDataReader["yonsif"]) == textBox4.Text)
                    {
                        yoneticiarayuz yoneticiarayuz = new yoneticiarayuz();
                        yoneticiarayuz.lb_yonism.Text = textBox1.Text;
                        yoneticiarayuz.lb_yonsoy.Text = textBox2.Text;
                        oyuncakduzenle.girissif = textBox4.Text;
                        yoneticiarayuz.Show();
                        this.Close();
                        return;
                    }

                }
            }
            MessageBox.Show("Bİlgilerinizi Kontrol Ediniz!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yoneticisifremiunuttum yoneticisifremiunuttum = new yoneticisifremiunuttum();
            yoneticisifremiunuttum.Show();
            this.Close();
        }
    }
}
