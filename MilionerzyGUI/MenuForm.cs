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
        List<Question> gameQuestions; // Pytania
        public string answer; // Odpowiedź (a,b,c,d)
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
            startGame();
        }


        public void Initialize()
        {
            gameQuestions = game.readQuestions(); // Pobranie pytań do rozgrywki
                                                  //ListViewItem item= new ListViewItem("itemjeden",0);
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
                listItem.SubItems.Add(count.ToString());
                prizesListView.Items.Add(listItem);
                count--;

                //prizesListView.Items.Add(prize);
            }
            questionLabel.Text = gameQuestions[0].question;
            answerAButton.Text = gameQuestions[0].answerA;
            answerBButton.Text = gameQuestions[0].answerB;
            answerCButton.Text = gameQuestions[0].answerC;
            answerDButton.Text = gameQuestions[0].answerD;


        }
        public void startGame()
        {
            while (game.isGameActive && game.roundNumber < 13)
            {

                waitForAnswer();
                //prizesListView.;
                if (answer == gameQuestions[game.roundNumber].correctAnswer)
                {
                    
                        game.roundNumber++;
                        questionLabel.Text = gameQuestions[game.roundNumber].question;
                        answerAButton.Text = gameQuestions[game.roundNumber].answerA;
                        answerBButton.Text = gameQuestions[game.roundNumber].answerB;
                        answerCButton.Text = gameQuestions[game.roundNumber].answerC;
                        answerDButton.Text = gameQuestions[game.roundNumber].answerD;

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

        private void waitForAnswer()
        {
                
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
            game.playerName =nameTextBox.Text;
            if (game.playerName == null) game.playerName = "anonim";
            game.roundNumber = 0;
            roundPanel.Visible = true;
            game.isGameActive = true;

            
        }

        private void answerAButton_Click(object sender, EventArgs e)
        {
            answer = "a";   
        }

        private void answerBButton_Click(object sender, EventArgs e)
        {
            answer = "b";
        }

        private void answerCButton_Click(object sender, EventArgs e)
        {
            answer = "c";
        }

        private void answerDButton_Click(object sender, EventArgs e)
        {
            answer = "d";
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
