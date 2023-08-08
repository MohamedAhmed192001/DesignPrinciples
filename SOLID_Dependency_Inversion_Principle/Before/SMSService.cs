using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Dependency_Inversion_Principle.Before
{
    internal class SMSService
    {
        public string PhoneNumber { get; set; }
        public void Send()
        {
            Console.WriteLine($"SMS is sent to {PhoneNumber}");
        }
    }
}
