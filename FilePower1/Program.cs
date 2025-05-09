using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];
            Queue<string> sentence = new Queue<string> ();

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "")
                {
                    sentence.Enqueue(input);
                }
                else
                {
                    break;
                }
            }
            File.WriteAllLines(fileName, sentence);
        }
    }
}