using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Dependency_Inversion_Principle.Before
{
    internal class Repository
    {
        public static List<Customer> Customers => 
            new List<Customer>() 
            { 
                new Customer()
                {
                    Id = 1,
                    Name = "Mohamed Ahmed",
                    EmailAddress ="Mohamed@gmail.com",
                    PhoneNumber = "1234567890",
                    Address = "123 2nd Avenue California, USA"
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Abdo Gomaa",
                    EmailAddress ="Abdo@gmail.com",
                    PhoneNumber = "12345647896",
                    Address = "321 3nd Avenue California, USA"
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Eslam Ahmed",
                    EmailAddress ="Eslam@gmail.com",
                    PhoneNumber = "1234567471",
                    Address = "148 4nd Avenue California, USA"
                },
            };
    }
}
