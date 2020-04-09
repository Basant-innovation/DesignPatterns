using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountChargeTests();
            Console.Write(" ");
            OverchargeTests();
        }

        internal static void AccountChargeTests()
        {
            
            var debitCard = new DebitCard();
            debitCard.ChargeAccount(150.50M);
            debitCard.ChargeAccount(500);
            debitCard.ChargeAccount(200M);
        }

        internal static void OverchargeTests()
        {
            
            var creditCard = new CreditCard();
            creditCard.ChargeAccount(125.50M);
            creditCard.ChargeAccount(500);
            creditCard.ChargeAccount(432.10M);
        }

    }
}
