using System;
using System.Collections.Generic;
namespace taxChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Menu menu = new Menu();
            int choice = menu.GetInput();
            while( choice!= 3)
            {
                if(choice == 1)
                {
                    GetEmployeeDetail newInput = new GetEmployeeDetail();
                    Employee newEmployee =  newInput.TakeInput();  //pascal case for all function
                    Calculation calculatedEmployee= new Calculation(newEmployee);
                    CalculatedDetails details = new CalculatedDetails();
                    details= calculatedEmployee.GetCalculatedDetails();
                    newEmployee.AddCalculations(details);
                    employeeList.Add(newEmployee);
                }
                if(choice==2)
                {
                    foreach (Employee employee in employeeList)
                    {
                        Format1 out1 = new Format1(employee);
                    }
                    Console.WriteLine("");
                }
                menu.PrintMenu();
                choice = menu.GetInput();
            }
        }
    }
}
