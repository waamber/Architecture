using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    abstract class DepartmentBase
    {
        public string DeptName { get; set; }
        public string Supervisor { get; set; }
        public int EmployeeCount { get; set; }
        public double BaseBudget { get; set; }

        abstract public void Meet(string time);
        public virtual double SetBudget(double budget)
        {
            return BaseBudget = budget;
        }
    }
}