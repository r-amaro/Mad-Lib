using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program is an MadLib where the answers will be inputted by the user.
      Author: Rafael Amaro
      */


            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to Mad Libs! \n");

            // Give the Mad Lib a title:
            string title = "\"The Day of a Lifetime\"";
            Console.WriteLine(title);

            // Define user input and variables (14):
            Console.Write("\nPlease Enter answers for the next 14 options! \n\n");
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string ad1 = Console.ReadLine();

            Console.Write("Enter a second adjective: ");
            string ad2 = Console.ReadLine();

            Console.Write("Enter a third adjective: ");
            string ad3 = Console.ReadLine();

            Console.Write("Enter a -ing verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();


            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {ad1}. 'It is going to be a {ad2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {ad3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine("\n" + story + "\n");
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
