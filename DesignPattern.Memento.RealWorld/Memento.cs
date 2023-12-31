﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento.RealWorld
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        string name;
        string phone;
        double budget;

        public Memento(string name, string phone, double budget)
        {
            this.name   = name;
            this.phone  = phone;
            this.budget = budget;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        { 
            get { return phone; } 
            set {  phone = value; } 
        }

        public double Budget 
        { 
            get { return budget; } 
            set { budget = value; } 
        }
    }
}
