using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    public static class Bin
    {
        public static string Converter(string i)
        {
            return Convert.ToString(int.Parse(i), 2);
        }
    }
}
