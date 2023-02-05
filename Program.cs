using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Definition
            string[] colors = new string[5];

            string[] animals = { "Cat", "Dog", "Shark","Butterfly"};

            int[] arr;
            arr = new int[5];

            // Value Assignment and Access
            colors[0] = "Blue";
            arr[3] = 10;

            Console.WriteLine(arr[3]);
            Console.WriteLine(animals[2]);
            Console.WriteLine(colors[0]);

            // Using arrays with loops
            // Calculate the average of n numbers
            Console.WriteLine("Please enter the number of elements of the array!");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Please enter the {0}. number: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var num in numbers)
            
                sum += num;
            
            Console.WriteLine("Avarage: "+sum/arrLength);


        }
    }
}
