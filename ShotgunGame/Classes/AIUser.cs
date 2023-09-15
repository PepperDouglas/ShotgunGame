using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class AIUser : Player
    {
        public AIUser(int bullets, string actionOption, bool shotgunAvailable, string previousAction) 
            : base(bullets, actionOption, shotgunAvailable, previousAction) {
        }

        public string OptionGenerator(int bullets, int userBullets) {
            if(bullets == 3) {
                return "SHOTGUN";
            } else {
                Random rand = new Random();
                int maxChoice = bullets == 0 ? 2 : 3;
                int minChoice = userBullets > 0 ? 0 : 1; 
                int randomAIChoice = rand.Next(minChoice, maxChoice);
                string[] AIOptions = new string[] {"BLOCK", "RELOAD", "SHOOT"};
                return AIOptions[randomAIChoice];    
            }
        }
    }
}
