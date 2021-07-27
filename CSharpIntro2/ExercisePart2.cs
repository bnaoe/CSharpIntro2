using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpIntro;

namespace CSharpIntro2
{
    class ExercisePart2
    {
        public static void Ex11()
        {
            //Description: The logic asks the user to input a set of numbers separated by commas,
            //then reverses the order by descending order and separates numbers by hyphen.

            Console.WriteLine("Please enter a set of numbers separated by comma ','");
            var input = Console.ReadLine();

            Console.WriteLine(LogicFunctions.ReverseNumbers(input));
        }

        public static void Ex12()
        {
            //Description: A program that asks a user to input a set of numbers and displays the duplicates 

            ; Console.WriteLine("Please enter a set of numbers separated by comma ',' (or enter to exit)");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var dupNums = new List<int>();

            dupNums = LogicFunctions.DisplayDuplicates(input);

            Console.WriteLine("Duplicate numbers are: ");

            foreach (var n in dupNums)
            {
                Console.WriteLine(n);
            }
        }

        public static void Ex13()
        {
            //Description: The logic asks the user to enter time in a 24- hour format.
            //Then checks whether the format is correct or not and displays "ok" if it is.

            Console.Write("Enter time in 24-hour time format (e.g. 19:00) : ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time format, please try again");
                return;
            }

            var chars = input.Split(':');
            if (chars.Length != 2)
            {
                Console.WriteLine("Invalid time format, must be two digits for the hour and minutes");
                return;
            }

            LogicFunctions.ValidateTimeFormat(chars);
        }

        public static void Ex14()
        {
            //Description: Logic asks user to enter a set of words and returns the set of words
            //without spaces in pascal format (e.g. PascalFormat)

            Console.WriteLine("Please input a set of words separated by spaces.");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            Console.WriteLine(LogicFunctions.CovertToPascal(input));
        }

        public static void Ex15()
        {
            //Description: Program asks to enter a single word and counts the
            //number of vowels found in that word.

            Console.WriteLine("Please enter an english word");
            var input = Console.ReadLine();

            Console.WriteLine("Number of vowels are {0}", LogicFunctions.CountVowels(input));

        }

        public static void Ex16()
        {
            var path = @"c:\temp\Desiderata.txt";

            Console.WriteLine("The number of words in {0} is {1}", path, LogicFunctions.CountWordsFromFile(path).Count());
        }



        static void Main(string[] args)
        {

            //========= These are my own solutions to the C# Intro exercises. ===========//
            //========= Uncomment method calls to run the exercises. ===========//

            Ex11();
            //Ex12();
            //Ex13();
            //Ex14();
            //Ex15();
            //Ex16();
        }
    }
}
