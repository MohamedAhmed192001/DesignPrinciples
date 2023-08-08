using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Dependency_Inversion_Principle.Before
{
    internal class NotificationService
    {
        private readonly EmailService emailService;
        private readonly SMSService smsService;

        public NotificationService(Customer customer)
        {
            emailService = new EmailService()
            {
                EmailAddress = customer.EmailAddress
            };
            smsService = new SMSService()
            {
                PhoneNumber = customer.PhoneNumber
            };
        }
        public void Notify()
        {
            emailService.Send();
            smsService.Send();
        }
    }
}
