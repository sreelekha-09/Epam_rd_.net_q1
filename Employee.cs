using System;
using System.Collections.Generic;

namespace DelegatesExample
{
    /// <summary>
    /// Class for illustration of delegates
    /// </summary>
    class Employee:IComparable<Employee>
    {
        public int id { get; set; }
        public string company { get; set; }
        public double salary { get; set; }
        /// <summary>
        /// Implementation method of IComparable Interface
        /// </summary>
        
        public int CompareTo(Employee other)
        {
            if (this.id < other.id)
            {
                return -1;
            }
            else if (this.id > other.id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Method to compare to employee Objects
        /// </summary>
        
        private static int CompareEmployee(Employee x, Employee y)
        {
            return x.salary.CompareTo(y.salary);
        }
        static void Main(string[] args)
        {
            
            Employee b1 = new Employee { id = 1125, company = "company1", salary = 490.97 };
            Employee b2 = new Employee { id = 2153, company = "company2", salary = 469.18 };
            Employee b3 = new Employee { id = 1030, company = "company3", salary = 510.79 };
            List<Employee> Employees = new List<Employee>() { b1, b2, b3 };
            Employees.Sort();
            Console.WriteLine("sorted by manufactureid");
            foreach (Employee bb in Employees)
            {
                Console.WriteLine(bb.id + " " + bb.company + " " + bb.salary);

            }
            Comparison<Employee> mydel = new Comparison<Employee>(CompareEmployee);//Passing method as a parameter
            Employees.Sort(mydel);
            Console.WriteLine("sorted by cost");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.id + " " + emp.company + " " + emp.salary);

            }
        }
    }
}
