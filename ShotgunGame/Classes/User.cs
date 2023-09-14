using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class User : Player
    {
        public User(int bullets, string actionOption, bool shotgunAvailable) : base(bullets, actionOption, shotgunAvailable) {

        }
    }
}
