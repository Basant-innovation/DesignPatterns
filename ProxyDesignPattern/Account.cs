using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class Account: ITransaction
    {
        private decimal _balance = 1000;

        public decimal Balance
        {
            get{ return _balance;} 
            set
            {
                if (value == _balance) return;
                Console.Write($"Balance changed from {_balance:C2} to {value:C2}.");
                Console.ReadLine();
                _balance = value;
            }
         }


        public bool ChargeAccount(decimal amount)
        {
            if (Balance >= amount)
            {
                
                Balance -= amount;
                Console.Write($"{this.GetType().Name} charge of {amount:C2} succeeded.");
                Console.ReadLine();
                return true;
            }
            Console.Write($"{this.GetType().Name} charge of {amount:C2} failed due to insufficient funds.");
            Console.ReadLine();
            return false;
        }

        
        
    }
}
