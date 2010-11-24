using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tickets_de_Petroleo
{
    class RegexValidator
    {
        public static bool Validate(string pattern, string input)
        {
            Regex reg = new Regex(pattern);
            Match match = reg.Match(input);
            if (match.Success)
                return match.Value == input;

            return false;
        }
    }
}
