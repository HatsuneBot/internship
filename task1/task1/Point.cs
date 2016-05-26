using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Point
    {
        /// <summary>
        /// PrintOut method formats the incoming text and displays it in the console
        /// </summary>
        /// <param name="s"></param>
        public static void PrintOut(string s)
        {
            int i = 0;
            string[] separators = { ",", " ", "\n" };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            while (i < words.Length)
            {
                //Console.WriteLine(words[i]);
                Console.WriteLine("X:{0} Y:{1}", double.Parse(words[i]), double.Parse(words[i + 1]));
                i += 2;
            }

        }
    }
}
