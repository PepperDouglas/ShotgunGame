using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class GameLoop
    {
        public User User { get; set; }
        public AIUser AIUser { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public GameLoop() { 
            User = new User(0, "", false, "NONE");
            AIUser = new AIUser(0, "", false, "NONE");
            Wins = 0;
            Losses = 0;
        }
        public void Run() {
            bool gameLoopActive = true;
            while (gameLoopActive) {

            }

        }
        //this should? call all other functions in here to update bullets etc depending on selections from FrmGameArea!!
        //ALSO, we can return a bool true as standard if game should continue or not
        public bool UpdateGameStats(string playerChoice, string AIChoice) {
            bool continueGame = true;
            string replayMessage = "";
            switch (playerChoice) {
                case "RELOAD":
                    User.UpdateBullets(1);
                    if (AIChoice == "RELOAD") {
                        AIUser.UpdateBullets(1);
                    } else if (AIChoice == "SHOOT") {
                        User.IncreaseLosses();
                        ResetGame("YOU LOST!");
                        //Player Loss, reset game? Open form with QUIT GAME / ResetGame() functionality
                    } else if (AIChoice == "BLOCK") {
                    } else if (AIChoice == "SHOTGUN") {
                        User.IncreaseLosses();
                        ResetGame("YOU LOST!");
                    }
                    break;
                
                case "BLOCK":
                    if (AIChoice == "RELOAD") {
                        AIUser.UpdateBullets(1);
                    } else if (AIChoice == "SHOOT") {
                        AIUser.UpdateBullets(-1);
                    } else if (AIChoice == "BLOCK") {                       
                    } else if (AIChoice == "SHOTGUN") {
                        User.IncreaseLosses();
                        ResetGame("YOU LOST!");
                    }
                    break;

                case "SHOOT":
                    User.UpdateBullets(-1);
                    if (AIChoice == "RELOAD") {
                        User.IncreaseWins();
                        ResetGame("YOU WON!");
                    } else if (AIChoice == "SHOOT") {
                        AIUser.UpdateBullets(-1);    
                    } else if (AIChoice == "BLOCK") {
                    } else if (AIChoice == "SHOTGUN") {
                        User.IncreaseLosses();
                        ResetGame("YOU LOST!");
                    }
                    break;

                case "SHOTGUN":
                    if (AIChoice == "RELOAD") {
                        User.IncreaseWins();
                        ResetGame("YOU WON!");
                    } else if (AIChoice == "SHOOT") {
                        User.IncreaseWins();
                        ResetGame("YOU WON!");
                    } else if (AIChoice == "BLOCK") {
                        User.IncreaseWins();
                        ResetGame("YOU WON!");
                    } else if (AIChoice == "SHOTGUN") {
                        User.UpdateBullets(-3);
                        AIUser.UpdateBullets(-3);
                    }
                    break;
            }
            return continueGame;
        }
        public void ResetGame(string resetMessage) {
            Forms.FrmReplaySelection replayform = new Forms.FrmReplaySelection(resetMessage);
            replayform.ShowDialog();
            User.Bullets = 0;
            User.ShotgunAvailable = false;
            User.ActionOption = "";
            User.PreviousAction = "NONE";
            AIUser.Bullets = 0;
            AIUser.ShotgunAvailable = false;
            AIUser.ActionOption = "";
            AIUser.PreviousAction = "NONE";
        }


    }
}
