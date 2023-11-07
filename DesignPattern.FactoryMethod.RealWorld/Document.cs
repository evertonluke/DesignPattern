using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.RealWorld
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        /// <summary>
        /// 
        /// </summary>
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        { 
            get 
            { 
                return this._pages; 
            } 
        }

        public abstract void CreatePages();
    }
}
