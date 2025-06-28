using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {

        class book
        {
            public string Title;
            public string printTitle()
            {
                Console.WriteLine($"title is: {Title}");
                return this.Title;
            }
        }
        static void Main()
        {

            #region 1.Read&writeNumber
            ///int num;
            ///bool isParsed;
            ///
            ///do
            ///{
            ///     Console.Write("Enter The Number: "); 
            ///     isParsed = int32.TryParse(Console.ReadLine(), out  num); 
            ///    if (!isParsed) 
            ///    {
            ///        Console.WriteLine("Not Vaild Number Please Try Again");
            ///    }
            ///}
            ///while (!isParsed);
            ///Console.WriteLine($"your Number is: {num}"); 
            #endregion

            #region 2.Enter String Contains non-numaric 
            ///int Num;
            ///bool IsParsed;
            ///
            ///do
            ///{
            ///    //In the first try to enter the number 
            ///    Console.Write("Enter Numaric Number: ");
            ///    string Text = Console.ReadLine();
            ///    IsParsed = Int32.TryParse(Text, out Num);
            ///    //then if the text Contains non-Numaric so it will return false
            ///    //and tell user to try agian
            ///    if (!IsParsed)
            ///    {
            ///        Console.WriteLine("That Contains Non-Numaric Characters. Please try Again");
            ///    }
            ///}
            ///while (!IsParsed);
            ///Console.WriteLine($"Thanks Your Number is: {Num}");
            #endregion

            #region 3.simple arithmetic operation with floating-point numbers
            /////In the First when we declare any floating point number 
            /////it well be see as double type so that the reason of
            /////why we write the letters like F for Float or M for decimal
            ///double Y = 203.3;
            ///float X = 10.33f;
            ///decimal Z = 0;
            ///Z = (decimal)Y * (decimal)X;// Here to assign double and float for decimal,
            ///                            // i should make an implicit cast [Safe Casting]
            ///// but when i try to do the opposite
            ///X = (float)Z - (float)Y; // that name Explicit Cast [Unsafe Casting]
            ///                        // becouse it may be make lose for data or wrong data
            #endregion

            #region 4.Extract a substring from a given string.
            //Console.Write("Enter the Text: ");
            //string Pharse = Console.ReadLine();
            //int StartIndex;
            //bool IsParsed;
            //do
            //{
            //    Console.Write("Enter the Start index of Charcter you want to Exract From: ");
            //    IsParsed = Int32.TryParse(Console.ReadLine(), out StartIndex);
            //    if (!IsParsed)
            //    {
            //        Console.WriteLine("That Contains Non-Numaric Characters. Please try Again");
            //    }
            //}
            //while (!IsParsed);
            //Console.WriteLine("================");
            //Console.WriteLine(Pharse.Substring(StartIndex));
            #endregion

            #region 5.Assigning value type variable to another & modifying
            ////Declar 2 Value type Variable so that saved in STACK
            ////Each of this Variable have the value and address(ref) =>
            ////                               The both it will be saved in STACK
            //int x = 10;
            //int y = 20;
            ////Assigning value x to value y 
            //y = x;
            //Console.WriteLine(y); // 10
            //x = 50; // when i change in x the why will not effected
            //Console.WriteLine(y); // so it still = 10 
            #endregion

            #region 6.Assigning Reference type variable to another & modifying
            #region with objects or any reference type
            ////Declar 2 Reference type Variable 
            //book a = new book();
            //a.Title = "habits";
            //a.printTitle();
            //book b = new book();
            //b.Title = "algorithms";
            //b.printTitle();
            ////Each of this Variable have the value and address(ref) =>
            ////Once i Declar the Variable the value it will be saved in HEAP and
            ////the Reference or address of this value it will be Saved in STACK
            //b = a;
            ////When i assgin ref type to another, both references point to the same object in HEAP or same HEAP address
            ////and not make a copy like in Value type, that ref to the same object
            //b.printTitle(); // habits
            //a.Title = "test rather than habit";
            ////so now when i change in object A it will be also changed in object B
            //b.printTitle(); //test rather than habit 
            #endregion

            #region with string
            ////Declar 2 Reference type Variable 
            //string bookA = "Atomic Habits";
            //string bookB = "Grokking Algorithms";
            ////Each of this Variable have the value and address(ref) =>
            ////Once i Declar the Variable the value it will be saved in HEAP and
            ////the Reference or address of this value it will be Saved in STACK
            //bookB = bookA;
            ////When i assgin ref type to another, both references point to the same string in HEAP or same HEAP address
            ////and not make a copy like in Value type, that ref to the same string
            //Console.WriteLine(bookB); // Atomic Habits
            //bookA = "Hamada Book";
            ////so now when i change in string A it will be also changed in string B, But this did not happen with the String.
            ////Strings in C# are immutable, meaning their value can’t change once created.
            ////When you "change" a string, you’re actually creating a new object. So reassigning bookA doesn’t affect bookB
            //Console.WriteLine(bookB); // Atomic Habits
            #endregion
            #endregion

            #region 7.two string variables as one variable 
            //Console.WriteLine("Enter string 1");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Enter string 2");
            //string str2 = Console.ReadLine();
            //string str = string.Concat(str1, " ", str2);
            //Console.WriteLine(str);
            #endregion

            #region 8.Calculates the simple Interest
            //Console.WriteLine("-----------------Calculates the simple Interest-----------------\n\n\n");
            //Console.WriteLine("Please Enter the Principal Amount");
            //decimal PreinCipalAmount = Convert.ToDecimal( Console.ReadLine());
            //Console.WriteLine("Please Enter the Rate Of Interest");
            //double Rate = Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine("Please Enter the time");
            //float Time = Convert.ToSingle(Console.ReadLine());
            /////why not to ToFloat the reasone is the float is C# key word but in Convert Class At .NET it Single
            //decimal Interest = (PreinCipalAmount * (Decimal)Rate * (Decimal)Time) / 100;
            ////Console.Clear();
            //Console.WriteLine($"Your Interest is: {Interest}");
            #endregion

            #region 9.calculates the Body Mass Index (BMI)
            //Console.WriteLine("-----------------calculates the Body Mass Index (BMI)-----------------\n\n\n");
            //Console.WriteLine("Please Enter Your Perons's Weight in Kilograms");
            //float Weight = float.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Your Perons's height in meters");
            //float Height = float.Parse(Console.ReadLine()) ;

            //float BMI = (Weight) / (Height * Height);
            ////Console.Clear();
            //Console.WriteLine($"Your BMI is: {BMI}");
            #endregion

            #region 10.Check For Temperature
            //Console.WriteLine("-----------------Check For Temperature-----------------\n\n\n");
            //Console.WriteLine("What The Degrees Now??!");
            //int Degree = int.Parse(Console.ReadLine());
            //string Result = Degree < 10 ? "Just Cold": Degree > 30 ? "Just Hot":"Just Good";
            ////Console.Clear();
            //Console.WriteLine($"The Result is: {Result}");
            #endregion

            #region 11.Displays The Date In various Formats Using String Interpolation
            //Console.WriteLine("-----------------Displays The Date In various Formats Using String Interpolation-----------------\n\n\n");
            //Console.WriteLine("Please Enter The Day: ");
            //int Day = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n\nPlease Enter The Month: ");
            //int Month = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n\nPlease Enter The Month: ");
            //int Year = int.Parse(Console.ReadLine());
            //DateOnly dateOnly = new DateOnly(Year, Month, Day);

            //Console.WriteLine($"\nToday's Date is: {dateOnly:dd,MM,yyyy}");
            //Console.WriteLine($"\nToday's Date is: {dateOnly:dd/MM/yyyy}");
            //Console.WriteLine($"\nToday's Date is: {dateOnly:dd-MM-yyyy}");
            #endregion

            #region 12.output of the following C# code
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            // The Output is: c) The event is on 06/14/2024
            #endregion

            #region 13.output of the following C#.NET code
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //  Imlicit Convert from bo;

            // The Correct Statement is:  f) A value 1 will be assigned to d
            #endregion

            #region 14.output of the following C# code
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            // Expect      =>    6.5   +     +  1
            // but it will be  => 6    +     +  1
            // Why => Actually, the '/' operator is a function, so it takes two int values,
            // so it should return an int value, but if a double is given, it will return the fractions.

            // The Correct Output is:  d) 6 1
            #endregion

            #region 15.output of the following C# code
            //int num = 1, z = 5;

            //if (!(num <= 0)) //True
            //    Console.WriteLine(++num + z++ + " " + ++z);
            ////                      2   + 5   +     +  7
            ////                       7                7     
            //else
            //   Console.WriteLine(--num + z-- + " " + --z);

            // The Correct Output is: d) 7 7
            #endregion
            
        }
    }
}

