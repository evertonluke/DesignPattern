﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.Structural
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
}
