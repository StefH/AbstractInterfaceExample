using System;
using MyTestLibrary.Infrastructure.Email.Abstractions;

namespace MyTestLibrary.Infrastructure.Email.Gmail
{
    public class EmailServiceForGmail : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Gmail!");
        }
    }
}