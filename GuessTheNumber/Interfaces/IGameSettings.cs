using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    /// <summary>
    /// Интерфейс для настроек игры
    /// </summary>
    public interface IGameSettings
    {
        int Min { get; }
        int Max { get; }
        int Attempts { get; }
    }
}
