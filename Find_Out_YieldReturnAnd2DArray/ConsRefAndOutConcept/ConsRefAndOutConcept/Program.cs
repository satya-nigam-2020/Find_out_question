using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsRefAndOutConcept
{
    // Both ref and out keywords can be passed
    // as parameters to any method

    class RefAndOut
    {
        public static int Test(ref int x) // Here x is now reference type
        {
            return x = x * x;
        }
        public static int Test1(int x)
        {
            return x = x * x;
        }
        public static int Test3(out int x) // out keyword is also passed by reference
        {
            x = 10;
            return x = x * x;
        }
        public static int Test4(in int x) // out keyword is also passed by reference
        {
          //  x = 10;
            return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int outVal = 2;
      
            Console.WriteLine("Final Value without ref :" + RefAndOut.Test1(22));
            Console.WriteLine("Final Value with out :" + RefAndOut.Test3(out outVal));
            Console.WriteLine("Final Value with in : " + RefAndOut.Test4(10));
          
            
            int age = 10;
           int res = RefAndOut.Test(ref age);
            Console.WriteLine($"Final Output : {res}");
            Console.WriteLine("Final Output : "+res);
            Console.ReadLine();

            //ref keyword passes arguments by reference. This means
            //any changes made to this argument or parameter in the method 
            //will be reflected in the variable of the calling method
        }
    }
}
