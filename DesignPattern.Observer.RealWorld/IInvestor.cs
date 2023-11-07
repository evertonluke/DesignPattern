using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.RealWorld
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
