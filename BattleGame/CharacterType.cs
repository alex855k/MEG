using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public class CharacterType
    {
        private string picPathName = "";
        private string name;
        private string gender;
        private string race;
        //Base stats
        private float basehealth = 0f;
        private float basestrength = 0f;
        private float basedexterity = 0f;
        public CharacterType() {
        }

        public void AddPictureName(string nameOfPic) {
            picPathName = "\\images\\" + nameOfPic;
        }

        public string GetPicPath()
        {
            return picPathName;
        }
    }
}
