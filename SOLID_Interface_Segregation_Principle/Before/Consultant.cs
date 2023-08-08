using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Interface_Segregation_Principle.Before
{
    class Consultant : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;


        public decimal CalculatePension() => throw new NotImplementedException("NotSupported");



        public decimal CalculateRentalSubsidy() => throw new NotImplementedException("NotSupported");



        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary +
                CalculateBonuses() +
                CalculateHealthInsurance() +
                CalculateTransportationReimbursement();

        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(DayLabourer)} ---" +
               $"\n No.: {EmployeeNo}" +
               $"\n Name: {Name}" +
               $"\n Basic Salary: {Salary.ToString("C2")}" +
               $"\n Bonuses: {CalculateBonuses().ToString("C2")}" +
               $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
               $"\n Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
               $"\n -----------------------------------------------" +
               $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
