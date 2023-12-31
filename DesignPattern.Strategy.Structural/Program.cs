﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Structural
{
    /// <summary>
    /// Strategy Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }
    }
}
