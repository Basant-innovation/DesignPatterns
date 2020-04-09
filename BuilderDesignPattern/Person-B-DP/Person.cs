using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternFluent
{
    class Person
    {
        public string StreetAddress, PostalCode;

        //Job info
        public string CompanyName, Position;
        public int Salary;

        public override string ToString()
        {
            return $"StreetAddress: {StreetAddress}, PostalCode: {PostalCode}\n, " +
                   $"CompanyName:{CompanyName}, Position:{Position}, Salary:{Salary}";
        }
    }
}
