﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.RealWorld
{
    /// <summary>
    /// Chain of Responsibility Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam   = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.0, "Supplies");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.20, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
