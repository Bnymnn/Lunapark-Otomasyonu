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
    public partial class uyeguncelleme : Form
    {
        SqlConnection oyuncak = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyeguncelleme()
        {
            InitializeComponent();
        }

        private void uyeguncelleme_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from uyeler", oyuncak);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["telefon"].ToString();
                    ekle.SubItems.Add(oku["isim"].ToString());
                    listView1.Items.Add(ekle);
                    
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" + textBox1.Text + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader["isim"].ToString();
                textBox3.Text = sqlDataReader["soyisim"].ToString();
                textBox4.Text = sqlDataReader["boy"].ToString();
                textBox5.Text = sqlDataReader["kilo"].ToString();
                textBox6.Text = sqlDataReader["yas"].ToString();
                textBox7.Text = sqlDataReader["email"].ToString();
                textBox9.Text = sqlDataReader["bakiye"].ToString();
                textBox10.Text = sqlDataReader["sifre"].ToString();

                sqlDataReader.Close();
                return;
            }
            sqlDataReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string girissiffre;

        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from yonetim , personel ", oyuncak);
            using (SqlDataReader sql = sqlCommand.ExecuteReader())
            {
                while (sql.Read())
                {
                    if (Convert.ToString(sql["yonsif"]) == textBox8.Text)
                    {sql.Close();
                        duzenle();
                        return;
                    }
                    else if (Convert.ToString(sql["perssif"]) == textBox8.Text)
                    {sql.Close();
                        duzenle();
                        return;
                    }
                    else if (textBox8.Text == girissiffre)
                    { sql.Close();
                        duzenle();
                        return;
                    }
                    else
                        sql.Close();
                        MessageBox.Show("Şifreniz Hatalı!");
                    return;
                }
            }
        }
        private void duzenle()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            /* try
             {
                  string gucelleme = " update uyeler set isim=@Name , soyisim=@Lastname , boy=@Cm , kilo=@gram , yas=@kuru , email=@Sms , bakiye=@Yok , sifre=@Pass where telefon=@ıphone ";
                  SqlCommand commander = new SqlCommand(" update uyeler set isim=@Name , soyisim=@Lastname , boy=@Cm , kilo=@gram , yas=@kuru , email=@Sms , bakiye=@Yok , sifre=@Pass where telefon=@ıphone ", oyuncak);
                  commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
                  commander.Parameters.AddWithValue("@Name", textBox2.Text);
                  commander.Parameters.AddWithValue("@Lastname", textBox3.Text);
                  commander.Parameters.AddWithValue("@Cm", textBox4.Text);
                  commander.Parameters.AddWithValue("@gram", textBox5.Text);
                  commander.Parameters.AddWithValue("@kuru", textBox6.Text);
                  commander.Parameters.AddWithValue("@Sms", textBox7.Text);
                  commander.Parameters.AddWithValue("@Yok", textBox9.Text);
                  commander.Parameters.AddWithValue("@Pass", textBox10.Text);
                 string a = "update uyeler set isim='" + textBox2.Text + "',soyisim='" + textBox2.Text + "'where telefon=" + Convert.ToString(textBox1.Text) + ";";
                 SqlCommand cum = new SqlCommand(a, oyuncak);
                 cum.ExecuteNonQuery();
                 oyuncak.Close();}*/
            boy();
            kilo();
            yas();
            email();
            bakiye();
            sfire();
            string ıd = textBox1.Text;
                
                MessageBox.Show("Güncelleme Başarılı");
               
                textBox1.Text = " ";
            textBox1.Text = ıd;
            textBox8.Text = "";
            
                


               
               
            
            /*catch
            {
                MessageBox.Show("Hata!");
            }*/
        }
        private void boy()
        {

            using (SqlCommand commander = new SqlCommand(" update uyeler set boy = @usun where telefon=@ıphone ", oyuncak)) { 
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@usun", textBox4.Text);
            commander.ExecuteNonQuery();
                return;
        }
        }
        private void kilo()
        {

            SqlCommand commander = new SqlCommand(" update uyeler set kilo=@gram where telefon=@ıphone ", oyuncak);
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@gram", textBox5.Text);
            commander.ExecuteNonQuery();
            return;
        }
        private void yas()
        {

            SqlCommand commander = new SqlCommand(" update uyeler set yas=@kuru where telefon=@ıphone ", oyuncak);
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@kuru", textBox6.Text);
            commander.ExecuteNonQuery();
            return;
        }
        private void email()
        {

            SqlCommand commander = new SqlCommand(" update uyeler set email=@Sms where telefon=@ıphone ", oyuncak);
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@Sms", textBox7.Text);
            commander.ExecuteNonQuery();
            return;
        }
        private void bakiye()
        {

            SqlCommand commander = new SqlCommand(" update uyeler set bakiye=@Yok where telefon=@ıphone ", oyuncak);
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@Yok", textBox9.Text);
            commander.ExecuteNonQuery();
            return;
        }
        private void sfire()
        {

            SqlCommand commander = new SqlCommand(" update uyeler set sifre=@Pass where telefon=@ıphone ", oyuncak);
            commander.Parameters.AddWithValue("@ıphone", Convert.ToString(textBox1.Text));
            commander.Parameters.AddWithValue("@Pass", textBox10.Text);
            commander.ExecuteNonQuery();
            return;
        }
    }
}
