using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_2
{
    public static class Task_2
    {
        public static void StartTask()
        {
            City odessa = new City("Odesa", 1000);
            City kiev = new City("Kiev", 2000);

            int increase = 100;
            int decrease = 50;

            odessa += increase;
            Console.WriteLine(odessa.Qty_Citizen);
            odessa -= decrease;
            Console.WriteLine(odessa.Qty_Citizen);

            bool result;
            result = odessa > kiev;
            Console.WriteLine(result);
            result = odessa < kiev;
            Console.WriteLine(result);
            result = odessa == kiev;
            Console.WriteLine(result);

            Console.WriteLine(odessa.Equals(kiev));
        }
    }
}
