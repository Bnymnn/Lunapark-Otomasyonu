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
    
    public partial class yetkilisifredegis : Form
    {
        SqlConnection persyen = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yetkilisifredegis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (persyen.State == ConnectionState.Closed)
            {
                persyen.Open();
            }

            string güncel = " update personel set perssif=@sssiff where perstel=@ttellff  ";
            SqlCommand sqlCommand = new SqlCommand(güncel, persyen);
            sqlCommand.Parameters.AddWithValue("@ttellff", Convert.ToString(textBox1.Text));

            sqlCommand.Parameters.AddWithValue("@sssiff", textBox3.Text);
            
            sqlCommand.ExecuteNonQuery();
            persyen.Close();
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
