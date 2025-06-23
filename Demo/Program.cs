using System;
using System.Runtime.CompilerServices;

namespace Demo
{
    class Program
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

            #region Objects
            #region Part 01
            //Objects Parent for all in C#
            //The Resons for existence of the object:-

            //1.Genaric
            //Point3D point3D1 = new Point3D();
            //point3D1.printGenaric<int>(544454);
            //point3D1.printGenaric<string>("Genaric Parameter");
            //point3D1.printGenaric<bool>(true);
            //point3D1.printObj(544454);
            //point3D1.printObj("Genaric Parameter");
            //point3D1.printObj(true);
            //if simple and you write safte type use Object but any of those use Genaric to avoid the boxs behaviors and to be type safty

            //2.Methods
            //Point p1 = new Point() { x = 4, y = 6 };
            //Point p2 = new Point() { x = 4, y = 6 };
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1.GetType());  //returns  "Demo.Point"
            //Point3D p3 = new Point3D() { x = 4, y = 6 };
            //Point3D p4 = new Point3D() { x = 4, y = 6 };
            //Console.WriteLine(p3.GetHashCode());
            //Console.WriteLine(p4.GetHashCode()); 
            #endregion
            #region Part 02
            //object obj;
            //// Declare for Reference of type "Object" , Refering to the Defult Value of Refernece Type = NULL
            //// This Reference 'Object' Can Refer to an Instance from type "Object" Or to Any Type.
            //// CLR Will Allocate 4 UnInitilaized Bytes in STack For the Reference "Object".
            //// CLR Will Allocate 0 Bytes in HEAP

            //obj = new object();
            //obj = new string("Hamada");
            //obj = "Hamada";//syntax sugre

            //    //All of this Struct so it Saved in STACK so
            //    //How this Value Type Saved in HEAP to get his Address and Pass the references to "Obj"?
            //    // so it happend the => Boxing
            //obj = 10;                   //Boxing
            //obj = 5.5;                  //Boxing
            //obj = true;                 //Boxing
            //obj = new DateTime();       //Boxing
            //obj = new DateOnly();       //Boxing
            //obj = new TimeOnly();       //Boxing

            //obj = 11;                   //Boxing
            //int Number = (int) obj;     //UnBoxing
            //Console.WriteLine(Number);

            //obj = new string("Ahmed");
            //obj = new Point();
            ////Parent = Child  
            ////Animal = Dog    
            #endregion
            #endregion

            #region Fractions and Discard
            //float x = 10.5F;
            //double y = 10.5;
            //decimal z = 10.5m;

            //// Discard
            //long Number = 100_000_000_000;
            //Console.WriteLine($"{Number:c}"); 
            #endregion

            #region Implicit Casting vs Explicit Casting
            #region Example 01
            ///int x = 10;
            ///long Y = x;
            ///Console.WriteLine(Y);

            //UnSafe Casting
            //long x = 100000000000000000;
            //checked
            //{
            //    int y = x.GetType() == typeof(int) ? (int)x : 0;
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //} 
            #endregion

            #region Example 02
            ///int x = 10;
            ///double y = (double)x;//1. implicit Catsing [Safe Casting]
            ///Console.WriteLine(y);

            ///double x = 5.5;
            ///int y = (int) x; //2. Explicit Casting [UnSafe Casting]
            ///Console.WriteLine(y); 
            #endregion

            #endregion

            #region Convert Vs Parse Vs TryParse
            //Convert: [is a Class Containing a set of Methods Used For Casting from Datatype to Another]
            #region Convert
            ///Console.Write("Please Enter your Name:");
            ///string? Name = Console.ReadLine();
            ///
            ///Console.Write("Please Enter your Age:");
            ///int Age = Convert.ToInt32(Console.ReadLine());
            ///
            ///Console.Write("Please Enter your Salary:");
            ///decimal Salary = Convert.ToDecimal(Console.ReadLine());
            ///Console.Clear();
            /////Console.Beep(1,1);
            ///Console.WriteLine($"Your Name is {Name}");
            ///Console.WriteLine($"Your Age is {Age}");
            ///Console.WriteLine($"Your Salary is {Salary}");  
            #endregion

            //Parse: [is a Method Used for Casting from String to the Caller Datatype.]

            #region Parse
            ///Console.Write("Please Enter your Name:");
            ///string? Name = Console.ReadLine();
            ///
            ///Console.Write("Please Enter your Age:");
            ///int Age =int.Parse(Console.ReadLine() ?? "0");
            ///
            ///Console.Write("Please Enter your Salary:");
            ///decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");
            ///Console.Clear();
            /////Console.Beep(1,1);
            ///Console.WriteLine($"Your Name is {Name}");
            ///Console.WriteLine($"Your Age is {Age}");
            ///Console.WriteLine($"Your Salary is {Salary:c}");  
            #endregion

            // Tryparse : [Method is a safe alternative to Parse , Convert a string to a specified type
            //             and returns a boolean indicating success or failure.
            //             It does not throw exceptions. ]
            #region TryParse

            ///string x = "true";
            ///string x = "hamada";
            ///bool y = bool.Parse(x);
            ///Console.WriteLine(y);

            ///string x = "43l";
            ///
            ///int y;
            ///
            ///bool isParsed = int.TryParse(x, out y); // No Execption will be Thrown
            ///Console.WriteLine(isParsed);            
            ///Console.WriteLine(y);

            ////Console.Write("Please Enter your Name:");
            ////string? Name = Console.ReadLine();
            ////
            ////Console.Write("Please Enter your Age:");
            ////int Age;
            ////int.TryParse(Console.ReadLine() , out  Age);
            ////
            ////Console.Write("Please Enter your Salary:");
            //////decimal Salary;
            ////decimal.TryParse(Console.ReadLine(), out decimal Salary);
            ////
            ////Console.Clear();
            //////Console.Beep(1,1);
            ////Console.WriteLine($"Your Name is {Name}");
            ////Console.WriteLine($"Your Age is {Age}");
            ////Console.WriteLine($"Your Salary is {Salary:c}"); 

            #endregion
            #endregion

            #region Operators

            #region Unary Operators

            // Unary Operators => Work on one Operand (Variable)
            //int x = 10;

            ////1. ++

            //// 1.1 PreFix [Increment and then Print]
            //Console.WriteLine(++x); // print 11
            //// 1.2 PostFix [Print and then Increment]
            //Console.WriteLine(x++); // print 10

            ////2. ++

            //// 2.1 PreFix [Decrement and then Print]
            //Console.WriteLine(--x); // print 9
            //// 2.2 PostFix [Print and then Decrement]
            //Console.WriteLine(x--); // print 10


            #endregion

            #region Binary Operators
            //int Sum, Mul, Div, Sub, Mod;
            //int Num01 = 2, Num02 = 6;

            //Sum = Num01 + Num02;
            //Sub = Num01 - Num02;
            //Mul = Num01 * Num02;
            //Div = Num01 / Num02;
            //Mod = Num01 % Num02;
            #endregion

            #region Assignment Operators
            //int x;
            //x = 4;
            //x += 2; // x = x + 2
            //x -= 2; // x = x - 2
            //x *= 2; // x = x * 2
            //x /= 2; // x = x / 2
            //x %= 2; // x = x % 2
            #endregion

            #region Relational Operators
            // int x = 9, y =5;

            #endregion

            #region Logical Operators
            //Console.WriteLine(!false);
            //Console.WriteLine(false && true); // Short Circuit
            //Console.WriteLine(true || false); // Short Circuit
            #endregion

            #region Bitwise Operators
            //Console.WriteLine(~0);
            //Console.WriteLine(false & true); // Long Circuit
            //                //0000  & 0001 = 0000
            //Console.WriteLine(true | false); // Short Circuit
            #endregion

            #region Ternry Operators [Conditional Oprator]
            //int X = 10, Y = 5;
            //string Message = X > Y ? "X is More Than Y" : X < Y? "X is Less Than Y" : "X equals Y";
            //Console.WriteLine(Message);
            #endregion

            #endregion

            #region Operators Priorty [Precedence] and Asscoitivity 
            // Asscoitivity => if i have 2 Operators have ths same Priorty so it is Implemented From Left to Right
            /*
                1. Unary Operators (PreFix)
                2. Round Braces ()
                3. * / %
                4. + -
            */

            int Equation = 4 + 3 * 8;
            Console.WriteLine(Equation); //28
            #endregion
            
            #region String Formatting

            //// Equation: 3 + 4 = 8
            //
            //int X = 3 , Y = 4;
            //
            //string Message = "Equation: " + X + " + " + Y + " = " + (X + Y); ///Not the Best
            //
            //// 1. Composite String
            //
            //Message = string.Format("Equation: {0} + {1} = {2}", X, Y, (X + Y));
            //
            //// 2. String Interpolation
            //// $ : Manpulation Operator
            //
            //Message = $"Equation: {X} + {Y} = {X + Y}";
            //
            //Console.WriteLine(Message);


            #endregion

        }
    }
}
