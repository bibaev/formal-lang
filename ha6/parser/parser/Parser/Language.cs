﻿using System.Collections.Generic;
using Monad.Parsec.Language;

namespace parser.Parser
{
    public class Language : EmptyDef
    {
        public Language()
        {
            ReservedOpNames = new List<string> { "+", "-", "*", "/", "%", "==", "!=", ">", ">=", "<", "<=", "&&", "||", ";", ":="};
            ReservedNames = new List<string> { "skip", "write", "read", "while", "do", "if", "then", "else" };
            CaseSensitive = true;
        }
    }
}