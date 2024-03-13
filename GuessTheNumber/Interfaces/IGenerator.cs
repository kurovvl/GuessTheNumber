using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    /// <summary>
    /// Интерфейс для генератора чисел
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Генерирует число по алгоритму в заданном диапазоне
        /// </summary>
        /// <param name="min">Минимальное значение диапазона</param>
        /// <param name="max">Максимальное значение диапазона</param>
        /// <returns>Число в заданном диапазоне</returns>
        int Generate(int min, int max);
    }
}
