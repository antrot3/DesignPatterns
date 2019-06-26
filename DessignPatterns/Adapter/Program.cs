using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.dofactory.com/net/design-patterns
//https://www.dofactory.com/net/design-patterns
//Definition
//Convert the interface of a class into another interface clients expect.Adapter lets classes work together that
//couldn't otherwise because of incompatible interfaces.

//The classes and objects participating in this pattern are:


//Target   (ChemicalCompound)
//defines the domain-specific interface that Client uses.
//Adapter(Compound)
//adapts the interface Adaptee to the Target interface.
//Adaptee(ChemicalDatabank)
//defines an existing interface that needs adapting.
//Client(AdapterApp)
//collaborates with objects conforming to the Target interface.
namespace Adapter
{
    /// MainApp startup class for Real-World 
    /// Adapter Design Pattern.
    class MainApp
    {
        /// Entry point into console application.
        static void Main()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
   
}

