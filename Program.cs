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

            Class1.son sn = new Class1.son();
            sn.print("Bahboh");

        }
      

    }
}
