using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Media;

namespace GelirGiderOtomasyonu
{
    public partial class yardim : Form
    {
        public yardim()
        {
            InitializeComponent();
        }
        public string mail;

        private void yardim_load(object sender, EventArgs e)
        {
            mailTxt.Text= mail; 
           
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {
            MailMessage msg= new MailMessage();
            SmtpClient gönder = new SmtpClient();
            gönder.Credentials = new System.Net.NetworkCredential("mail","sifre");
            gönder.Port = 587;
            gönder.Host= "smpt.gmail.com";
            gönder.EnableSsl= true;
            msg.To.Add(konuTxt.Text);
            msg.From = new MailAddress("mail");
            msg.Subject = konuTxt.Text;
            msg.Body = aciklamaTxt.Text;
            gönder.Send(msg);
        }
    }
}
