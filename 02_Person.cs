﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    // This Class is The base class for Employee and Customer
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string phoneNum { get; set; }

        public Person(string name, int age, string phoneNumber)
        {
            Name = name;
            Age = age;
            phoneNum = phoneNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name} || Age: {Age} || Phone Number: {phoneNum}";
        }
    }
}
