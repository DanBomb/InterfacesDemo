namespace InterfacesDemo
{
    public class Monster 
    {
        public string Name;
        public int Level;

        public Monster(string name, int level, int armor){
            this.Name = name;
            this.Level = level;
        }

        override public string ToString(){
            return this.Name;
        }
    }
    
    public class Orc : Monster, IAttacker {

        public int Armor;
        public int Health;
        public int Damage;

        public Orc (string name, int level, int armor) : base (name, level, armor) {

            this.Level = level;
            this.Health = level * 2;
            this.Armor = armor;
            this.Damage = 5;  
        }

        public int Attack (int armor) {
            return this.Damage - Armor;
        }

        public void TakeDamage (int damage) {
            this.Health -= Damage;
        }

    }
    public class Elf : Monster, IAttacker {

        public int Armor;
        public int Health;
        public int Damage;
        
        public Elf (string name, int level, int armor) : base (name, level, armor) {

            this.Level = level;
            this.Health = level * 1;
            this.Armor = armor;
            this.Damage = 4;
        }

        public int Attack (int armor) {
            return this.Damage - Armor;
        }

        public void TakeDamage (int damage) {
            this.Health -= Damage;
        }

    }
}
