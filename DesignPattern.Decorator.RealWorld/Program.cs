using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.RealWorld
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP .NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielber", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, the borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
