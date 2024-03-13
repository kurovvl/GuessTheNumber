using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class NumberGenerator : IGenerator
    {
        public virtual int Generate(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
