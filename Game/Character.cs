namespace BattleGame
{
    public class Character
    {
        enum Gender { Male, Female};
        private string name;
        private Gender gender;
        
        public Character() {
            this.name = "";
            this.gender = Gender.Female;
        }

    }
}