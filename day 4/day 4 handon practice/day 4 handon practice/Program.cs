using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_handon_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size"); 
            int[] ar = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());   
            }
            for(int i = 0; i < ar.Length;i++)
            {
                Console.WriteLine(ar[i]);
            }

            // reverse array
            reverse_array_program ra = new reverse_array_program();
            ra.reversearray();

            //copy array 
            Copy_Array_program cap = new Copy_Array_program();
            cap.ArrayToArray();
            Console.ReadLine();
        }
    }
    
}
