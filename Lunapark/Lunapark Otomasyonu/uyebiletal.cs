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
using System.Net.Mail;
namespace Lunapark_Otomasyonu
{

    public partial class uyebiletal : Form
    {
        SqlConnection oyuncak = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public uyebiletal()
        {
            InitializeComponent();
        }
        public static int yenibakiye;
        public static int bakkiyye;
        public static int gör;
        public int a;
        public int b;
        public int c;
        public int d;
        public int f;
        public int boy;
        public int kil;
        public int yas;
        public static int dur;
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hazirlik();
            oyuncak.Close();
        }
        private void hazirlik()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from oyuncak ", oyuncak);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
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
                    ekle.SubItems.Add(oku["tele"].ToString());
                    ekle.SubItems.Add(oku["durum"].ToString());
                    listView1.Items.Add(ekle);
                    
                }
            }
        }
        public static string telefonnocek;
        public static string isimcek;
        public static int fiyat;
       
        
        public string biletno;
        public static string durum;
        private void button1_Click(object sender, EventArgs e)
        {
       
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            
            oynck();
            
            uyenin();
            bakiye2();
            if (textBox1.Text != "")
            {
                if (dur != 2)
                {


                    if (durum == "Aktif")
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
                                            bakiye();
                                            bırıncı();
                                            dur = 0;
                                            return;
                                        }
                                        else
                                            MessageBox.Show("Üzgünüz, Gerekli Yaş Aralığının Altındasınız.");
                                        return;

                                    }
                                    else
                                        MessageBox.Show("Üzgünüz , Gerekli Kilo Aralığının Üstündesiniz.");
                                    return;

                                }
                                else
                                    MessageBox.Show("Üzgünüz , Gerekli Kilo Aralığının Altındasınız.");
                                return;

                            }
                            else
                                MessageBox.Show("Üzgünüz , Gerekli Boy Aralığının Üstündesiniz.");
                            return;

                        }
                        else
                            MessageBox.Show("Üzgünüz , Gerekli Boy Aralığının Altındasınız.");
                        return;
                    }
                    else
                        MessageBox.Show("Malesef Oyuncak Devre Dışı.");
                    return;
                }
                else
                    MessageBox.Show("Bakiyeniz Yetersiz!");
            }
            else
                MessageBox.Show("Lütfen Oyuncak Numarasını Seçiniz Ve ya Yazınız.");
            return;
        }
        
        private void oynck()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from oyuncak where ıd like '" + textBox1.Text + "'", oyuncak);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {

                    a = Convert.ToInt32(sqlDataReader["oynminboy"]);
                    b = Convert.ToInt32(sqlDataReader["oynmaxboy"]);
                    c = Convert.ToInt32(sqlDataReader["oynminkil"]);
                    d = Convert.ToInt32(sqlDataReader["oynmaxkil"]);
                    f = Convert.ToInt32(sqlDataReader["oynminyas"]);
                    fiyat = Convert.ToInt32(sqlDataReader["tele"]);
                    durum= Convert.ToString(sqlDataReader["durum"]);
                }
               
            }
           
        }
        
        
        private void uyenin()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" + telefonnocek + "'", oyuncak);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    boy = Convert.ToInt32(sqlDataReader["boy"]);
                    kil = Convert.ToInt32(sqlDataReader["kilo"]);
                    yas = Convert.ToInt32(sqlDataReader["yas"]);
                   bakkiyye= Convert.ToInt32(sqlDataReader["bakiye"]);
                }
                
            }

        }
        private void bırıncı()
        {
            
            
                string gun = DateTime.Now.Day.ToString();
                string ay = DateTime.Now.Month.ToString();
                string oyncakıd = textBox1.Text;
                biletno = gun + "-" + ay + "-" + oyncakıd + "-" + telefonnocek;
                    
                  
                    if (oyuncak.State == ConnectionState.Closed)
                    {
                        oyuncak.Open();
                    }
                    string kayit = " insert into bıletler (no , ad , tellf , oyuncak , kullanım) values (@bilno,@isim,@telle,@oyun,@kul) ";
                    SqlCommand islem = new SqlCommand(kayit, oyuncak);
                    islem.Parameters.AddWithValue("@bilno", biletno);
                    islem.Parameters.AddWithValue("@isim", isimcek);
                    islem.Parameters.AddWithValue("@telle", telefonnocek);
            islem.Parameters.AddWithValue("@oyun", textBox1.Text);
            islem.Parameters.AddWithValue("@kul", "Kullanılmadı");
            islem.ExecuteNonQuery();
                    oyuncak.Close();
                    mailBİlet();
                    MessageBox.Show(" Bilet alma işlemi başarılı! \n Biletiniz : " + biletno + " \n Bilet Bilginiz E-Mail Adresinize Gönderilmiştir.");
                    if (lb_uyeism.Text != "Bakiyenizi Görmek İçin Tıklayınız.")
                    {
                     lb_uyeism.Text = "Bakiyeniz =" + yenibakiye;
                    }
        }
        
       
        
        private void bakiye()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            string gunel = " update uyeler set bakiye=@bakkik where telefon=@telfoon";
            SqlCommand sqlCommand = new SqlCommand(gunel,oyuncak);
            
            
                sqlCommand.Parameters.AddWithValue("@telfoon", Convert.ToString(telefonnocek));
                sqlCommand.Parameters.AddWithValue("@bakkik", yenibakiye);
                sqlCommand.ExecuteNonQuery();
                oyuncak.Close(); 
   
        }
        private void bakiye2() {
            if (bakkiyye >= fiyat)
            {
                yenibakiye = bakkiyye - fiyat;
            }
            else
                dur = 2;
        }
        
         private void bakk()
        {if (oyuncak.State == ConnectionState.Closed)
                {
                    oyuncak.Open();
                }

            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" +telefonnocek + "'", oyuncak);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {

                
                while (sqlDataReader.Read())
                {
                    bakkiyye = Convert.ToInt32(sqlDataReader["bakiye"]);
                    sqlDataReader.Close();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mailBİlet()
        {
            string tarih = DateTime.Now.ToLongDateString();
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" + telefonnocek + "'", oyuncak);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {


                while (sqlDataReader.Read())
                {

                    string mail = Convert.ToString(sqlDataReader["email"]);

                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new System.Net.NetworkCredential("lulu.bilet@hotmail.com", "otomasyonodevim1");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.EnableSsl = true;
                    message.To.Add(mail);
                    message.From = new MailAddress("lulu.bilet@hotmail.com");
                    message.Subject =tarih+ " Tarihli LuLu Lunapark Biletiniz";
                    message.Body = "LuLu Lunapark Bİlet Numaranız = " + biletno + "\n İyi Eğlenceler Dileriz" ;
                    smtpClient.Send(message);

                    
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

        private void lb_uyeism_Click(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" + telefonnocek + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lb_uyeism.Text = "Bakiyeniz ="+Convert.ToString(sqlDataReader["bakiye"]);
                sqlDataReader.Close();
                
                return;
            }
            sqlDataReader.Close();
        }
    }
    }

