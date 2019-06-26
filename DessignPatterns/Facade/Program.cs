using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Definition
//Provide a unified interface to a set of interfaces in a subsystem.Façade defines a higher-level interface that makes the subsystem easier to use.

//Participants

//    The classes and objects participating in this pattern are:

//Facade   (MortgageApplication)
//knows which subsystem classes are responsible for a request.
//delegates client requests to appropriate subsystem objects.
//Subsystem classes   (Bank, Credit, Loan)
//implement subsystem functionality.
//handle work assigned by the Facade object.
//have no knowledge of the facade and keep no reference to it.



namespace Facade
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Facade Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }

}
