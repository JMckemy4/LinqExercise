using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            int sumMethod = numbers.Sum();
            Console.WriteLine("Task 1: Sum of numbers: " + sumMethod);
            Console.WriteLine("--------------------------");

            //TODO: Print the Average of numbers
            double averageMethod = numbers.Average();
            Console.WriteLine("Task 2: Average of numbers: " + averageMethod);
            Console.WriteLine("--------------------------");

            //TODO: Order numbers in ascending order and print to the console
            var orderedAscending = numbers.OrderBy(n => n);
            Console.WriteLine("Task 3: Numbers in ascending order:");
            Console.WriteLine("--------------------------");

            foreach (var num in orderedAscending)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            //TODO: Order numbers in descending order and print to the console
            var orderedDecsending = numbers.OrderBy(n => -n);
            Console.WriteLine("Task 4: Numbers in decsending order:");
            Console.WriteLine("--------------------------");

            foreach (var num in orderedDecsending)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(n => n > 6);
            Console.WriteLine("Task 5: Numbers greater than 6:");
            Console.WriteLine("--------------------------");

            foreach (var num in greaterThanSix)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var orderedAnyOrder = numbers.OrderBy(n => n).Take(4);
            Console.WriteLine("Task 6: First 4 numbers in ascending order:");
            Console.WriteLine("--------------------------");

            foreach (var num in orderedAnyOrder)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 25;
            var modifiedDescending = numbers.OrderByDescending(n => n);
            Console.WriteLine("Task 7: Numbers in descending order after modification:");
            Console.WriteLine("--------------------------");

            foreach (var num in modifiedDescending)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filteredEmployees = employees.Where(emp => emp.FirstName.StartsWith("C") || emp.FirstName.StartsWith("S"))
                .OrderBy(emp => emp.FirstName);
            Console.WriteLine("Task 8: Employees with FirstName starting with C or S:");
            Console.WriteLine("--------------------------");

            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine(emp.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var filteredEmployeesByAge = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            Console.WriteLine("Task 9: Employees over 26 years old ordered by Age and FirstName:");
            Console.WriteLine("--------------------------");
            foreach (var emp in filteredEmployeesByAge)
            {
                Console.WriteLine($"{emp.FullName}          Age: {emp.Age}");
            }
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoeFilteredEmployees = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35);
            int yoeSum = yoeFilteredEmployees.Sum(emp => emp.YearsOfExperience);
            double yoeAverage = yoeFilteredEmployees.Average(emp => emp.YearsOfExperience);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Task 10: Sum of YearsOfExperience for employees over 35 with YOE <= 10: " + yoeSum);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Average of YearsOfExperience for employees over 35 with YOE <= 10: " + yoeAverage);
            Console.WriteLine("--------------------------");
        

            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = new Employee("Jared", "Mckemy", 25, 0);
            var newList = employees.Append(newEmployee);

            foreach (var emp in newList)
            {
                Console.WriteLine($"{emp.FullName}          Age: {emp.Age}");
            }

            Console.ReadLine();




        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
