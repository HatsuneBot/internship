using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_WPF
{
    class ParseLine
    {
        public static void SplitInput(List<Point> list, string s)
        {
            int i = 0;
            string[] separators = { ",", " ", "\n" };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Point obj = new Point();
            while (i < words.Length)
            {
                obj.GetData(list, double.Parse(words[i]), double.Parse(words[i + 1]));
                i += 2;
            }            
        }
    }
}
