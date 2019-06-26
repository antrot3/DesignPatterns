using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/mediator-design-pattern
//Definition
//Define an object that encapsulates how a set of objects interact.Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

//Participants

//    The classes and objects participating in this pattern are:

//Mediator  (IChatroom)
//defines an interface for communicating with Colleague objects
//ConcreteMediator  (Chatroom)
//implements cooperative behavior by coordinating Colleague objects
//knows and maintains its colleagues
//Colleague classes  (Participant)
//each Colleague class knows its Mediator object
//each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague

namespace Mediator
{
    /// MainApp startup class for Real-World 
    /// Mediator Design Pattern.

    class MainApp

    {
        /// Entry point into console application.

        static void Main()
        {
            // Create chatroom

            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }

   

   

    
}
