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
using System.Net;

namespace frameworks
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 587;
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(a);
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential("appartmentmanagement200@gmail.com", "karachi94");
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("appartmentmanagement200@gmail.com");
                mailDetails.To.Add("hassanafnan20@gmail.com");
                mailDetails.Subject = "Password Recovery";
                //mailDetails.IsBodyHtml = checkBox2.Checked;
                mailDetails.Body = "karachi123";
               /* if (filename.Length > 0)
                {
                    Attachment attachment = new Attachment(filename);
                    mailDetails.Attachments.Add(attachment);
                }*/
                clientDetails.Send(mailDetails);
                MessageBox.Show("Your mail has been sent.");
               // filename = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
