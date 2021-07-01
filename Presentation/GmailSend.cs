using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;
namespace Presentation
{
    public partial class GmailSend : Form
    {
        private SellAndSends sec;
        public static string clientname;
        public static string pathfile;
        public GmailSend(SellAndSends sec)
        {
            InitializeComponent();
            this.sec = sec;
            ExecuteData();
            

        }
        private void SendGmail()
        {

            if (File.Exists(pathfile))
            {
               
               
                using (MailMessage mm = new MailMessage(Main.emailsender.Trim(), toemailtxt.Text.Trim()))
                {
                    mm.Subject = subjecttxt.Text;//txtSubject.Text;
                    mm.Body = bodymessagetxt.Text; //txtBody.Text;

                    string fileName = Path.GetFileName(pathfile);
                    mm.Attachments.Add(new Attachment(pathfile));


                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        EnableSsl = true
                    };
                    NetworkCredential NetworkCred = new NetworkCredential(Main.emailsender.Trim(), Main.emailpwd.Trim());
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    MessageBox.Show("El email se envió correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
             
            }
            else
            {
                MessageBox.Show("No se ubica el archivo PDF no se puede continuar", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }








        }

        private void ExecuteData() {
          

            if (!SearchClientByName(clientname))
            {
                
                MessageBox.Show("No se hallaron datos de este cliente,el nombre podría haber sido modificado\nPuedes Colocar los datos" +
                    " manualmente y enviar el email", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                subjecttxt.Clear();
                subjecttxt.Focus();
                bodymessagetxt.Clear();
                bodymessagetxt.Text = Main.sendmsg1 + " " + " " + Main.sendmsg2;
                fromemailtxt.Text = Main.emailsender;
                attachedfiletxt.Text = Path.GetFileName(pathfile);

            }
            else
            {
                bodymessagetxt.Clear();
                bodymessagetxt.Text = Main.sendmsg1+" "+ClientCache.ClientName+" "+Main.sendmsg2;
                ClientNametxt.Text = ClientCache.ClientName;
                fromemailtxt.Text = Main.emailsender;
                toemailtxt.Text = ClientCache.Email;
                subjecttxt.Clear();
                subjecttxt.Focus();
                attachedfiletxt.Text = Path.GetFileName(pathfile);

                ClearClientClass();
                


            }
        }

        private bool ValidateDataEmail() {

            if (fromemailtxt.Text == "") return false;
            if (toemailtxt.Text == "") return false;
            if (subjecttxt.Text == "") return false;
            if (attachedfiletxt.Text == "") return false;

            return true;
        }
        private void ClearClientClass() {
         
            ClientCache.ClientName = "";
            ClientCache.Movil = "";
            ClientCache.Email = "";
            ClientCache.Address = "";
            ClientCache.Fijo = "";
            ClientCache.CreateDate = "";

        }
      

        
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendEmailbtn_Click(object sender, EventArgs e)
        {
            if (ValidateDataEmail())
            {
                try
                {
                    SendGmail();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
            else
            {
                MessageBox.Show("Completar los campos necesarios", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool SearchClientByName(string clientname)
        {
            ClientModel client = new ClientModel();

            return client.SearchClientByName(clientname);

        }
    }
}
