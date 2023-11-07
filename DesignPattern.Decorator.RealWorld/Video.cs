using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.RealWorld
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;

        public Video(string dierector, string title, int numCopies, int playTime)
        {
            this.director  = dierector;
            this.title     = title;
            this.NumCopies = numCopies;
            this.playTime  = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ------ ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title   : {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" PlayTime: {0}\n", playTime);
        }
    }
}
