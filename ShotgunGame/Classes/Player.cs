using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class Player
    {
        public int Bullets { get; set; }
        public string ActionOption { get; set; }
        public bool ShotgunAvailable { get; set; }
        public string PreviousAction { get; set; }

        public Player(int bullets, string actionOption, bool shotgunAvailable, string previousAction) {
            Bullets = bullets;
            ActionOption = actionOption;
            ShotgunAvailable = shotgunAvailable;
            PreviousAction = previousAction;
        }

        public bool IsShotgunAvailable() {
            //temp
            return true;
        }
        public void UpdateBullets(int bulletChange) {
            Bullets += bulletChange;
        }

        public void DecreaseBullets() {
            Bullets -= 1;
        }
    }
}
