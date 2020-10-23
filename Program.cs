using System;
using System.Dynamic;

namespace MethodsPractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hi what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is you favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Today is the day {name} has been waiting on all year! {name} woke up early to get ready and head to see his favorite band play {band}. He was in such a hurry to get to the concert he almost forgot to feed his pet {animal}! After feeding his {animal} he jumped in his {color} car and headed to the show. The {band} didnt disappoint and overall it was a great day!");

            static int Add(int y, int x)
            {
                Console.WriteLine($"We are going to add {x} and {y}");
                return y + x;

            }

            

            int result = Add(2, 4);
            Console.WriteLine(result);

            static int Add2(int x, int y, int z)
            {
                Console.WriteLine($"pick any 3 numbers to add together {x}, {y}, {z}");
                return x + y + z;
            }

            int result2 = Add2(2, 4, 6);
            Console.WriteLine(result2);

            static int add3( int x, int y, int z, int g, int b)
            {
                return x + y + z + g + b;
            }

            int result3 = add3(1, 1, 1, 1, 1);

        }
    }
}
