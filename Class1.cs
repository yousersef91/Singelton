using System;
using System.Collections.Generic;
using System.Text;

namespace TestSingelton
{
    class Class1
    {
        private static int counter;
        private static Class1 instance = null;

        private Class1()
        {
            counter += 1;
            Console.WriteLine(" Instance Number " + counter.ToString());
        }

        public static Class1 getInstance()
        {
            if(instance==null)
            {
                instance = new Class1();
            }
            return instance;
        }
      public void print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
