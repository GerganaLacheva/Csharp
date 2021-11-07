using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

            string command = Console.ReadLine();
            while (!command.Contains("End"))
            {
                string company = command.Split( '-','>')[0];
                string employee = command.Split('-', '>')[1];

                if (companies.ContainsKey(company))
                {
                    companies[company].Add(employee);
                }
                else
                {
                    var employees = new HashSet<string>() { employee };
                    companies.Add(company, employees);
                }

                command = Console.ReadLine();
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            companies.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}");
                x.Value.ToList().ForEach(e =>
                {
                    Console.WriteLine($"-- {e}");
                });
            });
        }
    }
}
//8.Company Users
//Create a program that keeps information about companies and their employees. 
//You will be receiving a company name and an employee's id, until you receive the command "End" command.
//Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
//When you finish reading the data, order the companies by the name in ascending order. 
//Print the company name and each employee's id in the following format:
//{companyName}
//-- { id1}
//-- { id2}
//-- { idN}
//Input / Constraints
//•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
//•	The input always will be valid.
//Examples
//Input	
//SoftUni -> AA12345
//SoftUni -> BB12345
//Microsoft -> CC12345
//HP -> BB12345
//End	
    
//Output
//HP
//-- BB12345
//Microsoft
//-- CC12345
//SoftUni
//-- AA12345
//-- BB12345
