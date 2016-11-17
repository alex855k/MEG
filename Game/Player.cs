using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MEG;
namespace BattleGame
{
    public class Player
    {
        private List<Item> _inventory = new List<Item>();
        private Character c = new Character(); 
        private Student userinfo;
        
        
        // Dummy constructor
        public Player(Student s)
        {
        }

        public string GetUsername() {
            return userinfo.Username;
        }

        public string GetFullname()
        {
            return userinfo.FirstName + " " + userinfo.LastName;
        }
    }
}