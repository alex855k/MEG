using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public class Game
    {
        private Shop shop;
        private const float version = 0.1f;

        public Game() {
            InitModel();
        }

        public void InitModel()
        {

            //---- Equipment ----
            List<Equipment> inventory = new List<Equipment>();
            //Weapons
            inventory.Add(new Equipment("La baguette mortelle", "Legendary french baguette forged in the fires of a bakery oven, hardened like steel and virtually unedible, bash your enemies head in with this abomination of a weapon and watch the tomato sauce fly in every direction. This deadly weapon was forged in Anchient times by the legendary baker Pantheon of Demacia.", 40f, 50f, 30f, SlotType.Hands, 10));
            inventory.Add(new Equipment("Branch", "Just found this branch, looks like Aspen wood because of the way it is, that's pretty neat.", 10f, 0f, 0f, SlotType.Hands, 1));
            inventory.Add(new Equipment("Steel Club", "Standard miliary issue steel club, nothing special but gets the job done.", 25f, 0f, 10f, SlotType.Hands, 2));
            inventory.Add(new Equipment("Glowing Silver Schmitar", "So sharp it can through anything but steel. Gives off a shimmering blue glow.", 10f, 25f, 10f, SlotType.Hands, 4));

            //Head
            inventory.Add(new Equipment("Hue", "Something something.", 25f, 0f, 10f, SlotType.Head, 2));
            inventory.Add(new Equipment("Hue", "Something something.", 25f, 0f, 10f, SlotType.Head, 2));


            //Chest

            //Feet
            shop = new Shop(inventory);

        }

        public List<string> ViewShop() {
            return new List<string>();
        }

        /*
        public void challengeListener()
        {

        }

        public void challengePlayer(IUser user) {
            // Send request to player

            // Send
        }
        */



    }
}
