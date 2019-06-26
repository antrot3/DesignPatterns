using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/visitor-design-pattern
//Definition
//Represent an operation to be performed on the elements of an object structure.Visitor lets you define a new operation without changing the classes of the elements on which it operates.
//       The classes and objects participating in this pattern are:

//Visitor  (Visitor)
//declares a Visit operation for each class of ConcreteElement in the object structure.The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
//ConcreteVisitor  (IncomeVisitor, VacationVisitor)
//implements each operation declared by Visitor.Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure.ConcreteVisitor provides the context for the algorithm and stores its local state.This state often accumulates results during the traversal of the structure.
//Element  (Element)
//defines an Accept operation that takes a visitor as an argument.
//ConcreteElement  (Employee)
//implements an Accept operation that takes a visitor as an argument
//ObjectStructure  (Employees)
//can enumerate its elements
//may provide a high-level interface to allow the visitor to visit its elements
//may either be a Composite(pattern) or a collection such as a list or a set

namespace Visitor
{
    /// MainApp startup class for Real-World 
    /// Visitor Design Pattern.

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
        }
    }
    
}