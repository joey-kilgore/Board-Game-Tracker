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
    public partial class ViewStats : Form
    {
        List<Game> listOfGames;
        List<Score> listOfScores;

        public ViewStats()
        {
            InitializeComponent();
            initializeGameComboBox();
            initializeScores();
        }

        public void initializeScores()
        {
            FileReadAndWriter fileReadAndWriter = new FileReadAndWriter();
            listOfScores = fileReadAndWriter.loadScore(@"C:\Users\joeya\Desktop\Board Game Scores\Scores.csv");
        }

        public void initializeGameComboBox()
        {
            FileReadAndWriter fileReadAndWriter = new FileReadAndWriter();
            listOfGames = fileReadAndWriter.loadListOfGames(@"C: \Users\joeya\Desktop\Board Game Scores\Games.txt");
            foreach (Game game in listOfGames)
            {
                gameNameComboBox.Items.Add(game.name);
            }
        }

        private void gameNameComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            highScoreList.Items.Clear();

            List<Score> selectedScores = new List<Score>();
            ComboBox comboBox = (ComboBox)sender;
            string selectedGame = comboBox.Text;

            foreach (Score score in listOfScores)
            {
                if (score.game.name.Equals(selectedGame))
                {
                    selectedScores.Add(score);
                }
            }

            selectedScores = sortByValue(selectedScores);

            int numToShow;
            if(selectedScores.Count < 5)
            {
                numToShow = selectedScores.Count;
            }
            else
            {
                numToShow = 5;
            }

            for (int i = 1; i <= numToShow; i++) { 
                highScoreList.Items.Add(i.ToString() + ". " + selectedScores.ElementAt(i-1).value.ToString() + " - " + selectedScores.ElementAt(i-1).player.ToString());
            }
        }

        private List<Score> sortByValue(List<Score> scores)
        {
            Score[] arrScores = scores.ToArray();

            for (int write = 0; write < arrScores.Length; write++)
            {
                for (int sort = 0; sort < arrScores.Length - 1; sort++)
                {
                    if (arrScores[sort].value < arrScores[sort + 1].value)
                    {
                        Score temp = arrScores[sort + 1];
                        arrScores[sort + 1] = arrScores[sort];
                        arrScores[sort] = temp;
                    }
                }
            }

            return arrScores.ToList<Score>();
        }

        private void linkToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainScreen();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
