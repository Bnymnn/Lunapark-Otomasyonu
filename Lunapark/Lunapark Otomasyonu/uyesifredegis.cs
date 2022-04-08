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
    public partial class uyesifredegis : Form
    {
        SqlConnection uyesifreyenile = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyesifredegis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uyesifreyenile.State == ConnectionState.Closed)
            {
                uyesifreyenile.Open();

            }

            string güncel = " update uyeler set sifre=@ssif where telefon=@tellf  ";
            SqlCommand sqlCommand = new SqlCommand(güncel, uyesifreyenile);
            sqlCommand.Parameters.AddWithValue("@tellf", Convert.ToString(textBox1.Text));
           
            sqlCommand.Parameters.AddWithValue("@ssif", textBox3.Text);
           
            sqlCommand.ExecuteNonQuery();
            uyesifreyenile.Close();
            MessageBox.Show("Şifreniz değiştirildi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyegiris uyegiris = new uyegiris(); ;
            uyegiris.Show();
            this.Close();
        }
    }
}
