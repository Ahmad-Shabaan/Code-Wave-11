using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWave11
{
    public enum Gender
    {
        M = 1,
        F = 2,
        Male = 1,
        Female = 2,

    }
    public enum SecurityPrivileges
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        //automatic property
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }
        public double Salary { get; set; }

        public DateTime HireDate { get; set; }

        public Gender Gender { get; set; }

        public Employee(int id, string name, SecurityPrivileges securityLevel, double salary, DateTime hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}\t Name: {Name}\t Security Level: {SecurityLevel}\t Salary: {Salary:C}\t Hire Date: {HireDate:yyy-MM-dd}\t Gender: {Gender}";
        }
        public string ShowCurrency()
        {
            return string.Format("Currency: {0:C}", Salary);
        }
    }
}
