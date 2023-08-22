using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Csharp tutorials";
            string text2 = "python tutorials";

            Console.WriteLine(text.Length);

            Console.WriteLine(text.ToUpper());

            Console.WriteLine(text.ToLower());

            Console.WriteLine(string.Concat(text, "hello world"));

            Console.WriteLine(text.CompareTo(text2));
            Console.WriteLine(String.Compare(text, text2, true)); //true ignores upper/lower case

            Console.WriteLine(text.Contains(text2));

            Console.WriteLine(text.StartsWith("python"));
            Console.WriteLine(text2.EndsWith("tutorials"));

            Console.WriteLine(text.IndexOf("tut"));
            Console.WriteLine(text2.LastIndexOf("th"));

            Console.WriteLine(text2.Insert(0, "beginner"));

            Console.WriteLine(text+text2.PadLeft(30));
            Console.WriteLine(text+text2.PadLeft(30, '*'));

            Console.WriteLine(text.Remove(9));
            Console.WriteLine(text.Remove(9,2));

            Console.WriteLine(text.Replace("Csharp", "C#"));

            Console.WriteLine(text2.Split(' ')[1]);

            Console.WriteLine(text.Substring(7));
            Console.WriteLine(text.Substring(7, 4));

            Console.ReadLine();


        }
    }
}
