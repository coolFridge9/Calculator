using System;

namespace taxChallenge
{
    class Format1
    {
        public Format1(Employee e)
        {
            Console.WriteLine(e.FullName+" "+e.PayPeriod+" "+e.GrossIncome+" "+e.IncomeTax+" "+e.NetIncome+" "+e.Super);
        } 
        
    }
}