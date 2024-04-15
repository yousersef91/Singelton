using System;
using System.Collections.Generic;
using System.Text;

namespace TestSingelton
{
    class Class1
    {
        private static int counter;
        public Class1()
        {
            counter += 1;
            Console.WriteLine(" Instance Number " + counter.ToString());
        }

      public void print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
