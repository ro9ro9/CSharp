namespace _4.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeaponFactory weaponFactory = new WeaponFactory();
            weaponFactory.rare = 1;

            Weapon Weapon11 = weaponFactory.Create("철검");
            Weapon Weapon12 = weaponFactory.Create("나무창");
            Weapon Weapon13 = weaponFactory.Create("쇠도끼");

            WeaponFactory rareFactory = new WeaponFactory();
            rareFactory.rare = 1.1f;

            Weapon rareWeapon1 = rareFactory.Create("철검");
            Weapon rareWeapon2 = rareFactory.Create("나무창");
            Weapon rareWeapon3 = rareFactory.Create("쇠도끼");

            WeaponFactory legendFactory = new WeaponFactory();
            legendFactory.rare = 1.2f;

            Weapon legendWeapon1 = legendFactory.Create("철검");
            Weapon legendWeapon2 = legendFactory.Create("나무창");
            Weapon legendWeapon3 = legendFactory.Create("쇠도끼");

            Console.WriteLine(rareWeapon1);

        }

    }
    public class WeaponFactory
    {
        public float rare;
        public Weapon Create(string name)
        {
            Weapon weapon;
            switch (name)
            {
                case "철검":
                    weapon = new Weapon("철검", 3, 3);
                    break;
                case "나무창":
                    weapon = new Weapon("나무창", 2, 5);
                    break;
                case "쇠도끼":
                    weapon = new Weapon("쇠도끼", 5, 2);
                    break;
                default: return null;
            }
            weapon.Damage = (float)(weapon.Damage * rare);

            return weapon;
        }
    }
    public class Weapon
    {
        public string Name;
        public float Damage;
        public int AttackRange;

        public Weapon(string name, float damage, int attackRange)
        {
            this.Name = name;
            this.Damage = damage;
            this.AttackRange = attackRange;
        }
    }
}
