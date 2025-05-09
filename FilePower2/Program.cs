using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string sentence;
            using StreamReader senteceWriter = new StreamReader("text.txt");

            while ((sentence = senteceWriter.ReadLine()) != null)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
