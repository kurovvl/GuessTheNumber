using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class GameSettings : IGameSettings
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Attempts { get; set; }
    }
}
