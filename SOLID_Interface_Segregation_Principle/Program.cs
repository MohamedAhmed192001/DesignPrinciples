
//using SOLID_Interface_Segregation_Principle.Before;
using SOLID_Interface_Segregation_Principle.After;

namespace DesignPrinciples.SOLID_Interface_Segregation_Principle
{
    class prgram
    {
        static void Main(string[] args)
        {
            var Employees = Repository.LoadEmployees();
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.PrintSalarySlip());
                Console.WriteLine();
            }
        }
    }
}