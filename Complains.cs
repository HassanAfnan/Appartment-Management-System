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
    public partial class Complains : MetroFramework.Forms.MetroForm
    {
        OpenFileDialog ofAttachment;
        string filename = "";
        public Complains()
        {
            InitializeComponent();
        }

        private void Complains_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ofAttachment = new OpenFileDialog();
                ofAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|pdf Files|*.pdf";
                if (ofAttachment.ShowDialog() == DialogResult.OK)
                {
                    filename = ofAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(comboBox3.Text.Trim());
                clientDetails.Host = comboBox2.Text.Trim();
                clientDetails.EnableSsl = checkBox1.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(comboBox1.Text.Trim(), textBox1.Text.Trim());
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(comboBox1.Text.Trim());
                mailDetails.To.Add(textBox4.Text.Trim());
                mailDetails.Subject = textBox5.Text.Trim();
                mailDetails.IsBodyHtml = checkBox2.Checked;
                mailDetails.Body = richTextBox1.Text.Trim();
                if (filename.Length > 0)
                {
                    Attachment attachment = new Attachment(filename);
                    mailDetails.Attachments.Add(attachment);
                }
                clientDetails.Send(mailDetails);
                MessageBox.Show("Your mail has been sent.");
                filename = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
