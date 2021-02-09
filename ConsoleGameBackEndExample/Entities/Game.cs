using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Entities
{
    public class Game : BaseModel
    {
        public string GameName { get; set; }
        public int GameCost { get; set; }
        public int GameData { get; set; }
        public int GameRating { get; set; }
        public string GameType { get; set; }
    }
}
