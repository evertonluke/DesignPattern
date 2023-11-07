﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0]         = new Resume();
            documents[1]         = new Report();

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
