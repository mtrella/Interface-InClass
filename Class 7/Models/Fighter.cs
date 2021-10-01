using System.Globalization;
namespace Class_7.Models
{
    public class Fighter : ICombatant
    {
        public string Name { get; set; }

        public Armor Armor { get; set; }

        public Weapon Weapon { get; set; }

        public Fighter()
        {
            Name = "Fighter";
            Armor = new Armor();
            Weapon = new Weapon();
        }


        public void Attack(Enemy enemy) 
        {
            if (Weapon.Power > enemy.Armor.Defense) 
                System.Console.WriteLine($"{Name} attacks {enemy.Name} with his {Weapon.Name}");
            else
                System.Console.WriteLine($"{enemy.Name} blocks {Name} with his {Armor.Name}");
            
        }



        public void Defend(ICombatant enemy)
        {
        }

        public void Defend(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}