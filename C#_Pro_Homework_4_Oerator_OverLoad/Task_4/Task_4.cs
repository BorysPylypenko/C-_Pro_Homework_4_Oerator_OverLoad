using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_4
{
    public class Task_4
    {
        public static void StartTask()
        {
            Matrix matrix = new Matrix(3,3);
            
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

        }
    }
}
