using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DepartmentBase> departments = new List<DepartmentBase>();

            var hr = new HumanResources
            {
                DeptName = "HR",
                Supervisor = "George Clooney",
                EmployeeCount = 5
            };

            var it = new InformationTechnology
            {
                DeptName = "IT",
                Supervisor = "Elon Musk",
                EmployeeCount = 25
            };

            var finance = new Finance
            {
                DeptName = "Finance",
                Supervisor = "Bill Gates",
                EmployeeCount = 9
            };

            departments.Add(hr);
            departments.Add(it);
            departments.Add(finance);

            var BaseBudget = 75000.00;

            foreach (DepartmentBase d in departments)
            {
                Console.WriteLine($"{d.Supervisor} is head of the {d.DeptName} department, overseeing {d.EmployeeCount} employees. Their budget for the year is {d.SetBudget(BaseBudget)}");
            }

            Console.ReadLine();
        }

    }
}

