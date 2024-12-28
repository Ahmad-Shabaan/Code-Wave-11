using System;
namespace CodeWave11
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//
            // Design and implement a class to represent employees in a company with the following requirements:
            // 1. Employee Definition:  
            //The employee should be identified by the following fields:  - ID(Unique identifier).  - Name.  - Security Level.  - Salary.  - Hire Date.  - Gender (Restricted to "M" or "F" for Male or Female).  
            //2. Security Privileges:  
            //Assign security privileges to the employee using an Enum with the following roles:  - Guest.  - Developer.  - Secretary.  - DBA(Database Administrator).  
            //3.Additional Features:  - Override the ToString() method to represent employee data as a formatted string.  - Display the employee's salary in currency format using the String.Format() method.

            //Employee employee = new Employee(
            //       id: 1,
            //       name: "Ahmed Shabaan",
            //       securityLevel: SecurityPrivileges.Developer,
            //       salary: 75000.50,
            //       hireDate: new DateTime(2025, 1, 1),
            //       gender: Gender.M
            //   );
            //Console.WriteLine(employee);


            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//

            //-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays
            // the name and age of the oldest person.

            //Person[] persons = new Person[3];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Please enter data for person {i + 1}");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Age : ");
            //    bool flag = int.TryParse(Console.ReadLine(), out int age);

            //    if (!flag || string.IsNullOrWhiteSpace(name))
            //        i--;
            //    else
            //        persons[i] = new Person(name, age);

            //}

            //Person oldestPerson = persons[0];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is: {oldestPerson}");



            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//
            //**********************************   ***********************************************************************//

            // -Develop a Class to represent the Hiring Date Data:
            // Consisting of fields to hold the day, month and Years.

            //try
            //{
            //    HiringDate hireDate1 = new HiringDate(15, 5, 2020);
            //    Console.WriteLine($"Hire Date: {hireDate1}");

            //    HiringDate hireDate2 = new HiringDate(35, 2, 2020); 
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
        }
    }
}
