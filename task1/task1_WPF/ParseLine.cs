using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_WPF
{
    class ParseLine
    {
        public static void SplitInput(List<Point> list, string input)
        {
            int i = 0;
            string[] separators = { ",", " ", "\n" };
            string[] splitted_input  = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            while (i < splitted_input.Length)
            {
                list.Add(new Point( double.Parse(splitted_input[i]), double.Parse(splitted_input[i + 1])));
                i += 2;
            }            
        }
    }
}
