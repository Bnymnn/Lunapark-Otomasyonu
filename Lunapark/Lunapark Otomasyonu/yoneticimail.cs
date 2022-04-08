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
    public partial class yoneticimail : Form
    {
        SqlConnection yonmail = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public yoneticimail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Close();
        }
        public static string tel;
        private void button2_Click(object sender, EventArgs e)
        {
            if (yonmail.State.ToString() == "Closed")
            {
                yonmail.Open();
            }

            SqlCommand sqlcom = new SqlCommand("select * from personel where perstel like '" + tel + "'", yonmail);
            using (SqlDataReader sqlDataRe = sqlcom.ExecuteReader())
            {
                while (sqlDataRe.Read())
                {
                    if ( Convert.ToString(sqlDataRe["perssif"]) == textBox4.Text)
                    {
                        MailMessage message = new MailMessage();
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Credentials = new System.Net.NetworkCredential("lulu.personel@hotmail.com", "otomasyonodevim1");
                        smtpClient.Port = 587;
                        smtpClient.Host = "smtp.live.com";
                        smtpClient.EnableSsl = true;
                        message.To.Add("lulu.yetkili@hotmail.com");
                        message.From = new MailAddress("lulu.personel@hotmail.com");
                        message.Subject = textBox2.Text;
                        message.Body = textBox3.Text + "\n"+"\n" + sqlDataRe["persism"] + " \n" + sqlDataRe["persoy"] + " \n " + sqlDataRe["perstel"] + "\n" + sqlDataRe["persmail"];
                        smtpClient.Send(message);

                        MessageBox.Show("Mailiniz Başarıyla Gönderildi");
                        yonmail.Close();
                        sqlDataRe.Close();


                        return;
                    }


                }
            }
            MessageBox.Show("Personel Telefon Numaranız Ve ya Şifrenizi Kontol Ediniz");
        }
    }
}
