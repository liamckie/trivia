using System;
using System.Collections.Generic;
using System.Text;

namespace trivia
{
    public class Player
    {
        public string Name;
        public int Score;

        public Player(string playerName)
        {
            Name = playerName;
            Score = 0;
        }
    }
}
