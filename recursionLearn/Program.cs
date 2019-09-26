using System;

namespace recursionLearn
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));

        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            // recursive solution (as opposed to iterative)
            return n * Factorial(n - 1);

            /* Recursion is when a method calls itself within the scope of the method,
             * above you can see that we pass through an integer 'n' to the method from
             * the main method. However, using the if/else statement we can create a simpler
             * form of looping the method by calling itself with a number that decreases by
             * one each time it is called until the number being passed through is equal to 0.
             */

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)
        }
    }
}
