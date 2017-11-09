using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameTracker
{
    class Score
    {
        public int gameNum;
        public int value;
        public int place;
        public string player;
        public int numOfPlayers;
        public Game game = new Game();

        public void addGameName(string name)
        {
            game.setName(name);
        }

        public void addGameExpansion(string name)
        {
            game.addExpansion(name);
        }
    }
}
