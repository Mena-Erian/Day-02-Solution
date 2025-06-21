using System;

namespace Demo
{
    internal class Program
    {
        //Entry Point
        static void Main()
        {

            #region Variable Declaration and Comments
            //single line Comment
            /**
             * Mulitline
             * of
             * Comments
             **/
            /// re /s
            ///
            //You Should to know somethings when you Declaring Variable
            /**
             * Data Type    |   Name    |   Value   |   Address
             * ing          |   x       |   5       |   1000
             * to know the  |Any key 
             * size it will |word in C# 
             * be taked in  |Don't have 
             * memory       |Kabetal letter
             *              |Pascal Case
             *              |Camel Case
             *              |
             */
            //int Number = 10;//int32
            //short Num = 4;//int16
            // Not Recommend
            //Console.WriteLine("Number = " + Number);
            //Console.WriteLine(); //cw + tap
            //you can meke your snipt
            //Console.WriteLine("Numberb = {0} ,{2} {1}", Number, "Mon", "Name");
            //string interpolation
            //Console.WriteLine($"Number = {Number}"); 
            #endregion

            #region DataType & (CTS,CLS)
            #region Dot Net
            //In Dot Net it is in CTS => Common Type System 
            /**
             * CTS => A full set of types the CLR(Common Language Runtime) understands—foundation for all .NET languages
             * 1- Broader system defining how types(value types, reference types, enums
             *,classes, delegates) are represented and behave in memory and metadata
             * 2- Ensures type safety, enforcing rules like all types deriving from System.Object, consistent memory layout, inheritance behaviors, etc. .
             * 3- Language interoperability: C#’s int, VB’s Integer, or F#’s int all map to the same CTS type (System.Int32) at runtime
             **/
            /**
             * CLS => Common Language Specification
             *        => that any Cross language in Dot Not Should have this CLS or
             *           this Properts and can have more than just CLS
             *        => A compatibility layer—ensures your code can be consumed across all
             *                                      .NET languages
             */
            #endregion
            #region C#
            // Have 2 Categories:
            /// Based on How it will be saved in Memory
            // 1- Value Type (Primitive) => saved in Stack like {Struct | Enum}
            // 2- Reference Type (NonPrimitive) => Value in Heep & the value of
            //    Address or the references in Stack ( Always take 4 byte ) like {Class | interface}
            /**
             * CLR that have the components that Provide the Momery nead of app and 
             * this divide into stack and heep
             * stack take 1MP & Heap Shrink and deShrink depanded of Memorey Nead
             */
            //GC (Garbage Collection) That Component from CLR it control Memory at runtime 
            #endregion
            #endregion

        }//done part 07 Application Memory
    }
}
