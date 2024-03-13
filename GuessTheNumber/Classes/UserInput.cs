using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class UserInput : IUserInput
    {
        public virtual int GetUserGuess()
        {
            Console.Write("Введите ваше число: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
