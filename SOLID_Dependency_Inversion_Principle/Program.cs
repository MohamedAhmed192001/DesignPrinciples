


using SOLID_Dependency_Inversion_Principle.Before;

namespace DesignPrinciples.SOLID_Dependency_Inversion_Principle
{
    class prgram
    {
        static void Main(string[] args)
        {
            var customers = Repository.Customers;

            foreach (var customer in customers)
            {
                var notificationService = new NotificationService(customer);
                notificationService.Notify();
            }

        }
    }
}