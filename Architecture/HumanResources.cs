using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
     class HumanResources : DepartmentBase
     {
        public Dictionary<string, string> policies = new Dictionary<string, string>();
        public double Budget { get; set; }

        public override void Meet(string time)
        {
            Console.WriteLine($"Human Resources staff will meet in the east wing conference room at {time}");
        }

        public override double SetBudget(double budget)
        {
            return this.Budget += budget + 10000.00;
        }
        
    class HumanResources : DepartmentBase
    {
        public Dictionary<string, string> policies = new Dictionary<string, string>();
    }
}