using System;

namespace Lesson11_4
{

    class Program
    {
        static void Run()
        {
            Console.WriteLine("Run");
            // code

            if (false) 
                throw new ArgumentNullException("exception occured. Run");
        }


        static void DoSomething()
        {
            Console.WriteLine("DoSomething");
            // code

            if (true) 
                throw new FormatException("exception occured. DoSomething");
        }


        static void ExceptionHandling(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main()
        {
            // Action action = Run;
            // action += DoSomething;

            // ExceptionHandling(action);


            //ExceptionHandling(Run);
            ExceptionHandling(DoSomething);

            Console.WriteLine("To be continue");
        }
    }
}