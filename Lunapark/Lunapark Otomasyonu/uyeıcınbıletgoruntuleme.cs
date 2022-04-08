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
    public partial class uyeıcınbıletgoruntuleme : Form
    {
        SqlConnection bıletler = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyeıcınbıletgoruntuleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hazirlik2();
        }
        public static string telcek;
        private void hazirlik2()
        {
            if (bıletler.State == ConnectionState.Closed)
            {
                bıletler.Open();
            }

            SqlCommand sqlcomm = new SqlCommand("select * from bıletler where tellf like '" + telcek + "'", bıletler);
            SqlDataReader oku = sqlcomm.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
