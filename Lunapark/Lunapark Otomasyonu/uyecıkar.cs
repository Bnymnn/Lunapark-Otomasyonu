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
    public partial class uyecıkar : Form
    {
        SqlConnection uyeckraa = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyecıkar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uyeckraa.State == ConnectionState.Closed)
            {
                uyeckraa.Open();
            }
            SqlCommand sqlcom = new SqlCommand("select * from uyeler", uyeckraa);
            SqlDataReader okuu = sqlcom.ExecuteReader();
            while (okuu.Read()) {
                if (Convert.ToString(okuu["telefon"]) == textBox1.Text)
                {
                    okuu.Close();
                    uyesi();
                    return;

                }
            }
            
             MessageBox.Show("Bİlgilerinizi Kontrol Ediniz!");
            okuu.Close();
            
        }
        private void uyesi()
        {
            SqlCommand uyesil = new SqlCommand("DELETE FROM uyeler WHERE telefon=" + textBox1.Text + " ", uyeckraa);
            uyesil.ExecuteNonQuery();
            
            MessageBox.Show("Silme İşlemi Başarılı");
            
        }
        private void hazirlik()
        {
            if (uyeckraa.State == ConnectionState.Closed)
            {
                uyeckraa.Open();
            }
            
            SqlCommand sqlcomm = new SqlCommand("select * from uyeler", uyeckraa);
            SqlDataReader oku = sqlcomm.ExecuteReader();

            oku.Read();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isim"].ToString();
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["boy"].ToString());
                ekle.SubItems.Add(oku["kilo"].ToString());
                ekle.SubItems.Add(oku["yas"].ToString());
                listView1.Items.Add(ekle);
                


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hazirlik();
            uyeckraa.Close();
            

        }
    }
}
