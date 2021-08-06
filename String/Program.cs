//Author: William Twomey
//Course: C# and .NET Framework - Part 1
//String Assignment

using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string greeting = "Hello ";
            string introduction = "my name is ";
            string name = "William";

            Console.WriteLine(greeting + introduction + name);

            // Concatenating three strings but using Upper method 
            string nameUpper = name.ToUpper();
            Console.WriteLine(greeting + introduction + nameUpper + " but in all \"caps\" now");

            // Enter to start next programme
            Console.WriteLine("\n\nPress ENTER to run the next programme");
            Console.Read();
            
            //Building a paragraph using the stringbuilder method
            StringBuilder myParagraph = new StringBuilder("For although a man is judged by his actions, ");
           

            myParagraph.Append("\nby what he has said and done, a man judges himself by what he is ");
            
            myParagraph.Append("\nwilling to do, by what he might have said, or might have done – a ");
            

            myParagraph.Append("\njudgment that is necessarily hampered, bot only by the scope and ");
            

            myParagraph.Append("\nlimits of his imagination, but by the ever-changing measure of his ");
            

            myParagraph.Append("\ndoubt and self-esteem.");
            Console.WriteLine(myParagraph);


        }
    }
}
