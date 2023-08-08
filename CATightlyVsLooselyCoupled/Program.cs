
namespace DesignPrinciples.CATightlyVsLooselyCoupled
{

    class prgram
    {

        static void Main(string[] args)
        {
            var serviceMode = NotificationModeRefactory.Create(NotificationMode.WEIRD);
            NotificationService notificationService = new NotificationService(serviceMode);
            notificationService.Notify();

        }

    }

    class NotificationModeRefactory
    {
        public static INotificationMode Create(NotificationMode mode)
        {
            switch (mode)
            {
                case NotificationMode.EMAIL:
                    return new EmailService();
                case NotificationMode.SMS:
                    return new SmsService();
                case NotificationMode.WEIRD:
                    return new WeirdService();
                default:
                    return new EmailService();
            }
        }
    }

    enum NotificationMode
    {
        EMAIL,
        SMS,
        WEIRD
    }


    interface INotificationMode
    {
        public void Send();
    }


    class EmailService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }


    class WeirdService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("here we are using WeirdService");
        }
    }


    class SmsService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("SMS sent");
        }
    }



    class NotificationService
    {
        private readonly INotificationMode notificationMode;

        public NotificationService(INotificationMode _notificationMode)
        {
            notificationMode = _notificationMode;
        }
        public void Notify()
        {
            notificationMode.Send();
        }
    }

}
