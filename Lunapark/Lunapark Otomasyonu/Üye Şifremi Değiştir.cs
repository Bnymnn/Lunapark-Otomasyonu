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
    public partial class Üye_Şifremi_Değiştir : Form
    {
        SqlConnection oyuncak = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Üye_Şifremi_Değiştir()
        {
            InitializeComponent();
        }
        public static string telefonnocek2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                if (oyuncak.State == ConnectionState.Closed)
                {
                    oyuncak.Open();
                }
                string gunel = " update uyeler set sifre=@uyesifre where telefon=@telefonnum";
                SqlCommand sqlCommand = new SqlCommand(gunel, oyuncak);
                
                sqlCommand.Parameters.AddWithValue("@telefonnum", Convert.ToString(telefonnocek2));
                sqlCommand.Parameters.AddWithValue("@uyesifre", textBox1.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Başarıyla Değiştirildi!");
                oyuncak.Close();
            }
            else
                MessageBox.Show("Şifreler Uyuşmuyor!");
            
          }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

