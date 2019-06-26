using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//https://www.dofactory.com/net/command-design-pattern
//Definition
//Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations
//Participants

//    The classes and objects participating in this pattern are:

//Command  (Command)
//declares an interface for executing an operation
//ConcreteCommand(CalculatorCommand)
//defines a binding between a Receiver object and an action
//implements Execute by invoking the corresponding operation(s) on Receiver
//Client(CommandApp)
//creates a ConcreteCommand object and sets its receiver
//Invoker(User)
//asks the command to carry out the request
//Receiver(Calculator)
//knows how to perform the operations associated with carrying out the request.

namespace Command
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Command Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Create user and let her compute

            User user = new User();

            // User presses calculator buttons

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands

            user.Undo(4);

            // Redo 3 commands

            user.Redo(3);

            // Wait for user

            Console.ReadKey();
        }
    }

    


}