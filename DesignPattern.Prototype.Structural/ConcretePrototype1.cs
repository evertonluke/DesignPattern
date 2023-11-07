using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.Structural
{
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype1 : Prototype
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public ConcretePrototype1(string id) : base(id)
        {
        }

        /// <summary>
        /// Returns a shallow copy
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
