using System;

namespace taxChallenge
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public int annualSalary;  //assumed int
        public double superRate;

        public Employee(string fn, string ln, int salary, double sr)
        {
            firstName = fn;
            lastName = ln;
            annualSalary = salary;
            superRate = sr;
        }
    }
}