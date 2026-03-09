using System;

namespace Practical1.Exercises
{
    internal class Ex2
    {
        public delegate void NotificationHandler(string message);

        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

        public void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }

        public void Example()
        {
            //NotificationHandler notificationHandler = SendEmail;
            //notificationHandler += SendSMS;

            //notificationHandler("Test notification"); це якщо я захочу однакове повідомлення і туди і туди

            NotificationHandler emailHandler = SendEmail;
            NotificationHandler smsHandler = SendSMS;

            emailHandler("Тест для пошти");
            smsHandler("Тест для смс");
        }
    }
}