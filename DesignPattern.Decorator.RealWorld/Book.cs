﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.RealWorld
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Book : LibraryItem
    {
        private string author;
        private string title;

        public Book(string author, string title, int numCopies)
        {
            this.author    = author;
            this.title     = title; 
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author  : {0}", author);
            Console.WriteLine(" Title   : {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
