using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    interface ITransaction
    {
        decimal Balance { get; set; }
        bool ChargeAccount(decimal amount);
    }
}
