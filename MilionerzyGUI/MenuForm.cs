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
        }
        public void Initialize()
        {
            
             //ListViewItem item= new ListViewItem("itemjeden",0);
            foreach (var prize in game.Prizes.Values.Reverse())
            {
                
                //item.SubItems.Add(prize);
                //if(prize=="40 000zł")prizesListView.Items.Contains()
                prizesListView.Items.Add(prize);
            }
            //prizesListView.Items.Add(item);
            Console.WriteLine("XD");
            
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
            roundPanel.Visible = true;
            game.isGameActive = true;
            
        }

    }
}
