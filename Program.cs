using System;

namespace TestSingelton
{
    class Program
    {
        static void Main(string[] args)
        {


            method1();
            method2();

        }
        public static void method1()
        {
            Class1 c = Class1.getInstance();
            c.print("Yousef");
        }
        public static void method2()
        {
            Class1 c2 =  Class1.getInstance();
            c2.print("Bahboh");
        }

    }
}
