using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class InformationTechnology : DepartmentBase
    {
        public string Section { get; set; }
        public bool Offline { get; set; }
        public double Budget { get; set; }

        public string IWorkInThisSection(string section)
        {
            return $"I work in on the {section} side of the IT department.";
        }

        public override void Meet(string time)
        {
            Console.WriteLine($"Infromation Technology staff will meet in the west wing conference room at {time}.");
        }

        public override double SetBudget(double budget)
        {
            return this.Budget += budget + 100000.00;
        }
    }
}

