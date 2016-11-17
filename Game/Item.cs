namespace BattleGame
{
    public class Item
    {
        private string name;
        private SlotType slot;
        private int studentPointValue;

        public Item(string n, int value, string) {
            
        }

        private bool canEquip(SlotType s) {
            if (s == slot) {
                return true;
            }
            return false;
        }

    }
}