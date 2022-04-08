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
    public partial class sifremiunuttum : Form
    {
        string code;
        public static string to;
        Random rane = new Random();
        SqlConnection perssifredegis = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yetkiligiris yetkiligiris = new yetkiligiris();
            yetkiligiris.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (code == (textBox4.Text).ToString() && degisken == "1")
            {
                yetkilisifredegis yetkilisifredegis = new yetkilisifredegis();
                yetkilisifredegis.Show();     
                this.Close();
            }
            else if (code == (textBox4.Text).ToString() && degisken == "2")
            {
                yöneticisifredegis yöneticisifredegis = new yöneticisifredegis();
                yöneticisifredegis.Show();
                this.Close();

            }
            else
                MessageBox.Show("Onay Kodu Hatalı");
        }
        public string degisken;
        private void button1_Click(object sender, EventArgs e)
        {
            code = rane.Next(99, 1000).ToString();
            if (perssifredegis.State.ToString() == "Closed")
            {
                perssifredegis.Open();
            }

            SqlCommand sqlcom = new SqlCommand("select * from personel,yonetim", perssifredegis);
            SqlDataReader sqlDataRe = sqlcom.ExecuteReader();

            while (sqlDataRe.Read())
            {
                if (Convert.ToString(sqlDataRe["persism"]) == textBox1.Text && Convert.ToString(sqlDataRe["persoy"]) == textBox2.Text && Convert.ToString(sqlDataRe["persmail"]) == textBox3.Text && Convert.ToString(sqlDataRe["perstel"]) == textBox5.Text)
                {
                    degisken = "1";
                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new System.Net.NetworkCredential("lulu.yetkili@hotmail.com", "otomasyonodevim1");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.EnableSsl = true;
                    message.To.Add(textBox3.Text);
                    message.From = new MailAddress("lulu.yetkili@hotmail.com");
                    message.Subject = "Onay Kodu";
                    message.Body = "Onay kodunuz = " + code;
                    smtpClient.Send(message);

                    MessageBox.Show("Kod Gönderildi");
                    perssifredegis.Close();
                    sqlDataRe.Close();


                    return;
                }
                else if (Convert.ToString(sqlDataRe["yonism"]) == textBox1.Text && Convert.ToString(sqlDataRe["yonsoy"]) == textBox2.Text && Convert.ToString(sqlDataRe["yonmail"]) == textBox3.Text && Convert.ToString(sqlDataRe["yontel"]) == textBox5.Text)
                {
                    degisken = "2";
                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new System.Net.NetworkCredential("lulu.yetkili@hotmail.com", "otomasyonodevim1");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.EnableSsl = true;
                    message.To.Add(textBox3.Text);
                    message.From = new MailAddress("lulu.yetkili@hotmail.com");
                    message.Subject = "Onay Kodu";
                    message.Body = "Onay kodunuz = " + code;
                    smtpClient.Send(message);

                    MessageBox.Show("Kod Gönderildi");
                    perssifredegis.Close();
                    sqlDataRe.Close();


                    return;
                }

            }
            MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
        }
    }
}
