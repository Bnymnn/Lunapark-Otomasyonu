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
    public partial class uyesifremiunuttum : Form
    {
        string cod;
        public static string to;
        Random ran = new Random();
        SqlConnection uyesifredegis = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public uyesifremiunuttum()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyegiris uyegiris = new uyegiris();
            uyegiris.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cod == (textBox4.Text).ToString())
            { 
                uyesifredegis uyesifredegis = new uyesifredegis();
                uyesifredegis.Show();
                this.Close();

               


            }
            else
                MessageBox.Show("Onay Kodu Hatalı");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cod = ran.Next(99, 1000).ToString();
            if (uyesifredegis.State.ToString() == "Closed")
            {
               uyesifredegis.Open();
            }

            SqlCommand sqlcom = new SqlCommand("select * from uyeler", uyesifredegis);
            SqlDataReader sqlDataRe = sqlcom.ExecuteReader();

            while (sqlDataRe.Read())
            {
                if (Convert.ToString(sqlDataRe["isim"]) == textBox1.Text && Convert.ToString(sqlDataRe["telefon"]) == textBox2.Text && Convert.ToString(sqlDataRe["email"]) == textBox3.Text)
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new System.Net.NetworkCredential("lulu.yetkili@hotmail.com", "otomasyonodevim1");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.EnableSsl = true;
                    message.To.Add(textBox3.Text);
                    message.From = new MailAddress("lulu.yetkili@hotmail.com");
                    message.Subject = "Onay Kodu";
                    message.Body = "Onay kodunuz = " + cod;
                    smtpClient.Send(message);

                    MessageBox.Show("Kod Gönderildi");
                    uyesifredegis.Close();
                    sqlDataRe.Close();


                    return;
                }


            }
            MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
        }
    }
}
