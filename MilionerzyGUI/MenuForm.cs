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
        public MenuForm()
        {
            SoundPlayer intro = new SoundPlayer("intro.wav");
            intro.Load();
            intro.Play();
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoundForm roundForm = new RoundForm();
            roundForm.ShowDialog();
        }
    }
}
