using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class AdvancedUserInput : UserInput
    {
        public override int GetUserGuess()
        {
            int guess;
            do
            {
                Console.Write("Введите ваше число (должно быть положительным): ");
                guess = Convert.ToInt32(Console.ReadLine());
            } while (guess < 0);

            return guess;
        }
    }
}
