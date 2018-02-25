using System;

namespace taxChallenge
{
    class GetEmployeeDetail
    {

        public Employee TakeInput()
        {
            int annualSalary;
            double superRate;

            Console.Write("First Name: ");
            string firstName= Console.ReadLine();
    
            Console.Write("Last Name: ");
            string lastName= Console.ReadLine();

            Console.Write("Annual Salary: ");
            while (!int.TryParse(Console.ReadLine(),out annualSalary)|| annualSalary<0) //assume no max
            {
                Console.WriteLine(annualSalary);
                Console.WriteLine("Invalid Salary");
                Console.Write("Annual Salary: ");
            }

            Console.Write("Super Rate: ");
            while(!double.TryParse(Console.ReadLine(),out superRate)|| superRate<0) //assumes no max
            {
                Console.WriteLine("invalid Super Rate");
                Console.Write("Super Rate: ");
            }

            Console.WriteLine("...Employee Added...\n");
            Employee newGuy= new Employee(firstName,lastName,annualSalary,superRate);
            return newGuy;
            
        }

    }
}