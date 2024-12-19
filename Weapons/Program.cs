using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Weapons
{

    public abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract string Attack();
        public abstract string Description();
    }

    public class Sword : Weapon
    {
        public override int Damage => 15;

        public override string Attack()
        {
            return $"Вы нанесли {Damage} урона мечом.";
        }

        public override string Description()
        {
            return "Это меч.";
        }
    }

    public class Bow : Weapon
    {
        public override int Damage => 10;

        public override string Attack()
        {
            return $"Вы выстрелили из лука и нанесли {Damage} урона.";
        }

        public override string Description()
        {
            return "Это лук.";
        }
    }

    public class Staff : Weapon
    {
        public override int Damage => 20;

        public override string Attack()
        {
            return $"Вы использовали магический посох и нанесли {Damage} урона.";
        }

        public override string Description()
        {
            return "Это посох.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Sword();
            Weapon bow = new Bow();
            Weapon staff = new Staff();

            Console.WriteLine(sword.Attack());
            Console.WriteLine(sword.Description());

            Console.WriteLine(bow.Attack());
            Console.WriteLine(bow.Description());

            Console.WriteLine(staff.Attack());
            Console.WriteLine(staff.Description());
        }
    }

}
