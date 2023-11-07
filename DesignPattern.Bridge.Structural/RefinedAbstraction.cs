using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Structural
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
