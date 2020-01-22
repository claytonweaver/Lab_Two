using System;

namespace Lab_Two
{

    class Program
    {
        static void Main(string[] args)
        {
            bool resume = true;

            while (resume == true)
            {
                Console.WriteLine("Find the area of a room!");

                Console.Write("Enter the length: ");

                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");

                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter the height: ");

                double height = double.Parse(Console.ReadLine());


                double area = length * width;

                double perimeter = 2 * (length + width);

                double volume = (area) * height;

                Console.WriteLine($"The length is {length}, the width is {width}, and the height is {height}. The area is {area}, the perimeter is {perimeter}, and the volume is {volume}.");

                Console.WriteLine("Would you like to continue? (Y/N)");

                char userInput = Console.ReadLine().ToUpper()[0];

                if (userInput == 'Y')
                {
                    resume = true;
                }
                else
                {
                    resume = false;
                }


                Console.WriteLine("Goodbye!");


            }

        }
    }
}
