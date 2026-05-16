using System.Collections.Generic;

namespace He_escaped
{
    public class Player
    {
        public int Health { get; set; } = 100;
        public int MaxHealth { get; set; } = 100;

        public int Energy { get; set; } = 100;
        public int MaxEnergy { get; set; } = 100;

        public int Hunger { get; set; } = 100;
        public int Thirst { get; set; } = 100;

        public int Gold { get; set; } = 50;
        public int Position { get; set; } = 0;

        public List<Item> Inventory { get; set; } = new List<Item>();

        public bool HasWeaponProtection { get; set; }
        public bool HasSatchelProtection { get; set; }
        public bool HasSleepingBag { get; set; }
        public bool HasCampfireEffect { get; set; }
        public bool HasDoubleRoll { get; set; }
    }
}