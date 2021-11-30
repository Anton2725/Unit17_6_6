using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Accounts
{
    class AccountSalary : Account, IAccountCalculator
    {
        public AccountSalary(string type, double balance, double interest) : base(type, balance, interest) { }
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}
