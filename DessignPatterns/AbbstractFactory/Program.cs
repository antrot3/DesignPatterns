using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.dofactory.com/net/design-patterns
//Definition
//Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
//      The classes and objects participating in this pattern are:

//AbstractFactory  (ContinentFactory)
//declares an interface for operations that create abstract products
//ConcreteFactory(AfricaFactory, AmericaFactory)
//implements the operations to create concrete product objects
//AbstractProduct(Herbivore, Carnivore)
//declares an interface for a type of product object
//Product(Wildebeest, Lion, Bison, Wolf)
//defines a product object to be created by the corresponding concrete factory
//implements the AbstractProduct interface
//Client  (AnimalWorld)
//uses interfaces declared by AbstractFactory and AbstractProduct classes

namespace AbbstractFactory
{
    /// MainApp startup class for Real-World Abstract Factory Design Pattern. 
    class MainApp
    {
        /// Entry point into console application.

        public static void Main()
        {
            // Create and run the African animal world

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input

            Console.ReadKey();
        }
    }
    
}


