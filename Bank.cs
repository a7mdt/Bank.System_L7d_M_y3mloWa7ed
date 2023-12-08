using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPracticalExam
{
    class Bank
    {
        private List<Employee> employeesList;
        private List<Customer> customersList;

        public Bank()
        {
            employeesList = new List<Employee>();
            customersList = new List<Customer>();
        }

        public void addEmployee(Employee employee)
        {
            employeesList.Add(employee);
        }

        public void addCustomer(Customer customer)
        {
            customersList.Add(customer);
        }

        public void displayEmployees()
        {
            Console.WriteLine("-Our Employees:\n");
            foreach (Employee employee in employeesList)
            {
                Console.Write($"{employeesList.IndexOf(employee) + 1}) ");
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }

        public void displayCustomers()
        {
            Console.WriteLine("-Our Customers:\n");
            foreach (Customer customer in customersList)
            {
                Console.Write($"{customersList.IndexOf(customer) + 1}) ");
                Console.WriteLine(customer);
            }
        }
    }
}
