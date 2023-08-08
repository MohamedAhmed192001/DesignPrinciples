﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Interface_Segregation_Principle.After
{
    abstract class Employee
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        protected abstract decimal CalculateNetSalary();
        public abstract string PrintSalarySlip();
    }
}
