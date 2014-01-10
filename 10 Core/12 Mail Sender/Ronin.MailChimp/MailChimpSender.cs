using System.Net.Mail;
using Ronion.MailSenderContract;
using Ronion.MailSenderContract.Extensibility.Exports;

namespace Ronin.MailChimp
{
    [MailSenderExport(typeof(IMailSender))]
    internal class MailChimpSender : IMailSender
    {
        /// <summary>
        /// Send mail message to a recepient/s
        /// </summary>
        /// <param name="mailMessage"></param>
        public void SendMail(MailMessage mailMessage)
        {
            
        }
    }
}
