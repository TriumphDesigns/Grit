﻿using System;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
