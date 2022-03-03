/* Write a program that allows the user to enter any number of names, last name first. 
 * Using one of the predefined methods of the Array class, order the names in ascending order. 
 * Display the results
*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine(" Enter an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[num];

            for ( int i=0; i< num; i++)
            {
                Console.WriteLine(" Enter last name, and first name: (separate by comma)" );
                name[i] = Console.ReadLine(); 
            }

            Array.Sort(name);

            Console.WriteLine("-------------------------");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name[i]);
            }
            
        }
    }
}
