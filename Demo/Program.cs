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
             * memory       |Kabetal letter and we use those naming convinsion =>
             *              |Pascal Case
             *              |Camel Case
             *              |
             */
            //int Number = 10;//int32
            //short Num = 4;//int16
            // Not Recommend use this => int32 
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
             * 2- Ensures type safety(ex..int+string), enforcing rules like all types deriving from System.Object, consistent memory layout, inheritance behaviors, etc. .
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
            // 2- Reference Type (NonPrimitive) => Value saved in Heep & the value of
            //    Address or the references in Stack ( Always take 4 byte ) like {Class | interface}
            /**
             * CLR that have the components that Provide the Momery nead of app and 
             * this divide into stack and heep
             * stack take 1MP & Heap Shrink and deShrink depanded of Memorey Need
             */
            //GC (Garbage Collection) That Component from CLR it control Memory at runtime

            #endregion
            #region Value Type
            //int x;
            /// Declare for variable of type "integer"
            /// CLR will Allocate of Unitillized bytes in Stack.
            /// int: C# Keyword
            //x = 5;
            //Int32 y = 10;
            /// Declare for variable of type "integer"
            /// CLR will Allocate of Unitillized bytes in Stack.
            /// int32: BCL => Base Class Library
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region Reference Type
            //Point p1;
            /// Declare for refernce of type "Point", Refering to the Default Value of the Reference that "Null"
            /// This reference P1 Can refer to an Object of type point of another type inheriting from type "Point"
            /// CLR will Allocate 4 byte in Stack for the reference "P1".
            /// CLR will Allocate 0 byte in HEAP.
            //also can do this p1=new()
            //p1 = new Point();
            //new
            /// 1.Allocate the Required Number of Bytes For the Object at HEAP (Object Size + CLR Overhead Variables)
            /// 2.Initilize the Allocated Bytes with The defult value of its datatype
            /// 3.Call User-Defined Constructor [if exists]
            /// 4.Return the Address of the Allocated obeject to the reference 'p1' in Stack

            //Console.WriteLine(p1.x);    //0
            //Console.WriteLine(p1.y);    //0
            //Point p2 = new Point() { x = 5, y = 10 };
            //Console.WriteLine("After Initilize P2");
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            //p2 = p1;  // so Now the P1 Have 2 References //and the p2 will be UnReachable Object
            //Console.WriteLine("After Assisgn P2 to P1");
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);


            //Console.WriteLine(default(char));
            #endregion
            #endregion

        }//done part 07 Application Memory


    }
}
