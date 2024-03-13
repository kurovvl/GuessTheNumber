using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Classes;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Interfaces
{
    public class Game : IPlayable
    {
        private readonly IGenerator _numberGenerator;
        private readonly IUserInput _userInput;
        private readonly IGameSettings _gameSettings;


        public Game(IGenerator numberGenerator, IUserInput userInput, IGameSettings gameSettings)
        {
            _numberGenerator = numberGenerator;
            _userInput = userInput;
            _gameSettings = gameSettings;
        }

        public void Play()
        {
            int secretNumber = _numberGenerator.Generate(_gameSettings.Min, _gameSettings.Max);
            int attempts = 0;

            while (attempts < _gameSettings.Attempts)
            {
                int userGuess = _userInput.GetUserGuess();

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Поздравляем, вы угадали число!");
                    return;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного");
                }
                else
                {
                    Console.WriteLine("Ваше число больше загаданного");
                }

                attempts++;
            }

            Console.WriteLine("Вы не угадали число. Игра окончена.");
        }
    }
}
