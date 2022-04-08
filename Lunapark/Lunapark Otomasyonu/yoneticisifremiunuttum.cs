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
    public partial class yoneticisifremiunuttum : Form
    {
        string codem;
        public static string to;
        Random ranem = new Random();
        SqlConnection yonsifredegis = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yoneticisifremiunuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codem = ranem.Next(99, 1000).ToString();
            if (yonsifredegis.State.ToString() == "Closed")
            {
                yonsifredegis.Open();
            }

            SqlCommand sqlcom = new SqlCommand("select * from personel", yonsifredegis);
            SqlDataReader sqlDataRe = sqlcom.ExecuteReader();

            while (sqlDataRe.Read())
            {
                if (Convert.ToString(sqlDataRe["yonism"]) == textBox1.Text && Convert.ToString(sqlDataRe["yonsoy"]) == textBox2.Text && Convert.ToString(sqlDataRe["yonmail"]) == textBox3.Text && Convert.ToString(sqlDataRe["yontel"]) == textBox5.Text)
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
                    message.Body = "Onay kodunuz = " + codem;
                    smtpClient.Send(message);

                    MessageBox.Show("Kod Gönderildi");
                    yonsifredegis.Close();
                    sqlDataRe.Close();


                    return;
                }


            }
            MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codem == (textBox4.Text).ToString())
            {
                yöneticisifredegis yöneticisifredegis = new yöneticisifredegis();
                yöneticisifredegis.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticigris yoneticigris = new yoneticigris();
            yoneticigris.Show();
            this.Close();
        }
    }
}
