using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ProgramConverter : IConvertible
    {
        public ProgramConverter() { }

        public string ConvertToCSharp(string input)
        {
            return "Convert to C#";
        }

        public string ConvertToVB(string input)
        {
            return "Convert to Visual Basic";
        }
    }
}
