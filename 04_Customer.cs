using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    // This class representing bank employees
    class Customer : Person, phoneNumm
    {
        public string AccountNumber { get; set; }

        public Customer(string name, int age, string phoneNum, string accountNumber) : base(name, age, phoneNum)
        {
            AccountNumber = accountNumber;
        }

        public void myNum()
        {
            string phoneNumber = phoneNum;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber} || {base.ToString()}";
        }

    }
}
