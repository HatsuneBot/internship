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
            string[] splitted  = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            while (i < splitted.Length)
            {
                list.Add(new Point( double.Parse(splitted[i]), double.Parse(splitted[i + 1])));
                i += 2;
            }            
        }
    }
}
