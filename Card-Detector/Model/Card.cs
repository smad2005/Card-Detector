using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Card_Detector.Model
{
    class Card
    {
        public string Name { set; get; }

        private Regex regex;
        public string Regex
        {
            set
            {
                regex = new Regex(value,RegexOptions.Compiled);
            }

        }
        public int[] LengthLimits { set; get; }

        public bool Check(string number)
        {
            var result = true;
            if (LengthLimits != null) 
                result = LengthLimits.Any(y => number.Length == y);
            return result && regex.IsMatch(number);
        }

    }
}
