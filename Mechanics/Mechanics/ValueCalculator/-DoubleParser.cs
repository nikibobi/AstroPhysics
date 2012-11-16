using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.ValueCalculator
{
    class DoubleParser
    {
        public static double Parse(string text)
        {
            double result = 0;
            char[] tokens = text.ToCharArray();
            int cell;
            int tenPower = 0;
            int number = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (int.TryParse(tokens[i].ToString(), out cell))//tokens[i] is a number
                {
                    number += int.Parse(tokens[i].ToString()) * (int)Math.Pow(10, tenPower++);
                }
                else if (tokens[i] == '.' || tokens[i] == ',')
                {

                }
                else
                {
                    tokens[i] = ' ';
                }
            }

            return result;
        }
    }
}
