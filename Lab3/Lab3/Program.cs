using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass.Employee[] employees = EmployeeClass.InputArray();
            EmployeeClass.Employee expEmployee = EmployeeClass.GetExpEmployee(employees);
            Console.WriteLine("The most experienced employee is: " + expEmployee.GetInitials());
            Console.ReadKey();
            
        }
    }
}
