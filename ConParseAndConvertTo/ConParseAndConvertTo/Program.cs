using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConParseAndConvertTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string convertToInt = "12";
            string nullString = null;
            string maxValue = "3222222227777777777777777777";
            string formatException = "45.98";

            // Exporing Diff btw int.Parse And ConvertToInt

            //Let's first Understand int.Parse

            // It will perfectly convert interger
            Console.WriteLine("**********************int.Parse Examples*******************************");
            Console.WriteLine();
            Console.WriteLine(" int.Parse(convertToInt) : {0}", int.Parse(convertToInt));
            Console.WriteLine();

            try
            {
                // It will raise Argument Null Exception
                Console.WriteLine("int.Parse(nullString) : {0}", int.Parse(nullString));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                //It willl raise Over Flow Exception
                Console.WriteLine("int.Parse(maxValue) : {0}", int.Parse(maxValue));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                //It will raise Format Exception
                Console.WriteLine("int.Parse(formatException) : {0}", int.Parse(formatException));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            // Now let's understand ConvertToInt

            Console.WriteLine("**********************ConvertToInt Examples*******************************");
            Console.WriteLine();

            //It will perfectly convert integer
            Console.WriteLine("Convert.ToInt32(convertToInt) : {0}", Convert.ToInt32(convertToInt));
            Console.WriteLine();

            try
            {
                //It will ouput as 0 if Null string is there
                Console.WriteLine(" Convert.ToInt32(nullString) : {0}", Convert.ToInt32(nullString));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                //It will raise Over Flow Exception
                Console.WriteLine(" Convert.ToInt32(maxValue) : {0}", Convert.ToInt32(maxValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                //It will raise Format Exception
                Console.WriteLine(" Convert.ToInt32(formatException) : {0}", Convert.ToInt32(formatException));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();





            Console.ReadLine();
        }
    }
}
