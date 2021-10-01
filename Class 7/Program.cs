using System;
using Microsoft.Extensions.DependencyInjection;
using Class_7.Models;

namespace Class_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICombatant fighter = new Enemy();
            // Create Fighter (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            var fighter1 = new Fighter();
            fighter.Armor.Defense = 10;
            fighter.Weapon.Power = 10;

            // Create Enemy (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            var enemy = new Enemy();
            enemy.Armor.Defense = 10;
            enemy.Weapon.Power = 10;

            
            enemy.Name = "Angry Ant";
            enemy.Armor.Defense = 5;
            enemy.Weapon.Power = 5;

            // DEPENDENCY INJECTION
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IArmor, Leather>()
                .AddSingleton<IWeapon, Sword>()
                .AddSingleton<ICombatant, Fighter>()
                .BuildServiceProvider();

            var fighter2 = serviceProvider.GetService<ICombatant>();

            //Attack Enemy (execute method)
            fighter.Attack(enemy);

            IMonster monster = null;
            monster.Roar();

            IRepository repos = new DbRepository();

            // all I care about is that I retrieved a movie 
            //from where? who cares
            var movie = repos.Get(1);
        }
    }
}
