using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_1
{
    public static class Task_1
    {
        public static void StartTask()
        {
            Employee employee1 = new Employee("Boris P.", 1000);
            Employee employee2 = new Employee("Olena B.", 2000);
            double increase = 100;
            double decrease = 50;

            employee1 = employee1 + increase;
            Console.WriteLine(employee1.Salary);
            employee1 -= decrease;
            Console.WriteLine(employee1.Salary);

            bool result = employee1 < employee2;
            Console.WriteLine(result);

            result = employee1 > employee2;
            Console.WriteLine(result);

            result = employee1 == employee2;
            Console.WriteLine(result);

            result= employee1 != employee2;
            Console.WriteLine(result);

           Console.WriteLine(employee1.Equals(employee2));
        }
    }
}
