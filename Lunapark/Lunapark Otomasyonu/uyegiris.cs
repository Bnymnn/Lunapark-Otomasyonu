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
    public partial class uyegiris : Form
    {
        SqlConnection uyeler = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public uyegiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uyeler.State == ConnectionState.Closed)
            {
                uyeler.Open();
            }
            SqlCommand sqlcom = new SqlCommand("select * from uyeler", uyeler);
            using (SqlDataReader sqlDataReader = sqlcom.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader["isim"]) == textBox1.Text && Convert.ToString(sqlDataReader["telefon"]) == textBox2.Text && Convert.ToString(sqlDataReader["sifre"]) == textBox3.Text)
                    {
                        uyebiletal.isimcek = textBox1.Text;
                        uyebiletal.telefonnocek = textBox2.Text;
                        Üye_Şifremi_Değiştir.telefonnocek2 = textBox2.Text;
                        uyearayuz uyearayuz = new uyearayuz();
                        uyearayuz.lb_uyeism.Text = textBox1.Text;
                        uyeıcınbıletgoruntuleme.telcek = textBox2.Text;
                        uyearayuz.lb_uyesoy.Text =  Convert.ToString(sqlDataReader["soyisim"]);
                        sqlDataReader.Close();
                        bakiyealcamabi();
                        uyeler.Close();
                        uyearayuz.Show();
                        this.Close();
                        return;

                    }

                }
            }
            MessageBox.Show("Bİlgiler hatalı");
        }
        private void bakiyealcamabi()
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uyesifremiunuttum uyesifremiunuttum = new uyesifremiunuttum();
            uyesifremiunuttum.Show();
            this.Close();
        }
    }
}
