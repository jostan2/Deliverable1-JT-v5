using System;

namespace Deliverable1
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {

                int people;

                decimal breadslice;
                decimal breadloaf;
                int breadloaf2;

                decimal pbtbs;
                decimal pbjar;
                int pbjar2;

                decimal jellytsp;
                decimal jellyjar;
                int jellyjar2;


                Console.Write("How many people are we making PB&J sandwiches for? ");
                people = Convert.ToInt32(Console.ReadLine());

                breadslice = people * 2;
                breadloaf = breadslice / 28;
                breadloaf2 = (int)Math.Ceiling(breadloaf);


                pbtbs = people * 2;
                pbjar = pbtbs / 32;
                pbjar2 = (int)Math.Ceiling(pbjar);

                jellytsp = people * 4;
                jellyjar = jellytsp / 48;
                jellyjar2 = (int)Math.Ceiling(jellyjar);

                //Print a blank line
                Console.WriteLine();


                //Show the details that the user entered

                Console.WriteLine("You need {0} slices of bread.", +breadslice);
                Console.WriteLine();

                Console.WriteLine("That is {0} loaf/loaves of bread.", +breadloaf2);
                Console.WriteLine();


                Console.WriteLine("You need {0} tablespoons of peanut butter.", +pbtbs);
                Console.WriteLine();

                Console.WriteLine("That is {0} jar/jars of peanutbutter.", +pbjar2);
                Console.WriteLine();


                Console.WriteLine("You need {0} teaspoons of jelly.", +jellytsp);
                Console.WriteLine();

                Console.WriteLine("That is {0} jar/jars of jelly.", +jellyjar2);
                Console.WriteLine();


                //Print a blank line
                Console.WriteLine();


                Console.Write("Do you want to restart the program? (Y/N)?: ");
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine("\n");


                while ((result.KeyChar == 'Y') || (result.KeyChar == 'y') || (result.KeyChar == 'N') || (result.KeyChar == 'n'))
                {
                    if ((result.KeyChar == 'Y') || (result.KeyChar == 'y'))
                    {
                        Console.WriteLine("Restarting!");
                        break;
                    }
                    else if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                    {
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                    }
                }



            }


        }
    }
}
