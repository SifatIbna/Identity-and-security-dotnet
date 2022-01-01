using System;

namespace Identity_Security.Service
{
    public class SmtpOptions
    {
        public string Host { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Port { get; set; }
    }
}