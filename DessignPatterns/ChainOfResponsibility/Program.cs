﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//https://www.dofactory.com/net/chain-of-responsibility-design-pattern
//Definition
//Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.Chain the receiving objects and pass the request along the chain until an object handles it.
//Participants

//    The classes and objects participating in this pattern are:

//Handler   (Approver)
//defines an interface for handling the requests
//(optional) implements the successor link
//ConcreteHandler(Director, VicePresident, President)
//handles requests it is responsible for
//can access its successor
//if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
//Client(ChainApp)
//initiates the request to a ConcreteHandler object on the chain

namespace ChainOfResponsibility
{
    /// MainApp startup class for Real-World 
    /// Chain of Responsibility Design Pattern.

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }

    
    



}