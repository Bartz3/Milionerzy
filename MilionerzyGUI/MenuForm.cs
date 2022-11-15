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
        string answer; // Odpowiedź (a,b,c,d)
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
        }
        public void Initialize()
        {
            gameQuestions = game.readQuestions(); // Pobranie pytań do rozgrywki
             //ListViewItem item= new ListViewItem("itemjeden",0);
            foreach (var prize in game.Prizes.Values.Reverse())
            {
                
                //item.SubItems.Add(prize);
                //if(prize=="40 000zł")prizesListView.Items.Contains()
                prizesListView.Items.Add(prize);
            }
            //prizesListView.Items.Add(item);
            //game.startGame();
            questionLabel.Text = gameQuestions[0].question;
            answerAButton.Text = gameQuestions[0].answerA;
            answerBButton.Text = gameQuestions[0].answerB;
            answerCButton.Text = gameQuestions[0].answerC;
            answerDButton.Text = gameQuestions[0].answerD;

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
    }
}
