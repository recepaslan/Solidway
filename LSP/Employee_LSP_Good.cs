//Code after Implementing Liskov Substitution Principle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LSPDemoConsole
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Employee()
        { }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal GetMinimumSalary();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}

//Client
using LSPDemoConsole.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List <IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}