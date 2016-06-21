using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ICodeChecker
    {
        bool CodeCheckSyntax(string input, string language);
    }
}
