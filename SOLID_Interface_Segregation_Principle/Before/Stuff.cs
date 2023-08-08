using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Interface_Segregation_Principle.Before
{
    class Stuff : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;


        public decimal CalculatePension() => Salary * 0.025m;



        public decimal CalculateRentalSubsidy() => 150m;



        public decimal CalculateTransportationReimbursement() => throw new NotImplementedException("NotSupported");



        protected override decimal CalculateNetSalary()
        {
            return Salary +
                CalculateBonuses() +
                CalculateHealthInsurance() +
                CalculatePension() +
                CalculateRentalSubsidy();

        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(DayLabourer)} ---" +
               $"\n No.: {EmployeeNo}" +
               $"\n Name: {Name}" +
               $"\n Basic Salary: {Salary.ToString("C2")}" +
               $"\n Bonuses: {CalculateBonuses().ToString("C2")}" +
               $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
               $"\n Pension: {CalculatePension().ToString("C2")}" +
               $"\n Rental Subsidy: {CalculateRentalSubsidy().ToString("C2")}" +
               $"\n -----------------------------------------------" +
               $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
