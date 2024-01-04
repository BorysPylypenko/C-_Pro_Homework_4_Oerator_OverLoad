using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_3
{
    internal class CreditCard
    {
        public int CVC {  get; set; }
        
        public double Balance {  get; set; }

        public CreditCard(int cvc,double balance)
        {
            Balance = balance;
            CVC = cvc;
        }

        public static CreditCard operator +(CreditCard card, double increase)
        {
            card.Balance += increase;
            return card;
        }
        public static CreditCard operator -(CreditCard card, double decrease)
        {
            card.Balance -= decrease;
            return card;
        }
        public static bool operator >(CreditCard card, double value)
        {
            return card.Balance > value;
        }
        public static bool operator <(CreditCard card, double value)
        {
            return card.Balance < value;
        }
        public static bool operator ==(CreditCard card, double cvc)
        {
            return card.CVC == cvc;
        }
        public static bool operator !=(CreditCard card, double cvc)
        {
            return card.CVC != cvc;
        }
    }

   
}
