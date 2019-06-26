using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.dofactory.com/net/template-method-design-pattern
//Definition
//Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
//    Participants

//    The classes and objects participating in this pattern are:

//AbstractClass  (DataObject)
//defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
//implements a template method defining the skeleton of an algorithm.The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
//ConcreteClass  (CustomerDataObject)
//implements the primitive operations ot carry out subclass-specific steps of the algorithm


namespace Template
{
    /// MainApp startup class for Real-World 
    /// Template Design Pattern.

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user

            Console.ReadKey();
        }
    }

}
