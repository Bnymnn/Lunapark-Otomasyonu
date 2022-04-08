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
    public partial class oyuncakduzenle : Form
    {
        SqlConnection oyuncak = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public oyuncakduzenle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string girissif;
        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from yonetim , personel ", oyuncak);
            using ( SqlDataReader sql = sqlCommand.ExecuteReader())
            {
                while (sql.Read())
                {
                    if (Convert.ToString(sql["yonsif"]) == textBox8.Text /* || textBox8.Text ==  girissif*/)
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked != true)
                        {sql.Close();
                        duzenle();
                        return;
                            
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked != true)
                        {
                            sql.Close();
                            duzenle();
                            return;
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked == true)
                        {
                            MessageBox.Show("Lütfen Sadece Aktif ve ya Devredışı Durumlarından Sadece Birini  Seçiniz");
                            return;
                        }
                        else { MessageBox.Show ("Lütfen Aktif ve ya Devre Dışı Olup Olmadığını İşaretleyiniz");return; }
                        
                        
                    }
                    else  if(Convert.ToString(sql["perssif"]) == textBox8.Text )
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked != true)
                        {
                            sql.Close();
                            duzenle();
                            return;
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked != true)
                        {
                            sql.Close();
                            duzenle();
                            return;
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked == true)
                        {
                            MessageBox.Show("Lütfen Sadece Aktif ve ya Devredışı Durumlarından Sadece Birini  Seçiniz");
                                return;
                        }
                        else { MessageBox.Show("Lütfen Aktif ve ya Devre Dışı Olup Olmadığını İşaretleyiniz"); return; }

                    }
                    else if(textBox8.Text== girissif) {
                        if (checkBox1.Checked == true && checkBox2.Checked != true)
                        {
                            sql.Close();
                            duzenle();
                            return;
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked != true)
                        {
                            sql.Close();
                            duzenle();
                            return;
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked == true)
                        {
                            MessageBox.Show("Lütfen Sadece Aktif ve ya Devredışı Durumlarından Sadece Birini  Seçiniz");
                            return;
                        }
                        else { MessageBox.Show("Lütfen Aktif ve ya Devre Dışı Olup Olmadığını  İşaretleyiniz"); return; }

                    }
                       else {
                        MessageBox.Show("Şifreniz Hatalı!");
                        return;
                    }
                    
                }
            }

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from oyuncak where ıd like '" + textBox1.Text + "'", oyuncak);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader["oynis"].ToString();
                textBox3.Text= sqlDataReader["oynminboy"].ToString();
                textBox4.Text = sqlDataReader["oynmaxboy"].ToString();
                textBox5.Text = sqlDataReader["oynminkil"].ToString();
                textBox6.Text = sqlDataReader["oynmaxkil"].ToString();
                textBox7.Text = sqlDataReader["oynminyas"].ToString();
                textBox9.Text = sqlDataReader["tele"].ToString();

                sqlDataReader.Close();
                return;
            }
            sqlDataReader.Close();

        }
        private void duzenle()
        {
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }
            try
            {
                string gucelleme = " update oyuncak set oynis=@isimm  , oynminboy = @oynminboy , oynmaxboy = @oynmaxboy, oynminkil = @oynminkil , oynmaxkil = @oynmaxkil , oynminyas = @oynminyas, tele=@tl , durum=@durm where ıd=@aydii";
                SqlCommand command = new SqlCommand(gucelleme, oyuncak);
                command.Parameters.AddWithValue("@aydii", Convert.ToString(textBox1.Text));
                command.Parameters.AddWithValue("@isimm", textBox2.Text);
                command.Parameters.AddWithValue("@oynminboy", textBox3.Text);
                command.Parameters.AddWithValue("@oynmaxboy", textBox4.Text);
                command.Parameters.AddWithValue("@oynminkil", textBox5.Text);
                command.Parameters.AddWithValue("@oynmaxkil", textBox6.Text);
                command.Parameters.AddWithValue("@oynminyas", textBox7.Text);
                command.Parameters.AddWithValue("@tl", textBox9.Text);
                if (checkBox1.Checked == true && checkBox2.Checked != true)
                {command.Parameters.AddWithValue("@durm", "Aktif");
                }
                else if (checkBox2.Checked == true && checkBox1.Checked != true)
                {
                    command.Parameters.AddWithValue("@durm", "Devredışı");
                        }
                MessageBox.Show("Güncelleme Başarılı");
                command.ExecuteNonQuery();
                string ıd = textBox1.Text;
                textBox1.Text = "";
                textBox1.Text = ıd;
                textBox8.Text = "";
                
                
                
                oyuncak.Close();
               
            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (oyuncak.State == ConnectionState.Closed)
            {
                oyuncak.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from oyuncak", oyuncak);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["ıd"].ToString();
                    ekle.SubItems.Add(oku["oynis"].ToString());
                    listView1.Items.Add(ekle);

                }
            }
        }
    }
    }

