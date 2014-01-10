using System.Net.Mail;

namespace Ronion.MailSenderContract
{
    /// <summary>
    /// Mail client contract
    /// </summary>
    public interface IMailSender
    {
        /// <summary>
        /// Send mail message to a recepient/s
        /// </summary>
        /// <param name="mailMessage"></param>
        void SendMail(MailMessage mailMessage);
    }
}
