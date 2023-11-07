using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.Structural
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        public abstract void Handler(Context context);
    }
}
