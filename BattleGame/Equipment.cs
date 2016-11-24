using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{

    public class Equipment
    {
        public string Name { get;}
        public string Description { get; }
        public float StrengthAddition { get;}
        public float ManaAddition { get;}
        public float HealthAddition { get;}
        public SlotType EquipmentType { get;}
        public int LevelRequirement { get; }

        public Equipment(string n, string d, float sa, float ma, float ha, SlotType st, int lr){
            this.Name = n;
            this.Description = d;
            this.StrengthAddition = sa;
            this.ManaAddition = ma;
            this.HealthAddition = ha;
            this.EquipmentType = st;
            this.LevelRequirement = lr;
        }
        
    }
}
