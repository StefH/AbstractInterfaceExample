using System;
using MyTestLibrary.Infrastructure.Email.Abstractions;

namespace MyTestLibrary.Infrastructure.Email.Outlook
{
    public class EmailServiceForOutlook : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Outlook!");
        }
    }
}