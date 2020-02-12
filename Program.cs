using System;

namespace C_Sharp_Exercises_4
{
    class Program
    {
        static void Main(string[] args)         // void is listed because the main method is not pulling any data back
        {
            string input = GetInput();          // stores your intial input
            input = AddingSmileyAtEnd ( input );    // 
            input = AddingSmileyAtStart ( input );  //
            Console.WriteLine( input ); // complies the 

            Console.WriteLine("Please enter your name: "); // good idea to ask a user so they what you wnat:p
            string myname  = Console.ReadLine();  // Stores their input, or it will be lost forver >.<
            Console.WriteLine(":( " + myname + " :)");
        }

        static string GetInput()                // string data is being returned
        {
            Console.WriteLine( "Please input some text: ");
            return Console.ReadLine();          // returns the input
        }
        static string AddingSmileyAtStart( string input)  // is returning a string 
        {
            input = ":) " + input;
            return input;
        }
        static string AddingSmileyAtEnd( string input)  // is returning a string 
        {
            input = input + " :(";
            return input;
        }
    }
}

