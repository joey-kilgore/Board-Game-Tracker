using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameTracker
{
    class Game
    {
        public string name;
        public List<string> victoryPointExpansions = new List<string>();

        public void addExpansion(string expansionName)
        {
            victoryPointExpansions.Add(expansionName);
        }

        public void setName(string nam)
        {
            name = nam;
        }
    }
}
