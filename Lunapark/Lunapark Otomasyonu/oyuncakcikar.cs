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
    public partial class oyuncakcikar : Form
    {
        SqlConnection oynckckraa = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public oyuncakcikar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yoneticiarayuz yoneticiarayuz = new yoneticiarayuz();
            yoneticiarayuz.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oynckckraa.State == ConnectionState.Closed)
            {
                oynckckraa.Open();
            }
            SqlCommand sqlcom = new SqlCommand("select * from oyuncak", oynckckraa);
            SqlDataReader okuu = sqlcom.ExecuteReader();
            while (okuu.Read())
            {
                if (Convert.ToString(okuu["ıd"]) == textBox1.Text)
                {
                    okuu.Close();
                    oyuncaksi();
                    textBox1.Text = "";
                    return;

                }
            }

            MessageBox.Show("Bİlgilerinizi Kontrol Ediniz!");
            okuu.Close();
        }
        private void oyuncaksi()
        {
            SqlCommand oyuncaksl = new SqlCommand("DELETE FROM oyuncak WHERE ıd =" + textBox1.Text + " ", oynckckraa);
            oyuncaksl.ExecuteNonQuery();

            MessageBox.Show("Silme İşlemi Başarılı");
        }
        private void hazirlik()
        {
            if (oynckckraa.State == ConnectionState.Closed)
            {
                oynckckraa.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from oyuncak", oynckckraa);
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
                listView1.Items.Add(ekle);



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hazirlik();
            oynckckraa.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }
    }
}