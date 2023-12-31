﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Structural
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            // Setup structure
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());
            // Create visitor objects
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();
            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
            // Wait for user
            Console.ReadKey();
        }
    }
}
