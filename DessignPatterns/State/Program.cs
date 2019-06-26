using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/state-design-pattern
//Definition
//Allow an object to alter its behavior when its internal state changes.The object will appear to change its class.
//Participants

//    The classes and objects participating in this pattern are:

//Context  (Account)
//defines the interface of interest to clients
//maintains an instance of a ConcreteState subclass that defines the current state.
//State(State)
//defines an interface for encapsulating the behavior associated with a particular state of the Context.
//Concrete State(RedState, SilverState, GoldState)
//each subclass implements a behavior associated with a state of Context

namespace State
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// State Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Open a new account

            Account account = new Account("Jim Johnson");

            // Apply financial transactions

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user

            Console.ReadKey();
        }
    }

   
    
}