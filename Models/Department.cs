using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Department : IStoreable
    {
        public IComparable Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
