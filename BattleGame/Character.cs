using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public class Character
    {
        private CharacterType characterType;

        // stats
        public long CurrentHealth{get; set;}
        public long CurrentStrenght{ get; set; }
        public long Level { get; set; }

        public Character(CharacterType c) {

        }

        public float CalculateTotalHealth()
        {
            return 1f;
        }

        public long CalculateTotalStrength() {
            
            return 1;
        }

        public void CalculateCurrentMana()
        {

        }

        public override string ToString() {
            return "Character[Level=" +this.Level+ "]";
        }
    }
}
