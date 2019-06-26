using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.dofactory.com/net/design-patterns
//Definition
//Compose objects into tree structures to represent part-whole hierarchies.Composite lets clients treat individual objects and compositions of objects uniformly.
//Participants

//    The classes and objects participating in this pattern are:

//Component   (DrawingElement)
//declares the interface for objects in the composition.
//implements default behavior for the interface common to all classes, as appropriate.
//declares an interface for accessing and managing its child components.
//(optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
//Leaf(PrimitiveElement)
//represents leaf objects in the composition.A leaf has no children.
//defines behavior for primitive objects in the composition.
//Composite   (CompositeElement)
//defines behavior for components having children.
//stores child components.
//implements child-related operations in the Component interface.
//Client(CompositeApp)
//manipulates objects in the composition through the Component interface.
namespace Composite

{
    /// MainApp startup class for Real-World 
    /// Composite Design Pattern.

    class MainApp

    {
        /// Entry point into console application.
        static void Main()
        {
            // Create a tree structure 

            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
    
}