using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameTracker
{
    public partial class ScoreEntry : Form
    {
        List<Game> listOfGames;
        public int newGameNum;

        public ScoreEntry()
        {
            InitializeComponent();
            initializeComboBoxes();
            findNewGameNum();
        }

        public void findNewGameNum()
        {
            FileReadAndWriter fileReadAndWriter = new FileReadAndWriter();
            newGameNum = 1 + fileReadAndWriter.findLastGameNum(@"C: \Users\joeya\Desktop\Board Game Scores\Scores.csv");
            gameNumberLabel.Text = "Game Number: " + Convert.ToString(newGameNum);
        }

        public void initializeComboBoxes()
        {
            FileReadAndWriter fileReadAndWriter = new FileReadAndWriter();
            listOfGames = fileReadAndWriter.loadListOfGames(@"C: \Users\joeya\Desktop\Board Game Scores\Games.txt");
            foreach (Game game in listOfGames)
            {
                gameNameComboBox.Items.Add(game.name);
            }

            List<string> listOfNames = fileReadAndWriter.loadListOfNames(@"C: \Users\joeya\Desktop\Board Game Scores\Players.txt");
            foreach(string name in listOfNames)
            {
                playerNameComboBox.Items.Add(name);
            }
        }

        private void gameNameComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedGame = comboBox.Text;
            
            foreach(Game game in listOfGames)
            {
                if (game.name.Equals(selectedGame))
                {
                    expansionCheckBoxList.Items.Clear();

                    foreach(string expansion in game.victoryPointExpansions)
                    {
                        expansionCheckBoxList.Items.Add(expansion);
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string fileLocation = @"C:\Users\joeya\Desktop\Board Game Scores\Scores.csv";

            string gameNumOutput = Convert.ToString(newGameNum)+",";

            string gameName = gameNameComboBox.Text + ",";

            int numOfExpansions = 0;
            string expansions = "";
            for (int i = 0; i < expansionCheckBoxList.Items.Count; i++)
            {
                if (expansionCheckBoxList.GetItemChecked(i))
                {
                    numOfExpansions++;
                    expansions += expansionCheckBoxList.Items[i].ToString() + ",";
                }
            }

            string numberOfPlayers = Convert.ToString(numberOfPlayersNumericUpDown.Value) + ",";

            string nameOfPlayer = playerNameComboBox.Text + ",";
             
            string score = scoreTextBox.Text + ",";

            string place = Convert.ToString(placedUpDown.Value) + ",";

            string output = gameNumOutput + nameOfPlayer + score + numberOfPlayers + place + gameName + numOfExpansions + "," + expansions;

            FileReadAndWriter fileReadAndWriter = new FileReadAndWriter();
            fileReadAndWriter.outputScore(output,fileLocation);

            MessageBox.Show("Score Submited");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainScreen();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGameNum++;
            gameNumberLabel.Text = "Game Number: " + Convert.ToString(newGameNum);
        }
    }
}
