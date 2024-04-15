using System;
using System.Collections.Generic;
using System.Text;

namespace TestSingelton
{
   sealed class Class1
    {
        //TEST
        private static int counter;
        private static Class1 instance = null;
        private static Object obj = new Object();
        private Class1()
        {
            counter += 1;
            Console.WriteLine(" Instance Number " + counter.ToString());
        }

        public static Class1 getInstance()
        {
            if (instance == null)
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Class1();
                    }
                }
            return instance;
        }
      public void print(string msg)
        {
            Console.WriteLine(msg);
        }

       
    }
}
