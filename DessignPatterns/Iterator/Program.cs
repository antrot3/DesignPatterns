﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//Definition
//Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

//Participants

//The classes and objects participating in this pattern are:


//Iterator  (AbstractIterator)
//defines an interface for accessing and traversing elements.
//ConcreteIterator(Iterator)
//implements the Iterator interface.
//keeps track of the current position in the traversal of the aggregate.
//Aggregate(AbstractCollection)
//defines an interface for creating an Iterator object
//ConcreteAggregate(Collection)
//implements the Iterator creation interface to return an instance of the proper ConcreteIterator

namespace Iterator
{
    /// MainApp startup class for Real-World 
    /// Iterator Design Pattern.
   public class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Build a collection

            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator

            Iterator iterator = collection.CreateIterator();

            // Skip every other item

            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }

   
    
}