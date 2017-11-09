using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BoardGameTracker
{
    class FileReadAndWriter
    {
        public List<Game> loadListOfGames(string fileLocation)
        {
            List<Game> listOfGames = new List<Game>();
            StreamReader reader = new StreamReader(fileLocation);

            string nameOfGame = reader.ReadLine();
            do
            {
                Game game = new Game();
                game.name = nameOfGame;

                int numOfExpansions = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < numOfExpansions; i++)
                {
                    string expansion = reader.ReadLine();
                    game.addExpansion(expansion);
                }

                listOfGames.Add(game);

                nameOfGame = reader.ReadLine();
            } while (nameOfGame != null);

            reader.Close();

            return listOfGames;
        }

        public List<string> loadListOfNames(string fileLocation)
        {
            StreamReader reader = new StreamReader(fileLocation);
            List<string> listOfNames = new List<string>();

            string name = reader.ReadLine();
            do
            {
                listOfNames.Add(name);
                name = reader.ReadLine();
            } while (name != null);

            reader.Close();

            return listOfNames;
        }

        public void outputScore(string output, string fileLocation) 
        {
            StreamWriter writer = new StreamWriter(fileLocation, true);
            writer.WriteLine(output);
            writer.Close();
        }

        public List<Score> loadScore(string fileLocation)
        {
            List<Score> scores = new List<Score>();
            StreamReader reader = new StreamReader(fileLocation);
            Char delimeter = ',';

            string line = reader.ReadLine();
            do
            {
                string[] commaSeperatedValues = line.Split(delimeter);
                Score score = new Score();

                score.gameNum = Convert.ToInt32(commaSeperatedValues[0]);
                score.player = commaSeperatedValues[1];
                score.value = Convert.ToInt32(commaSeperatedValues[2]);
                score.numOfPlayers = Convert.ToInt32(commaSeperatedValues[3]);
                score.place = Convert.ToInt32(commaSeperatedValues[4]);
                score.addGameName(commaSeperatedValues[5]);
                
                for(int i=0; i<Convert.ToInt32(commaSeperatedValues[6]); i++)
                {
                    score.addGameExpansion(commaSeperatedValues[i + 7]);
                }

                scores.Add(score);

                line = reader.ReadLine();
            } while (line != null);

            reader.Close();

            return scores;
        }

        public int findLastGameNum(string fileLocation)
        {
            StreamReader reader = new StreamReader(fileLocation);
            string curLine;
            string nextLine = reader.ReadLine();
            do
            {
                curLine = nextLine;
                nextLine = reader.ReadLine();
            } while (nextLine != null);

            reader.Close();
            return Convert.ToInt32(curLine.Substring(0, 1));
        }
    }
}
