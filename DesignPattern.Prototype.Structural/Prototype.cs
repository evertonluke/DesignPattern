using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.Structural
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class Prototype
    {
        string id;

        public Prototype( string id)
        {
            this.id = id;
        }

        /// <summary>
        /// Gets id
        /// </summary>
        public string Id
        {
            get {  return this.id; }
        }

        public abstract Prototype Clone();
    }
}
