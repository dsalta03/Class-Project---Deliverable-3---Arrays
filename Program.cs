/*
    Author: Saltanat Degenbaeva
    Date: 9/9/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays without getting input from users. 
*/

using System;

namespace Class_Project___Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
                    // Here is the manually populated array
                    int[] array = new int [26];
                    
                    // Iterate through the array with a For Loop
                    for (int i = 1; i < array.Length; i++)
                    {
                    
                        Console.Write("Element Value = " + i + "\n");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
         
            
        }
    }
}
