using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Classes
{
    public class GameLoop
    {
        public User User { get; set; }
        public AIUser AIUser { get; set; }
        public GameLoop() { 
            User = new User(0, "", false);
            AIUser = new AIUser(0, "", false);
        }
    }
}
