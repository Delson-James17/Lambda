using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    delegate void  printEvenNumbers(int numbers);
     class Q5_EvenNumbers
    {
        static public void evenNumbers()
        {
            // Define the delegate and lambda expression
            printEvenNumbers printEven = numbers =>
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine(numbers);
                }
            };

            // Loop through numbers 1 to 100 and invoke the delegate for each number
            for (int i = 1; i <= 100; i++)
            {
                printEven(i);
            }

        }
    }
}
