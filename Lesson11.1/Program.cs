using System;

namespace Lesson11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action1 = Method1;
            // action1.Invoke();
            //// or
            // action1();


            Action<string, int> action2 = null;
            action2 += Method2;
            action2 += Method3;

            // action2.Invoke("Akif");
            //// or
            // action2("Akif", 5);





            // Predicate<string> predicate1 = s => s.Contains("e");
            // Predicate<string> predicate2 = Method4;
            // Predicate<string> predicate3 = delegate (string str) { return str.Length > 3; };
            // 
            // Foo(predicate1);
            // Foo(predicate2);
            // Foo(predicate3);



            // Func<int> func1 = Method5;
            // // Console.WriteLine(func1());
            // 
            // 
            // Func<int, int, int> func2 = Add;
            // Console.WriteLine(func2(5, 7));

        }



        static void Foo(Predicate<string> predicate)
        {
           Console.WriteLine(predicate("Hi"));
        }


        static void Method1() { Console.WriteLine("Method1"); }
        static void Method2(string str, int a) { Console.WriteLine(str); }
        static void Method3(string str, int a) { Console.WriteLine(str); }
        static bool Method4(string str) { return true; }
        static int Method5() { return 5; }
        static int Add(int a, int b) { return a + b; }
    }
}