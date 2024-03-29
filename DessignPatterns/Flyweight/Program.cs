﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Definition
//Use sharing to support large numbers of fine-grained objects efficiently.

//The classes and objects participating in this pattern are:


//Flyweight   (Character)
//declares an interface through which flyweights can receive and act on extrinsic state.
//ConcreteFlyweight(CharacterA, CharacterB, ..., CharacterZ)
//implements the Flyweight interface and adds storage for intrinsic state, if any.A ConcreteFlyweight object must be sharable.Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.
//UnsharedConcreteFlyweight   (not used )
//not all Flyweight subclasses need to be shared.The Flyweight interface enables sharing, but it doesn't enforce it. It is common for UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children at some level in the flyweight object structure (as the Row and Column classes have).
//FlyweightFactory(CharacterFactory)
//creates and manages flyweight objects
//ensures that flyweight are shared properly.When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.
//Client(FlyweightApp)
//maintains a reference to flyweight(s).
//computes or stores the extrinsic state of flyweight(s).


//https://www.dofactory.com/net/design-patterns

namespace Flyweight
{
    /// MainApp startup class for Real-World 
    /// Flyweight Design Pattern.

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Build a document with text

            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state

            int pointSize = 10;

            // For each character use a flyweight object

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Wait for user

            Console.ReadKey();
        }
    }

}
