using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//Definition
//Decouple an abstraction from its implementation so that the two can vary independently.
//The classes and objects participating in this pattern are:

//Abstraction   (BusinessObject)
//defines the abstraction's interface.
//maintains a reference to an object of type Implementor.
//RefinedAbstraction   (CustomersBusinessObject)
//extends the interface defined by Abstraction.
//Implementor(DataObject)
//defines the interface for implementation classes.This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different.Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
//ConcreteImplementor(CustomersDataObject)
//implements the Implementor interface and defines its concrete implementation.
namespace Bridge
{
    /// MainApp startup class for Real-World 
    /// Bridge Design Pattern.

    class MainApp

    {
        /// Entry point into console application.

        static void Main()
        {
            // Create RefinedAbstraction

            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user

            Console.ReadKey();
        }
    }

    

}