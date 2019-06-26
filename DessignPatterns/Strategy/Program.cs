using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/strategy-design-pattern
//Definition
//Define a family of algorithms, encapsulate each one, and make them interchangeable.Strategy lets the algorithm vary independently from clients that use it.
//    Participants

//    The classes and objects participating in this pattern are:

//Strategy  (SortStrategy)
//declares an interface common to all supported algorithms.Context uses this interface to call the algorithm defined by a ConcreteStrategy
//ConcreteStrategy(QuickSort, ShellSort, MergeSort)
//implements the algorithm using the Strategy interface
//Context  (SortedList)
//is configured with a ConcreteStrategy object
//maintains a reference to a Strategy object
//may define an interface that lets Strategy access its data.

namespace Srategy
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Strategy Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
    }

    

   
}
