using System;
using System.Threading.Tasks;

namespace Identity_Security.Service
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string fromAddress, string toAddress, string subject, string message);
    }
}