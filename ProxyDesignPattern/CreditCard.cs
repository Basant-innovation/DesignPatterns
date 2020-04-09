using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class CreditCard: ITransaction
    {
            private readonly Account _account;
            public decimal Balance { get; set; }

            
            public CreditCard()
            {
                _account = new Account();
            }

            
            public CreditCard(Account account)
            {
                _account = account;
            }

            
            public bool ChargeAccount(decimal amount)
            {
                
                if (_account.Balance >= amount)
                {
                    
                    Console.Write($"{this.GetType().Name} charge of {amount:C2} succeeded.");
                    Console.ReadLine();
                }
                else
                {
                    
                    Console.Write($"{this.GetType().Name} charge of {amount:C2} succeeded, as overcharge.");
                    Console.ReadLine();
                }
                
                _account.Balance -= amount;
                return true;
            }
        }
    }
