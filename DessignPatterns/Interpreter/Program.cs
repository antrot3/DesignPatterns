﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.dofactory.com/net/design-patterns
//https://www.dofactory.com/net/interpreter-design-pattern
//The classes and objects participating in this pattern are:


//AbstractExpression  (Expression)
//declares an interface for executing an operation
//TerminalExpression(ThousandExpression, HundredExpression, TenExpression, OneExpression )
//implements an Interpret operation associated with terminal symbols in the grammar.
//an instance is required for every terminal symbol in the sentence.
//NonterminalExpression  (not used )
//one such class is required for every rule R::= R1R2...Rn in the grammar
//maintains instance variables of type AbstractExpression for each of the symbols R1 through Rn.
//implements an Interpret operation for nonterminal symbols in the grammar.Interpret typically calls itself recursively on the variables representing R1 through Rn.
//Context  (Context)
//contains information that is global to the interpreter
//Client  (InterpreterApp)
//builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines.The abstract syntax tree is assembled from instances of the NonterminalExpression and TerminalExpression classes
//invokes the Interpret operation


namespace Interpreter
{
    /// MainApp startup class for Real-World 
    /// Interpreter Design Pattern.
    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);

            // Wait for user

            Console.ReadKey();
        }
    }

}
