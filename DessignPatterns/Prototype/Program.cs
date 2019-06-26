﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.dofactory.com/net/design-patterns
//Definition
//Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
//The classes and objects participating in this pattern are:


//Prototype  (ColorPrototype)
//declares an interface for cloning itself
//ConcretePrototype(Color)
//implements an operation for cloning itself
//Client(ColorManager)
//creates a new object by asking a prototype to clone itself


namespace Prototype
{
    /// MainApp startup class for Real-World 
    /// Prototype Design Pattern.

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            // Wait for user

            Console.ReadKey();
        }
    }

   

    
}