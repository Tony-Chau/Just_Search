using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = " green computer search computer sd search green";
            int index = word.IndexOf("computer search") + 16;
            int length = word.Length - index;
            Console.WriteLine(word.Substring(index, length));
            Console.ReadKey();
        }
    }
}
