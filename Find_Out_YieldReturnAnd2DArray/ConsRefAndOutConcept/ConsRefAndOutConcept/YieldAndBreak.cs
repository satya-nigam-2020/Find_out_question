using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsRefAndOutConcept
{
    class YieldAndBreak
    {
        public static IEnumerable<string> GetMyList()
        {
            
            List<string> my_list = new List<string>() {
                     "Cat", "Goat", "Dog", "Cow" };


            
            foreach (var items in my_list)
            {
             
                yield return items;

                if(items =="Dog")
                {
                    yield break;
                }
            }
        }

        static public void Main()
        {
 
            IEnumerable<string> my_slist = GetMyList();

            foreach (var i in my_slist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
