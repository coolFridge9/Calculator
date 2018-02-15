using System;

namespace taxChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e= new Employee("dave","richy",100000,9.0);
            Console.WriteLine(e.firstName);
        }
    }
}
