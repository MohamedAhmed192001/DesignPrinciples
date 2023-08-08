using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Dependency_Inversion_Principle.Before
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"Email is sent to {EmailAddress}");
        }
    }
}
