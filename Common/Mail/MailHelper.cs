using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mail
{
    public class MailHelper
    {
        public static void SendEmail(MailServer server,string subject,string content,bool isBodyHtml=true)
        {
            MailMessage msg = new MailMessage();
            msg.IsBodyHtml = isBodyHtml;

            SmtpClient mail = new SmtpClient();
            mail.Host = server.Host;
            mail.Port = server.Port;
            mail.Send(msg);
        }
    }

    public class MailServer
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public MailServer() { }
        public MailServer(string host, int port)
        {
            Host = host;
            Port = port;
        }
    }
}
