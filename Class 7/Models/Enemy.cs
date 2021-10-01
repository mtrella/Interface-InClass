namespace Class_7.Models
{
    public class Enemy : ICombatant
    {
        public string Name {get; set; }

        public Armor Armor {get;set;}

        public Weapon Weapon {get;set;}

        public Enemy()
        {
            Name = "Enemy";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack() {
            
        }

        public void Defend() {

        }

        public void Attack(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}