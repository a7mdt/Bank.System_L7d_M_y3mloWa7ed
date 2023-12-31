﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace oopPracticalExam
{
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();

            string correctManagerPassword = "09040904AM";
            string correctEmployeePassword = "09040904am";
            string checkingName;

            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Are you a Manager or Employee ? \n Manager => M || Employee => E");
            Console.Write("--> ");
            char checkingChar = char.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------------------------\n");

            bank.addEmployee(new Employee("Ahmed Tarek", 30,"010165352201", "E001"));
            bank.addEmployee(new Employee("Menna Salem", 25, "01256981151", "E002"));
            bank.addEmployee(new Employee("Shahd Samir", 29, "015326585142", "E003"));
            bank.addEmployee(new Employee("Mohamed Hasanin", 37, "010056185326", "E004"));
            bank.addEmployee(new Employee("Rwan Matter", 27, "015215946542", "E005"));
          
            bank.addCustomer(new Customer("Abdallah Mohamed ", 35, "010562311256", "C001"));
            bank.addCustomer(new Customer("Mohamed Wael", 59, "012434465815", "C002"));
            bank.addCustomer(new Customer("Yousra Ibrahem", 52, "010156895421", "C003"));
            bank.addCustomer(new Customer("Badria Tolba", 63, "012356487512", "C004"));
            bank.addCustomer(new Customer("Mohaned Yasser", 45, "012458575236", "C005"));
            bank.addCustomer(new Customer("Mayada Elhenawy", 70, "015235684752", "C006"));

            if (checkingChar == 'M' || checkingChar == 'm')
            {
                Console.Write("- Name : ");
                checkingName = Console.ReadLine();
                Console.Write("- Password :");
                string managerPassword = Console.ReadLine();
                Console.WriteLine("\n-------------------------------\n");
                if (managerPassword == correctManagerPassword)
                {
                    Console.WriteLine($"Welcome Mr {checkingName}. \n");

                    bank.displayEmployees();
                    bank.displayCustomers();
                }
                else
                {
                    Console.WriteLine("Sorry, invaild password!");
                }
            }

            else if (checkingChar == 'E' || checkingChar == 'e')
            {
                Console.Write("- Name : ");
                checkingName = Console.ReadLine();
                Console.Write("- Password :");
                string employeePassword = Console.ReadLine();
                Console.WriteLine("\n-------------------------------\n");
                if (employeePassword == correctEmployeePassword)
                {
                    Console.WriteLine($"Welcome Mr {checkingName}. \n");

                    bank.displayCustomers();
                }
                else
                {
                    Console.WriteLine("Sorry, invaild password!");
                }
            }

            else
            {
                Console.WriteLine("Invaild target, You must sign in as Manger or Employee.");
            }

            Console.WriteLine("\n-------------------------------");
        }
    }
}
