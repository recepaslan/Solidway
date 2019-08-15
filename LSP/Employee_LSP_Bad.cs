//Code before Liskov Substitution Principle.
//This code throws an error at empMike, as Bonus is not applicable to ContractEmployee. 
//In that case LSP is violated and we have redefined the code to follow LSP below.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public Employee()
        {
        }

        public Employee(int id, string name )
        {
            this.ID = id; this.Name = name; 
        }

        public abstract decimal CalculateBonus(decimal salary);
       
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}

//Client
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
            Employee empJohn = new PermanentEmployee(1, "John"  );
            Employee empJason = new TemporaryEmployee(2, "Jason" );
            Employee empMike = new ContractEmployee(3, "Mike" );
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empJason.ToString(),
              empJason.CalculateBonus(150000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empMike.ToString(),
              empMike.CalculateBonus(150000).ToString()));

            Console.ReadLine();
        }
    }
}