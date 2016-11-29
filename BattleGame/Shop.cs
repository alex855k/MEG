using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public class Shop
    {
        private List<Equipment> _inventory = new List<Equipment>();
        
        public Shop(List<Equipment> inv)
        {
            this._inventory = inv; 
        }

        /*
        public List<string> ViewInventory(){
            List<string> inventory = new List<string>();
            foreach (Equipment e in _inventory){
                
            }
            return 
        }
        */

    }
}