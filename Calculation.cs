using System;

namespace taxChallenge
{
    class Calculation
    {
        private double grossIncome;
        private double incomeTax;
        private double netIncome;
        private double super;
        private string payPeriod;

        public Calculation(Employee e)
        {
        
            int annualSalary= e.AnnualSalary;// take tax parameters for other contexts like company
            double superRate = e.SuperRate;
            payPeriod = "01 March – 31 March";
            grossIncome= annualSalary/12.0; 
            grossIncome = Math.Round(grossIncome);

            incomeTax = getIncomeTax(annualSalary);
            incomeTax = Math.Round(incomeTax);

            netIncome = grossIncome - incomeTax;
            netIncome = Math.Round(netIncome);

            super = grossIncome * superRate/100;
            super = Math.Round(super);


        }
        public CalculatedDetails GetCalculatedDetails()
        {
            CalculatedDetails details = new CalculatedDetails(payPeriod, grossIncome,incomeTax,netIncome,super);
            return details;
        }

        public double getIncomeTax(int salary) //pascal case
        {
            if (salary<= 18200)
            {
                return 0.0;
            }
            if (salary<= 37000)
            {
                return calcTax(0,19.0,18200,salary);
            }
            if (salary<= 87000)
            {
                return calcTax(3572, 32.5, 37000,salary);
            }
            if (salary<= 180000)
            {
                return calcTax(19822, 37.0, 87000,salary);
            }
            else
            {
                return calcTax(54232,45.0,180000,salary);
            }

        }    
        public double calcTax(int a,double b, int c, int salary )
        {
            //format "a plus b for each $1 over c"
            return (a+ (salary - c )*(b/100))/12;
        }
    }
}