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
    public partial class onerisikayet : Form
    {
        SqlConnection oneriuye = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lunapark_Otomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public onerisikayet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oneriuye.State.ToString() == "Closed")
            {
                oneriuye.Open();
            }

            
            
            
             
                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new System.Net.NetworkCredential("lulu.oneri.sikayet@hotmail.com", "otomasyonodevim1");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.EnableSsl = true;
                    message.To.Add("lulu.yetkili@hotmail.com");
                    message.From = new MailAddress("lulu.oneri.sikayet@hotmail.com");
                    message.Subject = textBox1.Text;
                    message.Body = textBox2.Text;
                    smtpClient.Send(message);

                    MessageBox.Show("Mesajınız Gönderildi");
                   


                    
               


            
           
        }
    }
}
