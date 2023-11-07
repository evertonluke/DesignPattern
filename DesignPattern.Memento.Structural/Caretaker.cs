using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento.Structural
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class Caretaker
    {
        Memento memento;

        public Memento Memento 
        { 
            get { return memento; } 
            set { memento = value; } 
        }
    }
}
