using Guna.UI2.WinForms;
using Milionerzy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilionerzyGUI
{
    public partial class MenuForm : Form
    {
        Game game = new Game();
        public MenuForm()
        {
            //SoundPlayer intro = new SoundPlayer("intro.wav");
            //intro.Load();
            //intro.Play();
            InitializeComponent();
            //loadQuestions();

            menuPanel.Visible = true;
            namePanel.Visible = false;
            roundPanel.Visible = false;
            lastResultsPanel.Visible = false;
            settingsPanel.Visible = false;

            namePanel.Hide();
            roundPanel.Hide();
            lastResultsPanel.Hide();
            settingsPanel.Hide();

            menuPanel.Show();

            //ctrl + alt +t 

            game.isGameActive = true;
            //askQuestion(game.roundNumber);
        }


        public void loadQuestions()
        {
            game.questions = game.readQuestions();        // Pobranie pytań do rozgrywki
                                                          //ListViewItem item= new ListViewItem("itemjeden",0);
                                                          //gameQuestions = game.readQuestions();
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "Pytanie";
            columnHeader.TextAlign = HorizontalAlignment.Center;
            columnHeader.Width = 235;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Próg ";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 35;

            prizesListView.Columns.Add(columnHeader);
            prizesListView.Columns.Add(columnHeader2);
            int count = 12;
            foreach (var prize in game.Prizes.Values.Reverse())
            {

                //ListViewItem listItem = new ListViewItem(count.ToString());

                ListViewItem listItem = new ListViewItem(prize);
                //listItem.SubItems.Add(prize);
                if (listItem.Text == "1000 zł" || listItem.Text == "40 000 zł")
                {
                    listItem.ForeColor = Color.Yellow;
                }
                listItem.SubItems.Add(count.ToString());
                prizesListView.Items.Add(listItem);
                count--;
            }

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Guna2GradientButton)sender;
            string userAnswer = senderObject.Text.Substring(0, 1);

            if (userAnswer == game.questions[game.roundNumber].correctAnswer)
            {
                game.roundNumber++;
                askQuestion(game.roundNumber);
                if (game.roundNumber == 13)
                {
                    SoundPlayer outro = new SoundPlayer("outro.wav");
                    outro.Load();
                    outro.Play();
                    game.isGameActive = false;

                    //roundPanel.Visible = false;
                    //menuPanel.Visible = true;
                }
            }
            else
            {
                senderObject.FillColor = Color.Red;
                switch (game.questions[game.roundNumber].correctAnswer)
                {
                    case "a":
                        //answerAButton.FillColor = Color.Green;
                        answerAButton.FillColor = Color.Green;
                        break;
                    case "b":
                        answerBButton.FillColor = Color.Green;
                        break;
                    case "c":
                        answerCButton.FillColor = Color.Green;
                        break;
                    case "d":
                        answerDButton.FillColor = Color.Green;
                        break;
                }
                MessageBox.Show("PRZEGRAŁEŚ");

                var winnings = game.winnerPrize(game.roundNumber, game.isGameActive);
                game.saveResult(winnings);
                game.isGameActive = false;
                game.resetGame();
            }

        }
        private void chooseGameLevelEvent(object sender,EventArgs e)
        {
            var senderObject = (Guna2Button)sender;
            string idx = senderObject.Tag.ToString();

            switch (idx)
            {
                case "easy":
                    settingsLabel.Text = "Ustawienia -> Łatwy";
                    game.level = 0;
                    game.difficultyLevelVoid(game.level);
                    break;
                case "medium":
                    settingsLabel.Text = "Ustawienia -> Średni";
                    game.level = 1;
                    game.difficultyLevelVoid(game.level);
                    break;
                case "hard":
                    settingsLabel.Text = "Ustawienia -> Trudny";
                    game.level = 2;
                    game.difficultyLevelVoid(game.level);
                    break;
            }
        }
        private void helpButtonsEvent(object sender, EventArgs e)
        {
            var senderObject = (Guna2TileButton)sender;
            string idx = senderObject.Tag.ToString();

            switch (idx)
            {
                case "50":
                    game.fiftyFifty(game.roundNumber);
                    fiftyButton.Visible = false;
                    game.fiftyFiftyBoolRound = game.roundNumber;
                    askQuestion(game.roundNumber);
                    break;
                case "swap":
                    game.changeQuestion(game.roundNumber);
                    swapQuestionButton.Visible = false;
                    askQuestion(game.roundNumber);
                    break;
                case "ask":
                    game.askAudience(game.roundNumber);
                    askAudienceButton.Visible = false;
                    askQuestion(game.roundNumber);
                    break;
            }
        }
        private void endGameButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageDialog.Show(this, "Czy zakończyć grę?", "", MessageDialogButtons.YesNoCancel, MessageDialogStyle.Dark);

            switch (DialogResult)
            {

                case DialogResult.Yes:
                    MessageBox.Show("TAK");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NJE");
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        private void endOfTheGame()
        {

        }
        private void askQuestion(int roundNr)
        {
            if (game.isGameActive && roundNr < 13)
            {
                if (roundNr != 0)
                    prizesListView.Items[12 - roundNr + 1].BackColor = Color.MidnightBlue;
                questionLabel.Text = game.questions[roundNr].question;
                answerAButton.Text = game.questions[roundNr].answerA;
                answerBButton.Text = game.questions[roundNr].answerB;
                answerCButton.Text = game.questions[roundNr].answerC;
                answerDButton.Text = game.questions[roundNr].answerD;
                prizesListView.Items[12 - roundNr].BackColor = Color.Green;

            }


        }

        private void goToNamePanel_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            namePanel.Visible = true;
        }

        private void goToGameButton_Click(object sender, EventArgs e)
        {
            namePanel.Hide();
            game.playerName = nameTextBox.Text;
            if (game.playerName == null) game.playerName = "anonim";
            game.roundNumber = 0;
            loadQuestions();
            roundPanel.Visible = true;
            game.isGameActive = true;
            askQuestion(game.roundNumber);

        }


        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToLastResultButton_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            lastResultsPanel.Visible = true;
            lastResultsPanel.Show();
            //lastResultsPanel.Show();
            //lastResultListView.Items.Add(game.lastResults());
        }

        private void goToSettingsButton_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            settingsPanel.Visible = true;
            settingsPanel.Show();
        }

        private void backToMenuFromSettingsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            settingsPanel.Hide();
            menuPanel.Show();
        }
    }
}
