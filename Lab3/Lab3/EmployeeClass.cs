using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class EmployeeClass
    {
        public class Employee
        {
            private string _initials;
            private DateTime _employedDay;

            public Employee(string initials, DateTime employedDay)
            {
                _initials = initials;
                _employedDay = employedDay;
            }

            public string GetInitials()
            {
                return _initials;
            }

            public DateTime GetEmployedDay()
            {
                return _employedDay;
            }
        }

        public static Employee[] InputArray()
        {
            Console.WriteLine("Enter number of employees:");
            int numOfEmployees = Convert.ToInt16(Console.ReadLine());
            Employee[] employees = new Employee[numOfEmployees];

            string name = "";
            DateTime employmentDay = new DateTime();
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Enter employee's initials and day of employment:");
                name = Console.ReadLine();
                employmentDay = Convert.ToDateTime(Console.ReadLine());
                while (employmentDay > DateTime.Today)
                {
                    Console.WriteLine("Date error, type date again");
                    employmentDay = Convert.ToDateTime(Console.ReadLine());
                }

                Employee employee = new Employee(name, employmentDay);
                employees[i] = employee;
            }
            return employees;
        }

        public static Employee GetExpEmployee(Employee[] employees)
        {
            Employee expEmployee = employees[0];
            DateTime today = DateTime.Today;
            for (int i = 0; i < employees.Length; i++)
            {
                if (today.Subtract(expEmployee.GetEmployedDay()).TotalDays < today.Subtract(employees[i].GetEmployedDay()).TotalDays)
                {
                    expEmployee = employees[i];
                }
            }
            return expEmployee;
        }
    }
}
