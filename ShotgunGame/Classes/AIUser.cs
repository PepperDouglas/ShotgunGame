using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class AIUser : Player
    {
        public AIUser(int bullets, string actionOption, bool shotgunAvailable) : base(bullets, actionOption, shotgunAvailable) {

        }
        public string OptionGenerator() {
            //temp
            return "hello";
        }
    }
}
