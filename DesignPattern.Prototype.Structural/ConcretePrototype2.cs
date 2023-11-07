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
    public class ConcretePrototype2 : Prototype
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public ConcretePrototype2(string id) : base(id)
        {
        }

        /// <summary>
        /// Returns a shallow copy
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
