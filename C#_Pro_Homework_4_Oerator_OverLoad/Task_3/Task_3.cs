using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_3
{
    public static class Task_3
    {
        public static void StartTask()
        {
            CreditCard card = new CreditCard(565, 1000);
            double increase = 100;
            double decrease = 50;

            card += increase;
            Console.WriteLine(card.Balance);
            card -= decrease;
            Console.WriteLine(card.Balance);

            bool result;
            Console.WriteLine("Enter value for equals");
            double value = double.Parse(Console.ReadLine());

            result = card > value;
            Console.WriteLine(result);
            result = card < value;
            Console.WriteLine(result);

            Console.WriteLine("Enter CVC code");
            int cvc = int.Parse(Console.ReadLine());

            result = card == cvc;
            Console.WriteLine(result);
        }
    }
}
