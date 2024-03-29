﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/memento-design-pattern
//Definition
//Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
//    Participants

//    The classes and objects participating in this pattern are:

//Memento  (Memento)
//stores internal state of the Originator object. The memento may store as much or as little of the originator's internal state as necessary at its originator's discretion.
//protect against access by objects of other than the originator.Mementos have effectively two interfaces.Caretaker sees a narrow interface to the Memento -- it can only pass the memento to the other objects.Originator, in contrast, sees a wide interface, one that lets it access all the data necessary to restore itself to its previous state.Ideally, only the originator that produces the memento would be permitted to access the memento's internal state.
//Originator  (SalesProspect)
//creates a memento containing a snapshot of its current internal state.
//uses the memento to restore its internal state
//Caretaker(Caretaker)
//is responsible for the memento's safekeeping
//never operates on or examines the contents of a memento.

namespace Memento
{
    /// MainApp startup class for Real-World 
    /// Memento Design Pattern.
    class MainApp

    {
        /// Entry point into console application.
        static void Main()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }

   


   
}