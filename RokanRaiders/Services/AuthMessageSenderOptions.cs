using System;
namespace RokanRaiders.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }

        public AuthMessageSenderOptions()
        {
        }
    }
}
