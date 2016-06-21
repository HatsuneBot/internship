using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IConvertible
    {
        string ConvertToCSharp(string input);
        string ConvertToVB(string input);
    }
}
