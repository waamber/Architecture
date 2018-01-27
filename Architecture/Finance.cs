using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Finance : DepartmentBase
    {
        public bool Accounts { get; set; }
        public bool Contracts { get; set; }
        public double Budget { get; set; }

        public void WhatDoIDo(bool job)
        {
            if (job == true)
            {
                Console.WriteLine($"I work in the Finance Department, where I work with {job}.");
            }
            else
            {
                Console.WriteLine("I actually don't work here.");
            }
        }

        public override void Meet(string time)
        {
            Console.WriteLine($"Finance will meet in the breakroom at {time}");
        }

        public override double SetBudget(double budget)
        {
            return this.Budget += budget + 75000.00;
        }
    }
}
