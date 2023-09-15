using ShotgunGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShotgunGame
{
    public partial class FrmGameArea : Form
    {
        public GameLoop Gameloop;
        public FrmGameArea(GameLoop gameloop) {
            InitializeComponent();
            Gameloop = gameloop;
        }

        private void ButtonClick(object sender, EventArgs e) {
            //Check if bullets are enough for the chosen one
            if ((sender as Button).Text == "SHOTGUN" && Gameloop.User.Bullets < 3) {
                MessageBox.Show("YOU NEED 3 BULLETS FOR SHOTGUN!");
                return;
            }
            if((sender as Button).Text == "SHOOT" && Gameloop.User.Bullets < 1) {
                MessageBox.Show("YOU NEED BULLETS TO BE ABLE TO SHOOT!");
                return;
            }
            //Get Player choices
            string playerChoice = Gameloop.User.HandleButtonClick(sender);
            string AIChoice = Gameloop.AIUser.OptionGenerator(Gameloop.AIUser.Bullets, Gameloop.User.Bullets);
            //UPDATE previous action here, it looks better
            UpdatePreviousAction(playerChoice, AIChoice);
            //Call the GameLoop update method for these choices
            Gameloop.UpdateGameStats(playerChoice, AIChoice);

            //put in seperate function to update labels and so
            UpdateLabels();
            //MessageBox.Show($"You chose: {playerChoice}\nAI chose: {AIChoice}");
        }

        private void UpdateLabels() {
            labelUserBulletsCounter.Text = Gameloop.User.Bullets.ToString();
            labelAIUserBulletsCounter.Text = Gameloop.AIUser.Bullets.ToString();
            labelWins.Text = Gameloop.User.Wins.ToString();
            labelLosses.Text = Gameloop.User.Losses.ToString();
        }

        private void UpdatePreviousAction(string playerChoice, string AIChoice) {
            Gameloop.User.PreviousAction = playerChoice;
            Gameloop.AIUser.PreviousAction = AIChoice;
            labelUserPreviousAction.Text = Gameloop.User.PreviousAction;
            labelAIUserPreviousAction.Text = Gameloop.AIUser.PreviousAction;
        }
    }
}
