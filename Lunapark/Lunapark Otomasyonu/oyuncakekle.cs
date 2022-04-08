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
    public partial class oyuncakekle : Form
    {
        SqlConnection oynckeklee = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public oyuncakekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                ekle();
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Bİlgi!");
        }
        private void ekle()
        { try
            {
                if (oynckeklee.State == ConnectionState.Closed)
                {
                    oynckeklee.Open();
                }
                string kayit = " insert into oyuncak (oynis,oynminboy,oynmaxboy,oynminkil,oynmaxkil,oynminyas,tele) values (@oyks,@oymb,@oyxb,@oymk,@oyxk,@oymy,@tel) ";
                SqlCommand imslemm = new SqlCommand(kayit, oynckeklee);
                imslemm.Parameters.AddWithValue("@oyks", textBox1.Text);
                imslemm.Parameters.AddWithValue("@oymb ", textBox2.Text);
                imslemm.Parameters.AddWithValue("@oyxb", textBox3.Text);
                imslemm.Parameters.AddWithValue("@oymk", textBox4.Text);
                imslemm.Parameters.AddWithValue("@oyxk", textBox5.Text);
                imslemm.Parameters.AddWithValue("@oymy", textBox6.Text);
                imslemm.Parameters.AddWithValue("@tel", textBox7.Text);
                imslemm.ExecuteNonQuery();
                oynckeklee.Close();
                MessageBox.Show("Kayıt Başarılı");
                return;
            }
            catch {
               MessageBox.Show("Bilgileri Kontol Ediniz.");
            }
        }
    }
}
