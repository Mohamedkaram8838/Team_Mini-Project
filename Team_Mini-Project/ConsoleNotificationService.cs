using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class ConsoleNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
