using EmailService1.Models;

namespace EmailService1.Services.EmailService;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}
