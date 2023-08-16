using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerTwo
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int[] someArray = { 3, 7, 1, 14, 25 };
            //creates a fixed pointer for tg=he values in the array 
            //normally handled at runtime
            //their memory addresses can change --> esp due to GC
            //ensures the memory location remains constant 
            //only during the execution of this block of code

            fixed (int* pointerA = someArray)
                // *(pointerAb + i)
                //pointerA + i calcs the memory address of the element i
                //then * de-references that address to obtain the actual value 

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Values[{0}] = {1}", i, *(pointerA + i));
                    Console.WriteLine("Values[{0}] = {1}", i, (int)(pointerA + i));

                }
            Console.ReadLine();
        }
    }
}
