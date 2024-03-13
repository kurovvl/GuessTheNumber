using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class AdvancedNumberGenerator : NumberGenerator
    {
        public override int Generate(int min, int max)
        {
            int number;
            do
            {
                number = base.Generate(min, max);
            } while (number % 2 != 0);

            return number;
        }
    }
}
