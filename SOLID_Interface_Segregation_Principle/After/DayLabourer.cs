using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Interface_Segregation_Principle.After
{
    class DayLabourer : Employee, IHealthInsuranceEntitlement, ITransportationReimbursementEntitlement
    {
        public decimal CalculateHealthInsurance() => 30m;

        public decimal CalculateTransportationReimbursement() => 150m;

        protected override decimal CalculateNetSalary()
        {
            return Salary +
                CalculateHealthInsurance() +
                CalculateTransportationReimbursement();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(DayLabourer)} ---" +
                $"\n No.: {EmployeeNo}" +
                $"\n Name: {Name}" +
                $"\n Basic Salary: {Salary.ToString("C2")}" +
                $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                $"\n Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
                $"\n -----------------------------------------------" +
                $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
