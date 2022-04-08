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
    public partial class biletgoruntule : Form
    {
        SqlConnection bıletler = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public biletgoruntule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }
            SqlCommand sqlcomm = new SqlCommand("select * from bıletler", bıletler);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
                while (oku.Read())
                {

                    if (textBox1.Text == "")
                    {
                        oku.Close();
                        hazirlik();
                        return;
                    }
                    /*else if (Convert.ToString(oku["oyuncak"])==textBox1.Text  )
                    {
                        oku.Close();
                        hazirlik3();
                        return;

                    }*/
                    else

                        oku.Close();
                    hazirlik2();
                    return;



                }
            }
        }
        private void hazirlik()
        {
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from bıletler", bıletler);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["no"].ToString();
                    ekle.SubItems.Add(oku["ad"].ToString());
                    ekle.SubItems.Add(oku["kullanım"].ToString());
                    ekle.SubItems.Add(oku["ıd"].ToString());
                    listView1.Items.Add(ekle);

                }
            }

        }
        private void hazirlik2()
        {
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from bıletler where tellf like '" + textBox1.Text + "'", bıletler);
            using (SqlDataReader oku = sqlcomm.ExecuteReader())
            {
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["no"].ToString();
                    ekle.SubItems.Add(oku["ad"].ToString());
                    ekle.SubItems.Add(oku["kullanım"].ToString());
                    ekle.SubItems.Add(oku["ıd"].ToString());
                    listView1.Items.Add(ekle);
                }
            }


        }
        private void hazirlik3()
        {
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from bıletler where oyuncak like '" + textBox1.Text + "'", bıletler);
            SqlDataReader oku = sqlcomm.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["kullanım"].ToString());
                ekle.SubItems.Add(oku["ıd"].ToString());
                listView1.Items.Add(ekle);
                oku.Close();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }
            if (checkBox2.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Lütfen Sadece Kullanılabilir ve ya Geçersiz Durumlarından Sadece Birini  Seçiniz");
                return;
            }
            else if (checkBox2.Checked != true && checkBox1.Checked != true)
            {
                MessageBox.Show("Lütfen Sadece Kullanılabilir ve ya Geçersiz Durumlarından  Birini  Seçiniz");
                return;
            }
            else {
                if (textBox2.Text != "Id")
                {


                    try
                    {
                        string gucelleme = " update bıletler set kullanım = @durmm where ıd=@ıde";
                        SqlCommand command = new SqlCommand(gucelleme, bıletler);
                        command.Parameters.AddWithValue("@ıde", Convert.ToString(textBox2.Text));
                        if (checkBox1.Checked == true && checkBox2.Checked != true)
                        {
                            command.Parameters.AddWithValue("@durmm", "Kullanılabilir ");
                            command.ExecuteNonQuery();
                        }
                        else if (checkBox2.Checked == true && checkBox1.Checked != true)
                        {
                            command.Parameters.AddWithValue("@durmm", "Geçersiz");
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Güncelleme Başarılı");





                    }
                    catch
                    {
                        MessageBox.Show("Hata!");
                    }
                }
                else
                    MessageBox.Show("Id Seçilmedi");
            }

        }

        
    }
}

