using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//Definition
//Attach additional responsibilities to an object dynamically.Decorators provide a flexible alternative to subclassing for extending functionality.
//Participants

//    The classes and objects participating in this pattern are:

//Component   (LibraryItem)
//defines the interface for objects that can have responsibilities added to them dynamically.
//ConcreteComponent(Book, Video)
//defines an object to which additional responsibilities can be attached.
//Decorator(Decorator)
//maintains a reference to a Component object and defines an interface that conforms to Component's interface.
//ConcreteDecorator(Borrowable)
//adds responsibilities to the component.

namespace Decorator
{
    /// MainApp startup class for Real-World 
    /// Decorator Design Pattern.
    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

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