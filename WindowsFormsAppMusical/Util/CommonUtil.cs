using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMusical
{
    public class CommonUtil
    {
        public static void SendMail(string subject, string body, string to)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true; //SSL을 사용한다.
                client.UseDefaultCredentials = false; //시스템에 설정된 인증 정보를 사용하지 않는다.
                client.Credentials = new NetworkCredential("gmail계정", "gmail비밀번호");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage message = new MailMessage(new MailAddress("gmail계정"), new MailAddress(to));
                message.Subject = subject;
                message.Body = body;

                message.SubjectEncoding = Encoding.UTF8;
                message.BodyEncoding = Encoding.UTF8;

                client.Send(message);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
