using System;

namespace Task1
{
    public class ProgramHelper:ProgramConverter, ICodeChecker
    {
        public ProgramHelper() { }

        public bool CodeCheckSyntax(string input, string language)
        {
            return true;
        }

    }
}
