using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgramConverter[] array = { new ProgramConverter(), new ProgramConverter(), new ProgramHelper(), new ProgramHelper() };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter string to convert to C#:");
                Console.WriteLine(array[i].ConvertToCSharp(Console.ReadLine()));
                Console.WriteLine("Enter string to convert to Visual Basic:");
                Console.WriteLine(array[i].ConvertToCSharp(Console.ReadLine()));
                Console.WriteLine("Enter a language:");
                string lang = Console.ReadLine();
                Console.WriteLine("Enter a string to check syntax:");
                string input = Console.ReadLine();
                if (array[i] is ProgramHelper)
                    Console.WriteLine(((ProgramHelper)array[i]).CodeCheckSyntax(input, lang));
                else Console.WriteLine("Method can not be called");
            }
            Console.ReadKey();
        }
    }
}
