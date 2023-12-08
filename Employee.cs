using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    // This class representing bank employees
    class Employee : Person
    {
        public string EmployeeId { get; set; }

        public Employee(string name, int age, string employeeId) : base(name, age)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeId}, {base.ToString()}";
        }
    }
}
