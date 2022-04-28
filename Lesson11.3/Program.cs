using System;

namespace Lesson11_3
{
    class Program
    {
        static int value = 10;


        static void Outer(string name, int age)
        {

            static void printData(string name, int age)
            {
                Console.WriteLine($@"Name is {name}");
                Console.WriteLine($@"Age is {age}");
                Console.WriteLine($@"Static value {value}");
            }

            void displayData()
            {
                Console.WriteLine($@"Name is {name}");
                Console.WriteLine($@"Age is {age}");
                Console.WriteLine($@"Static value {value}");
            }

            displayData();
            printData(name, age);
        }


        static void Main()
        {
            Outer("Aga", 16);
        }
    }
}