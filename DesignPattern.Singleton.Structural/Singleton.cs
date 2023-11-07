using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton.Structural
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class Singleton
    {
        static Singleton instance;

        /// <summary>
        /// Construtor is 'protected'
        /// </summary>
        protected Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
