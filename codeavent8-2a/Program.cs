using System;
using System.Collections.Generic;
using System.Linq;

namespace codeavent8_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Input.CodeStrings().ToList();
            for(int i = 0; i < lines.Count; i++)
            {
                var inputs = lines[i].Inputs;
                Dictionary<int, string> digits = new Dictionary<int, string>();
                digits[1] = inputs.Where(item => item.Length == 2).Single();
                digits[4] = inputs.Where(item => item.Length == 4).Single();
                digits[7] = inputs.Where(item => item.Length == 3).Single();
                digits[8] = inputs.Where(item => item.Length == 7).Single();
                

            }
        }
    }
}
