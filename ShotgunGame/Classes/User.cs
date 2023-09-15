using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class User : Player
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public User(int bullets, string actionOption, bool shotgunAvailable, string previousAction) 
            : base(bullets, actionOption, shotgunAvailable, previousAction) {
            Wins = 0;
            Losses = 0;
        }

        public string HandleButtonClick(object button) {
            return (button as Button).Text;
        
        }
        public void IncreaseWins() {
            Wins++;
        }
        public void IncreaseLosses() {
            Losses++;
        }
    }
}
