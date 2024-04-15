using System;

namespace TestSingelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.print("Yousef");

            Class1 c2 = new Class1();
            c2.print("Bahboh");

        }
    }
}
