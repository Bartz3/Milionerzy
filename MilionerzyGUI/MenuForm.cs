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
            Initialize();

            menuPanel.Visible = false;
            namePanel.Visible = false;
            roundPanel.Visible = true;

            game.isGameActive = true;
            askQuestion(game.roundNumber);
        }


        public void Initialize()
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
                        //answerAButton.FillColor = Color.Green;
                        answerAButton.FillColor2 = Color.Green;
                        break;
                    case "b":
                        answerAButton.FillColor = Color.Green;
                        break;
                    case "c":
                        answerAButton.FillColor = Color.Green;
                        break;
                    case "d":
                        answerAButton.FillColor = Color.Green;
                        break;
                }
                MessageBox.Show("PRZEGRAŁEŚ");
                var winnings = game.winnerPrize(game.roundNumber, game.isGameActive);
                game.saveResult(winnings);
                game.isGameActive = false;
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
        public void startGame()
        {
            while (game.isGameActive && game.roundNumber < 13)
            {

                //prizesListView.;
                if ("A" == game.questions[game.roundNumber].correctAnswer)
                {

                    //game.roundNumber++;
                    questionLabel.Text = game.questions[game.roundNumber].question;
                    answerAButton.Text = game.questions[game.roundNumber].answerA;
                    answerBButton.Text = game.questions[game.roundNumber].answerB;
                    answerCButton.Text = game.questions[game.roundNumber].answerC;
                    answerDButton.Text = game.questions[game.roundNumber].answerD;

                    if (game.roundNumber == 2 || game.roundNumber == 7)
                    {

                    }
                    else
                    {

                    }

                }
                else
                {

                    //SoundPlayer badAnswer = new SoundPlayer("badAnswer.wav");
                    //badAnswer.Load();
                    //badAnswer.Play();


                    var winnings = game.winnerPrize(game.roundNumber, game.isGameActive);
                    game.saveResult(winnings);
                    game.isGameActive = false;

                }
                if (game.roundNumber == 12)
                {
                    //SoundPlayer outro = new SoundPlayer("outro.wav");
                    //outro.Load();
                    //outro.Play();
                    game.isGameActive = false;
                }
                game.roundNumber++;


            }
            //game.isGameActive = false;
            //game.resetGame();
            //roundPanel.Visible = false;
            //menuPanel.Visible = true;
        }

        private void goToNamePanel_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            namePanel.Visible = true;
        }


        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToGameButton_Click(object sender, EventArgs e)
        {
            namePanel.Hide();
            game.playerName = nameTextBox.Text;
            if (game.playerName == null) game.playerName = "anonim";
            game.roundNumber = 0;
            roundPanel.Visible = true;
            game.isGameActive = true;


        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            DialogResult =MessageDialog.Show(this,"Czy zakończyć grę?","", MessageDialogButtons.YesNoCancel, MessageDialogStyle.Dark);

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
    }
}
