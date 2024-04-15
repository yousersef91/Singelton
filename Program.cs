using System;
using System.Threading.Tasks;

namespace TestSingelton
{
    class Program
    {
        static void Main(string[] args)
        {

         
            Class1 c = Class1.getInstance();
            c.print("Yousef");

        

        }
      

    }
}
