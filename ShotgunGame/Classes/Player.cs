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

        public Player(int bullets, string actionOption, bool shotgunAvailable) {
            Bullets = bullets;
            ActionOption = actionOption;
            ShotgunAvailable = shotgunAvailable;
        }

        public bool IsShotgunAvailable() {
            //temp
            return true;
        }
    }
}
