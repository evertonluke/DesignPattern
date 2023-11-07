using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.RealWorld
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection
            Employees employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());
            // Employees are 'visited'
            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());
            // Wait for user
            Console.ReadKey();
        }
    }
}
