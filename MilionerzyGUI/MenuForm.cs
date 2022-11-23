﻿using Guna.UI2.WinForms;
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

            menuPanel.Visible = true;
            namePanel.Visible = false;
            roundPanel.Visible = false;
            lastResultsPanel.Visible = false;
            settingsPanel.Visible = false;

            //ctrl + alt +t        

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
                }
            }
            else
            {
                senderObject.FillColor = Color.Red;
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
                MessageBox.Show("PRZEGRAŁEŚ");
                goToMenuFromGPButton.Visible = true;
                prizesListView.Items.Clear();
                game.winnerPrize(game.roundNumber, game.isGameActive);
                game.isGameActive = false;
                game.resetGame();
                
                answerAButton.FillColor = Color.DarkBlue;
                answerAButton.FillColor2 = Color.FromArgb(128, 128, 255);

                answerBButton.FillColor = Color.FromArgb(128, 128, 255);
                answerBButton.FillColor2 = Color.DarkBlue;

                answerCButton.FillColor = Color.DarkBlue;
                answerCButton.FillColor2 = Color.FromArgb(128, 128, 255);

                answerDButton.FillColor = Color.FromArgb(128, 128, 255); 
                answerDButton.FillColor2 = Color.DarkBlue;
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
                    game.isGameActive = false;
                   
                    game.winnerPrize(game.roundNumber, game.isGameActive);
                    goToMenuFromGPButton.Visible = true;
                    game.resetGame();
                    prizesListView.Items.Clear();
                    game.winnerPrize(game.roundNumber, game.isGameActive);
                    MessageBox.Show("TAK");
                    break;
                case DialogResult.No:
                    //MessageBox.Show("NJE");
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
            goToMenuFromGPButton.Visible = false;
            game.playerName = nameTextBox.Text;
            if (game.playerName == "") game.playerName = "anonim";
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
            menuPanel.Visible = true;
        }
    }
}
