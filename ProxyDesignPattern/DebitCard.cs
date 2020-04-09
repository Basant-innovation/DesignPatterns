using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class DebitCard: ITransaction
    {

        private readonly Account _account;
        public decimal Balance { get; set; }

        
        public DebitCard()
        {
            _account = new Account();
        }
        
        public DebitCard(Account account)
        {
            _account = account;
        }

        
        public bool ChargeAccount(decimal amount)
        {
            
            if (_account.Balance >= amount)
            {
                
                Console.Write($"{this.GetType().Name} charge of {amount:C2} succeeded.");
                Console.ReadLine();
                _account.Balance -= amount;
                return true;
            }
            Console.Write($"{this.GetType().Name} charge of {amount:C2} failed due to insufficient funds. Current balance: {_account.Balance:C2}.");
            Console.ReadLine();
            
            return false;
        }


    }
}
