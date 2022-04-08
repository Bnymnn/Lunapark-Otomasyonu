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
    public partial class uyebakiyeduzenle : Form
    {
        SqlConnection bakıye = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyebakiyeduzenle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bakıye.State == ConnectionState.Closed)
            {
                bakıye.Open();
            }

            string güncel = " update uyeler set bakiye=@bakıy where telefon=@tellf  ";
            SqlCommand sqlCommand = new SqlCommand(güncel, bakıye);
            sqlCommand.Parameters.AddWithValue("@tellf", Convert.ToString(textBox1.Text));

            sqlCommand.Parameters.AddWithValue("@bakıy", textBox3.Text);
            
            sqlCommand.ExecuteNonQuery();
            bakıye.Close();
            MessageBox.Show("Bakıyeniz Güncellendi");
            string a = textBox1.Text;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox1.Text = a;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (bakıye.State == ConnectionState.Closed)
            {
                bakıye.Open();
            }
            if (textBox1.Text == "")
            {
                _ = textBox2.Text == "";
            }
            SqlCommand sqlCommand = new SqlCommand("select * from uyeler where telefon like '" + textBox1.Text + "'", bakıye);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader["bakiye"].ToString();
                sqlDataReader.Close();
                return;
            }
           sqlDataReader.Close();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
