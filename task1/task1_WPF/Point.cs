using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_WPF
{
    public static class Point
    {
        /// <summary>
        /// result string will contain the result of formatting
        /// </summary>
        public static string result = String.Empty;
        /// <summary>
        /// PrintOut method formats the incoming text and stores it in a string result
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string PrintOut(string s)
        {
            result = "";
            int i = 0;
            string[] separators = { ",", " ", "\n" };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            while (i < words.Length)
            {
                //Console.WriteLine(words[i]);
                result += "X:" + double.Parse(words[i]) + " Y:" + double.Parse(words[i + 1]) + "\n";
                i += 2;
            }
            return result;
        }
    }
}
