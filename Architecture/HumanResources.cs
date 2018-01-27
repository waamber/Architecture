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
    }
}