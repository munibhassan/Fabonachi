using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class EmployeesManagement
    {
        private List<Employee> employees;

        public EmployeesManagement(List<Employee> employees)
        {
            this.employees = employees;
        }

        public Dictionary<string, int> AverageAgeForEachCompany()
        {
            var results = employees
                .GroupBy(e => e.Company)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => (int)Math.Round(g.Average(e => e.Age)));
            return new Dictionary<string, int>(results);
        }

        public Dictionary<string, int> CountOfEmployeesForEachCompany()
        {
            var results = employees
                .GroupBy(e => e.Company)
                 .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());
            return new Dictionary<string, int>(results);
        }

        public Dictionary<string, Employee> OldestAgeForEachCompany()
        {
            var results = employees
                .GroupBy(e => e.Company)
                 .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.OrderByDescending(e => e.Age).FirstOrDefault());
            return new Dictionary<string, Employee>(results);
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
    }
}
