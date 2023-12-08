using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    class Customer : Person
    {
        public string AccountNumber { get; set; }

        public Customer(string name, int age, string accountNumber) : base(name, age)
        {
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, {base.ToString()}";
        }
    }
}
