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
using System.IO;
using System.Threading;

namespace ToolSendMail
{
    public partial class SendMail : Form
    {
        Attachment attachs = null;
        Boolean isSent = false;
        public SendMail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void attachbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attachtxb.Text = dialog.FileName;
                attachtxb.ReadOnly = true;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (cbToMail.Checked)
            {
                sendMailWithMail();
            }
            else
            {
                if (cbToListMail.Checked)
                {
                    sendMailWithFileList();
                }
            }
            
        }

        void sendMailWithMail()
        {
            GuiMail(usernametxb.Text, totxb.Text, subjecttxb.Text, messagetxb.Text, attachs);
        }

        void sendMailWithFileList()
        {
            Thread th = new Thread(() =>
            {
                attachs = null;
                try
                {
                    FileInfo file = new FileInfo(attachtxb.Text);
                    attachs = new Attachment(attachtxb.Text);

                }
                catch { }

                StreamReader streamReader = new StreamReader(totxb.Text);
                string emails;
                while ((emails = streamReader.ReadLine()) != null)
                {
                    GuiMail(usernametxb.Text, emails, subjecttxb.Text, messagetxb.Text, attachs);
                }
                streamReader.Close();
            });
            th.Start();
        }

        void GuiMail(string from,string to, string subject,string message, Attachment fileAttach=null)
        {
            using (MailMessage msg = new MailMessage())
            {
                if (attachs != null)
                {
                    msg.Attachments.Add(attachs);
                    totxb.ReadOnly = true;
                }
                msg.From = new MailAddress(from);
                msg.To.Add(to);
                msg.Subject = subject;
                msg.Body = message;
                /*mail.IsBodyHtml = true;*/

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(usernametxb.Text, passwordtxb.Text);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.SendCompleted += Smtp_SendCompleted;
                    smtp.SendMailAsync(msg);
                }
            }   
        }

        private void Smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Gửi mail thất bại,  \n" + e.Error.Message, "Cảnh báo");
                return;
            }
            else if (e.Error == null)
            {
                MessageBox.Show("Gửi mail thành công!", "Thông báo");
                isSent = true;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void attachListMailbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                totxb.Text = dialog.FileName;
                totxb.ReadOnly = true;
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                passwordtxb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxb.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            attachtxb.Text = "";
            totxb.Text = "";
            subjecttxb.Text = "";
            usernametxb.Text = "";
            passwordtxb.Text = "";
            messagetxb.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isSent == true)
            {
                attachtxb.ReadOnly = false;
                totxb.ReadOnly = false;
                btnClear.Enabled = true;
            }
        }

        private void cbToMail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbToMail.Checked)
            {
                pnToMail.Enabled = true;
                attachListMailbtn.Enabled = false;
                cbToListMail.Enabled = false;
            }
            else
            {
                attachListMailbtn.Enabled = true;
                cbToListMail.Enabled = true;
            }
        }

        private void cbToListMail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbToListMail.Checked)
            {
                cbToMail.Enabled = false;
                pnToMail.Enabled = true;
            }
            else
            {
                cbToMail.Enabled = true;
            }
        }

        private void cbAttachedFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAttachedFile.Checked)
            {
                pnAttachFIle.Enabled = true;
            }
            else
            {
                pnAttachFIle.Enabled = false;
            }
        }

        private void cbAttachedMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAttachedMessage.Checked)
            {
                btnAttachMessageMail.Enabled = true;
            }
            else
            {
                btnAttachMessageMail.Enabled = false;
            }
        }
    }
}
