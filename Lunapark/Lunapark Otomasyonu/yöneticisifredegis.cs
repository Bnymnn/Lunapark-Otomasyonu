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
    public partial class yöneticisifredegis : Form
    {
        SqlConnection yonyen = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yöneticisifredegis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string güncel = " update yonetim set yonsif=@sssiif where yontel=@tteellf  ";
            SqlCommand sqlCommand = new SqlCommand(güncel, yonyen);
            sqlCommand.Parameters.AddWithValue("@tteellf", Convert.ToString(textBox1.Text));

            sqlCommand.Parameters.AddWithValue("@sssiif", textBox3.Text);
            yonyen.Open();
            sqlCommand.ExecuteNonQuery();
            yonyen.Close();
            MessageBox.Show("Şifreniz değiştirildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yetkiligiris yetkiligiris = new yetkiligiris();
            yetkiligiris.Show();
            this.Close();
        }
    }
}
