using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int principle, int rateofInt, int years)
        {
            int simpleInterest = (principle * rateofInt* years)/100;
            return simpleInterest;          
        }
    }
}
