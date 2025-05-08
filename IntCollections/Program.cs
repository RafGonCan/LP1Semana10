using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int [] numbers = {1, 10, -30, 10, 5};

            List<int> listNumbers = new List<int> ();
            Stack<int> stackNumbers = new Stack<int> ();
            Queue<int> queueNumbers = new Queue<int> ();
            HashSet<int> hashSetNumbers = new HashSet<int> ();

            foreach (int num in numbers)
            {
                listNumbers.Add(num);
            }
            Console.WriteLine($"List: {string.Join(", ", listNumbers)}");

            foreach (int num in numbers)
            {
                stackNumbers.Push(num);
            }
            Console.WriteLine($"Stack: {string.Join(", ", stackNumbers)}");
            
            foreach (int num in numbers)
            {
                queueNumbers.Enqueue(num);
            }
            Console.WriteLine($"Queue: {string.Join(", ", queueNumbers)}");
            
            foreach (int num in numbers)
            {
                hashSetNumbers.Add(num);
            }
            Console.WriteLine($"HashSet: {string.Join(", ", hashSetNumbers)}");
       }
    }
}
