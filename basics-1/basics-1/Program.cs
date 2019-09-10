using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

// FROM: https://www.youtube.com/watch?v=0p0JLFZj2C8&list=PLGLfVvz_LVvRX6xK1oi0reKci6ignjdSa&index=1

// namespaces are used to define globally unique objects.
// this is useful when combining code, because even if your classes use the same names,
// the namespaces keep it unique.

// the Main function is where all the code begins (similar to Java).

// a static function belongs to the class, it can be executed without creating an object.
// void means a function doesn't return a value.

// to put cmd-line arguments into the Main function on start in VS, go into the solution explorer, right click the project,
// go into properties, in debug, add the args in the command line arguments box using spaces to seperate them.

namespace basics_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // basic HelloWorld example.
            // Console.Write doesn't put a line after, Console.WriteLine does put a line after.
            Console.WriteLine("Hello World");


            // for loop, extreemly similar to Java.
            for(int i = 0; i < args.Length; i++)
            {
                // string formatting example, i replaces {0}, and args[i] replaces {1}.
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }


            // string array creation, then assignment to the cmd-line args.
            string[] myArgs = Environment.GetCommandLineArgs();
            // Join takes two args, the string to join with, and the array of items to join together.
            Console.WriteLine(string.Join(", ", myArgs));


            // function call
            SayHello();


            // DataTypes
            // use of DataTypes is very important, they can effect system memory usage, efficiency, along with many other things.

            // booleans, can only equal true or false.
            bool canIVote = true;

            // integers, represent 32bit integers.
            int myAge = 20;
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            // Biggest Integer : 2147483647
            // Smallest Integer : -2147483648

            // longs, represent 64bit integers.
            long myLongAge = 20;
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);
            // Biggest Long : 9223372036854775807
            // Smallest Long : -9223372036854775808

            // decimals, represent 128bit percise decimal values. decimals are accurate to 28 digits.
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : Pi + BigNum = {0}", decPiVal + decBigNum);
            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);
            // Biggest Decimal : 79228162514264337593543950335
            // Smallest Decimal : -79228162514264337593543950335

            // doubles, represent 64bit floating type. 
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : Pi + BigNum = {0}", dblPiVal + dblBigNum);
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", Double.MinValue.ToString("#"));
            // Biggest Double : 179769313486232000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            // Smallest Double : -179769313486232000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000

            // floats, 32bit floating point number, half as accurate as double.
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : Pi + BigNum = {0}", fltPiVal + fltBigNum);
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Float : {0}", float.MinValue.ToString("#"));
            // Biggest Float : 340282300000000000000000000000000000000
            // Smallest Float : -340282300000000000000000000000000000000

            // other DataTypes
            // byte : 8bit unassigned int 0 to 255.
            // char : 16bit unicode character.
            // sbyte : 8bit signed int 128 to 127.
            // short : 16bit signed int -32768 to 32767.
            // uint : 32bit unsigned int 0 to 4294967295.
            // ulong : 64bit unsigned int 0 to 18446744073709551615.
            // ushort : 16bit unsigned int 0 to 65535.

            // DateTime
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of week : {0}", awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(1);
            awesomeDate = awesomeDate.AddMonths(2);
            Console.WriteLine("New date : {0}", awesomeDate.Date);

            // TimeSpan
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New time : {0}", lunchTime.ToString());

            // big integers
            // to use in VS, go to project in the top bar, then go to Add Reference,
            // once there go to Assemblies > Frameworks, and add a check next to System.Numerics, click ok,
            // and finally add it up top as 'using System.Numerics;'
            BigInteger bigNum = BigInteger.Parse("12345");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);

            // strings
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String Contain 'is' : {0}", randString.Contains("is"));
            Console.WriteLine("String Index of 'is' : {0}", randString.IndexOf("is"));
            // start at 0 index and remove 6 chars
            Console.WriteLine("Remove String : {0}", randString.Remove(0, 6));
            // at the 10th index, add 'short '
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));
            // replace 'string' with 'sentence'
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));
            // -1- : string 1 procedes string 2
            // 0 : strings are equal
            // 1+ : string 2 procedes string 1
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Compare A to a : {0}", String.Compare("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Compare A to B : {0}", String.Compare("B", "A", StringComparison.OrdinalIgnoreCase));
            // padding for int length with string
            Console.WriteLine("String Pad Left : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("String Pad Right : {0}", randString.PadRight(20, '.'));
            // removes whitespace on either side
            Console.WriteLine("String Trim : {0}", randString.Trim());
            Console.WriteLine("String Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("String Lowercase : {0}", randString.ToLower());

            string newString = String.Format("{0} saw a {1} {2} in the {3}, {0} said \"wow\"", "Paul", "rabbit", "eating", "field");
            Console.WriteLine(newString);

            Console.WriteLine(@"Exactly what I typed : ' \");


            // formatting options
            // Control / Type / Description / Example
            // C / Currency / Displays number prefixed with the currency simple appropriate to the current locale / {0:C} of 432.00 outputs $432.00
            // D / Decimal / Displays number in decimal form with optional padding / {0:D4} of 432 outputs 00432
            // E / Exponential / Displays number in scientific form with optional value for fractional part / {0:E5} of 432.32 outputs 4.32320E+002
            // E / Fixed / Displays the number including the specified number of decimal digits / {0:F3} of 432.324343 outputs 432.324
            // N / Number / Converts a number to a human friendly format by inserting commas and rounding to the nearest 100th / {0:N} of 123432.324343 outputs 123,432.32
            // X / Hexadecimal Converts a number to hexadecimal / {0:X} of 432 outputs 1B0
            // 0:0... / Zero Padding / Adds zeros to pad argument / {0:0000.00} of 43.1 outputs 0043.10
            // 0:0#... / Space Padding/	Adds spaces to pad argument	/ {0:####.##} of 43.1 outputs 43.1
            // % / Percentage / Multiplies the argument by 100 and appends a percentage sign / {0:00.00%} of .432 outputs 43.20 %
            // more: https://www.techotopia.com/index.php/Formatting_Strings_in_C_Sharp
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas : {0:n4}", 2300);
            // Currency : $23.46
            // Pad with 0s: 0023
            // 3 Decimals: 23.456
            // Commas: 2,300.0000


            // converting strings to other DataTypes
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");


            // trick to keep the console open, ask for input.
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }

        // SayHello function, takes name input and says hello.
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

    }
}
