using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        { 

            for(var counter = 1; counter < 100; counter++) 
            {
               var output = "";

               if(counter % 3 == 0)
               {
                   output += "Fizz";
               }

               if(counter % 5 == 0)
               { 
                   output += "Buzz";
               }
               
               if(output == "")
               {
                   Console.WriteLine(counter);
               }
               else
               {
                   Console.WriteLine(output);
               }
            }
            
        }
    }
}
