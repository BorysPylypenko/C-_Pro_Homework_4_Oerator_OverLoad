using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_1
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary {  get; set; }

        public Employee(string name, double salary) 
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, double increase)
        {
            employee.Salary += increase;
            return employee;
        }

        public static Employee operator -(Employee employee, double decrease) 
        {
            employee.Salary -= decrease;
            return employee;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        public static bool operator  ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Employee employee = (Employee)obj;
            return this.Salary == employee.Salary;
            
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }
}
