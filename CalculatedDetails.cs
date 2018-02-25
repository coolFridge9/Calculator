using System;

namespace taxChallenge
{
    class CalculatedDetails
    {
        public CalculatedDetails(){}

        public CalculatedDetails(string payPeriod, double grossIncome, double incomeTax, double netIncome, double super)
        {
            this.GrossIncome = grossIncome;
            this.IncomeTax = incomeTax;
            this.NetIncome = netIncome;
            this.Super = super;
            this.PayPeriod = payPeriod;
        }

        public double GrossIncome { get; }
        public double NetIncome { get;  }
        public double IncomeTax { get; }
        public double Super { get; }
        public string PayPeriod { get; }
    }
}