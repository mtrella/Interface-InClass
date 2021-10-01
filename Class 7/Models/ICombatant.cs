namespace Class_7.Models
{
    public interface ICombatant{
        
        void Attack(Enemy enemy);
        
        void Defend(Enemy enemy);
    }
}