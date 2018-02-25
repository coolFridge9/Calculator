using System;

namespace taxChallenge
{
    class Employee
    {
        private CalculatedDetails details; //public not readonly

        public Employee(){} 

        public Employee(string firstName, string lastName, int salary, double superRate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
            this.SuperRate = superRate;
            details = null;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get { return FirstName + " " + LastName; }}
        public int AnnualSalary { get; } //assumed int
        public double SuperRate { get; }


        public void AddCalculations(CalculatedDetails calculations)
        {
            details=calculations;
        }

        public string PayPeriod{ get { return details.PayPeriod; }}
        public double GrossIncome{ get { return details.GrossIncome; }}
        public double IncomeTax{ get { return details.IncomeTax; }}
        public double NetIncome{ get { return details.NetIncome; }}
        public double Super { get { return details.Super; } }
    }
}