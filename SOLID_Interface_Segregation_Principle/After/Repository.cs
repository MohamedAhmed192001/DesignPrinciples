using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Interface_Segregation_Principle.After
{
    class Repository
    {
        public static List<Employee> LoadEmployees()
        {
            return new List<Employee>() 
            { 
                new DayLabourer()
                {
                    Name = "Mohamed",
                    EmployeeNo = "11",
                    Salary = 1000,
                },
                new Stuff()
                {
                    Name = "Abdo",
                    EmployeeNo = "12",
                    Salary = 1000,
                },
                new Consultant()
                {
                    Name = "Gomaa",
                    EmployeeNo = "13",
                    Salary = 1000,
                },
            };
        }
    }
}
