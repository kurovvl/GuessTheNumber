using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    /// <summary>
    /// Интерфейс для ввода пользователя
    /// </summary>
    public interface IUserInput
    {
        /// <summary>
        /// Получает число, введенное пользователем
        /// </summary>
        /// <returns>Число, введенное пользователем после алгоритмических проверок</returns>
        int GetUserGuess();
    }
}
