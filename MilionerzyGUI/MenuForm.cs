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
            game.Start();
            InitializeComponent();

            menuPanel.Visible = true;
            namePanel.Visible = false;
            roundPanel.Visible = false;
            lastResultsPanel.Visible = false;
            settingsPanel.Visible = false;
 

        }


        public void loadQuestions()
        {
            game.questions = game.readQuestions();        // Pobranie pytań do rozgrywki
                                                          //ListViewItem item= new ListViewItem("itemjeden",0);
                                                          //gameQuestions = game.readQuestions();
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
                    prizesListView.Alignment = ListViewAlignment.SnapToGrid;
                count--;
            }

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Guna2GradientButton)sender;
            string userAnswer = senderObject.Text.Substring(0, 1);
            askAudienceGroupBox.Visible = false;
            if (userAnswer == game.questions[game.roundNumber].correctAnswer)
            {
                game.roundNumber++;
                askQuestion(game.roundNumber);
                if (game.roundNumber == 13)
                {
                    game.winnerEnding();
                    game.isGameActive = false;
                }
            }
            else
            {

                senderObject.FillColor = Color.Red;
                highlightCorrectAnswer();

                enableHelpButtons(false);
                Guna2MessageDialog dialog = new Guna2MessageDialog();
                dialog.Caption = "Przegrana";
                winnerInfoLabel.Visible = true;
                winnerInfoLabel.Text = $"Twoja wygrana:\n{game.winnerPrize(game.roundNumber, game.isGameActive)}";
                goToMenuFromGPButton.Visible = true;
                game.winnerPrize(game.roundNumber, game.isGameActive);
                game.isGameActive = false;
                

            }

        }
        private void highlightCorrectAnswer()
        {
            switch (game.questions[game.roundNumber].correctAnswer)
            {
                case "a":
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

        }
        private void chooseGameLevelEvent(object sender,EventArgs e)
        {
            var senderObject = (Guna2Button)sender;
            string idx = senderObject.Tag.ToString();

            switch (idx)
            {
                case "easy":
                    currentLevelLabel.Text = "Aktualny poziom - Łatwy";
                    levelNPLabel.Text = "Poziom - Łatwy";
                    game.level = 0;
                    easyButton.FillColor = Color.Green;
                    mediumButton.FillColor = Color.DarkBlue;
                    hardButton.FillColor = Color.DarkBlue;
                    game.difficultyLevelVoid(game.level);
                    
                    break;
                case "medium":
                    currentLevelLabel.Text = "Aktualny poziom - Średni";
                    levelNPLabel.Text = "Poziom - Średni";
                    game.level = 1;
                    easyButton.FillColor = Color.DarkBlue;
                    mediumButton.FillColor = Color.Green;
                    hardButton.FillColor = Color.DarkBlue;
                    game.difficultyLevelVoid(game.level);
                    break;
                case "hard":
                    currentLevelLabel.Text = "Aktualny poziom - Trudny";
                    levelNPLabel.Text = "Poziom - Trudny";
                    game.level = 2;
                    easyButton.FillColor = Color.DarkBlue;
                    mediumButton.FillColor = Color.DarkBlue;
                    hardButton.FillColor = Color.Green;
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
                    
                    break;
                case "swap":
                    game.changeQuestion(game.roundNumber);
                    swapQuestionButton.Visible = false;
                    
                    break;
                case "ask":
                    askAudienceHelpMethod();
                    askAudienceGroupBox.Visible = true;
                    //game.askAudience(game.roundNumber);
                    game.askAudience2(game.roundNumber);
                    askAudienceButton.Visible = false;
                    break;
            }
                    askQuestion(game.roundNumber);
        }
        private void askAudienceHelpMethod()
        {
            int[] chances = new int[4];
            chances = game.askAudience2(game.roundNumber);

            aPB.Value = chances[0];
            aPB.Text = chances[0].ToString();
            bPB.Value = chances[1];
            bPB.Text = chances[1].ToString();
            cPB.Value = chances[2];
            cPB.Text = chances[2].ToString();
            dPB.Value = chances[3];
            dPB.Text = chances[3].ToString();

        }
        private void endGameButton_Click(object sender, EventArgs e)
        {

            MessageDialog.TextOnButtons.Yes = "Tak";
            MessageDialog.TextOnButtons.No = "Nie";
            DialogResult = MessageDialog.Show(this, "Czy zakończyć grę?", "", MessageDialogButtons.YesNo, MessageDialogStyle.Default);

            

            switch (DialogResult)
            {

                case DialogResult.Yes:
                    game.isGameActive = false;
                   
                    game.winnerPrize(game.roundNumber, game.isGameActive);
                    goToMenuFromGPButton.Visible = true;
                    //game.resetGame();
                    //prizesListView.Items.Clear();
                    winnerInfoLabel.Visible = true;
                    winnerInfoLabel.Text = $"Twoja wygrana:\n{game.winnerPrize(game.roundNumber, game.isGameActive)}";
                    highlightCorrectAnswer();
                    enableHelpButtons(false);   
                    break;
                case DialogResult.No:
                    break;
            }
        }
        private void enableHelpButtons(bool isActive)
        {
            askAudienceButton.Enabled = isActive;
            fiftyButton.Enabled = isActive;
            swapQuestionButton.Enabled = isActive;
            endGameButton.Enabled = isActive;
        }
        private void endOfTheGame()
        {
            game.resetGame();
            prizesListView.Items.Clear();
            answerAButton.FillColor = Color.DarkBlue;
            answerAButton.FillColor2 = Color.FromArgb(128, 128, 255);

            answerBButton.FillColor = Color.FromArgb(128, 128, 255);
            answerBButton.FillColor2 = Color.DarkBlue;

            answerCButton.FillColor = Color.DarkBlue;
            answerCButton.FillColor2 = Color.FromArgb(128, 128, 255);

            answerDButton.FillColor = Color.FromArgb(128, 128, 255);
            answerDButton.FillColor2 = Color.DarkBlue;

            winnerInfoLabel.Visible = false;

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
            enableHelpButtons(true);
            goToMenuFromGPButton.Visible = false;
            game.playerName = nameTextBox.Text;
            if (game.playerName == "") game.playerName = "anonim";
            game.roundNumber = 0;
            loadQuestions();
            roundPanel.Visible = true;
            fiftyButton.Visible = true;
            swapQuestionButton.Visible = true;
            askAudienceButton.Visible = true;
            game.isGameActive = true;
            askAudienceGroupBox.Visible = false;
            askQuestion(game.roundNumber);

        }


        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToLastResultButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            lastResultsPanel.Visible = true;

            List<String> lastResults = game.lastResults();
            foreach (var result in lastResults)
            {
                 lastResultsListView.Items.Add(result+"\n");         
            }

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

        private void goToMenuFromLRButton_Click(object sender, EventArgs e)
        {
            lastResultsListView.Items.Clear();
            lastResultsPanel.Visible = false;
            menuPanel.Visible = true;
        }

        private void goToMenuFromNPButton_Click(object sender, EventArgs e)
        {
            namePanel.Visible = false;
            menuPanel.Visible = true;
        }

        private void goToMenuFromGPButton_Click(object sender, EventArgs e)
        {
            roundPanel.Visible = false;
            endOfTheGame();
            menuPanel.Visible = true;
        }
    }
}
    
