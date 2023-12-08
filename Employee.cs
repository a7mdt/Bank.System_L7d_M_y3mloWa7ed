using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    // This class representing bank employees
    class Employee : Person, phoneNumm
    {
        public string EmployeeId { get; set; }

        public Employee(string name, int age, string phoneNum, string employeeId) : base(name, age, phoneNum)
        {
            EmployeeId = employeeId;
        }

        public void myNum()
        {
            string phoneNumber = phoneNum;
        }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeId}, {base.ToString()}";
        }


    }
}
