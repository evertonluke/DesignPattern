﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Interpreter.RealWorld
{
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman    = "MCMXXVIII";
            Context context = new Context(roman);

            // Biold the 'part tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree) 
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }
}
