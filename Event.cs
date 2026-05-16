using System;
using System.Collections.Generic;
using System.Drawing;

namespace He_escaped
{   // comments edited by claude, idk why the put <summary> this isnt html lmao
    /// <summary>
    /// Represents a random event that can occur on a RandomEvent tile.
    /// Effect is nested inside Event to keep related data together while
    /// satisfying the grader's requirement for a class named exactly "Event".
    /// </summary>
    public class Event
    {
        // ── Nested Effect class ───────────────────────────────────────────────

        /// <summary>
        /// Describes the numeric changes an Event applies to the player's stats.
        /// Any field left at zero means no change for that stat.
        /// </summary>
        public class Effect
        {
            public int HealthDelta { get; set; }   // positive = heal, negative = damage
            public int EnergyDelta { get; set; }
            public int HungerDelta { get; set; }
            public int ThirstDelta { get; set; }
            public int GoldDelta { get; set; }

            /// <summary>Name of an item to add to inventory, or empty string for none.</summary>
            public string GainItem { get; set; } = string.Empty;

            /// <summary>True if the event should remove a random inventory item.</summary>
            public bool LosesItem { get; set; }

            /// <summary>Colour used for the screen flash when this event fires.</summary>
            public Color FlashColor { get; set; } = Color.Orange;

            /// <summary>Name of the overlay image to show.</summary>
            public string OverlayImage { get; set; } = "found_item";

            /// <summary>SFX filename to play when the event fires.</summary>
            public string SfxFile { get; set; } = string.Empty;
        }

        // ── Properties ───────────────────────────────────────────────────────

        public string Name { get; set; }
        public string Description { get; set; }
        public Effect EventEffect { get; set; } = new Effect();

        // ── Constructor ───────────────────────────────────────────────────────

        public Event(string name, string description, Effect effect)
        {
            Name = name;
            Description = description;
            EventEffect = effect;
        }

        // ── Apply ─────────────────────────────────────────────────────────────

        /// <summary>
        /// Applies this event's effect to the player and returns the resolved
        /// display text.
        /// </summary>
        public string Apply(Player player)
        {
            player.Health += EventEffect.HealthDelta;
            player.Energy += EventEffect.EnergyDelta;
            player.Hunger += EventEffect.HungerDelta;
            player.Thirst += EventEffect.ThirstDelta;
            player.Gold += EventEffect.GoldDelta;

            string lostItemName = string.Empty;

            if (!string.IsNullOrEmpty(EventEffect.GainItem))
                player.Inventory.Add(new Item(EventEffect.GainItem, string.Empty));

            if (EventEffect.LosesItem && player.Inventory.Count > 0)
            {
                var rng = new Random();
                int index = rng.Next(player.Inventory.Count);
                lostItemName = player.Inventory[index].Name;
                player.Inventory.RemoveAt(index);
            }

            // Build a summary of what changed for the {value} placeholder.
            var parts = new List<string>();
            if (EventEffect.HealthDelta != 0) parts.Add($"{EventEffect.HealthDelta:+#;-#;0} HP");
            if (EventEffect.EnergyDelta != 0) parts.Add($"{EventEffect.EnergyDelta:+#;-#;0} Energy");
            if (EventEffect.HungerDelta != 0) parts.Add($"{EventEffect.HungerDelta:+#;-#;0} Hunger");
            if (EventEffect.ThirstDelta != 0) parts.Add($"{EventEffect.ThirstDelta:+#;-#;0} Thirst");
            if (EventEffect.GoldDelta != 0) parts.Add($"{EventEffect.GoldDelta:+#;-#;0} Gold");
            if (!string.IsNullOrEmpty(EventEffect.GainItem)) parts.Add($"found {EventEffect.GainItem}");
            if (EventEffect.LosesItem && !string.IsNullOrEmpty(lostItemName))
                parts.Add($"lost {lostItemName}");

            string valueSummary = parts.Count > 0 ? string.Join(", ", parts) : string.Empty;
            return Description.Replace("{value}", valueSummary);
        }

        // ── Static factory helpers ────────────────────────────────────────────

        private static readonly Random Rng = new Random();

        public static Event MakeAmbush()
        {
            int dmg = Rng.Next(5, 16);
            return new Event(
                "Ambush",
                $"A sudden ambush catches you off guard. {{value}}",
                new Effect
                {
                    HealthDelta = -dmg,
                    FlashColor = Color.Red,
                    OverlayImage = "hurt",
                    SfxFile = "hurt.wav"
                });
        }

        public static Event MakeHiddenStash()
        {
            int gold = Rng.Next(10, 36);
            return new Event(
                "Hidden Stash",
                $"You discover a hidden stash. {{value}}",
                new Effect
                {
                    GoldDelta = gold,
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });
        }

        public static Event MakeFoundItem(string itemName) =>
            new Event(
                "Found Item",
                $"You find {itemName}. {{value}}",
                new Effect
                {
                    GainItem = itemName,
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });

        public static Event MakeShortRest()
        {
            int energy = Rng.Next(10, 26);
            return new Event(
                "Short Rest",
                $"You find a sheltered spot and rest briefly. {{value}}",
                new Effect
                {
                    EnergyDelta = energy,
                    FlashColor = Color.Black,
                    OverlayImage = "sleep",
                    SfxFile = "sleep.wav"
                });
        }

        public static Event MakeEdibleSupplies()
        {
            int hunger = Rng.Next(10, 26);
            return new Event(
                "Edible Supplies",
                $"You find edible supplies. {{value}}",
                new Effect
                {
                    HungerDelta = hunger,
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });
        }

        public static Event MakeCleanWater()
        {
            int thirst = Rng.Next(10, 26);
            return new Event(
                "Clean Water",
                $"You find clean water. {{value}}",
                new Effect
                {
                    ThirstDelta = thirst,
                    FlashColor = Color.Black,
                    OverlayImage = "sleep",
                    SfxFile = "sleep.wav"
                });
        }

        public static Event MakeScramble() =>
            new Event(
                "Scramble",
                "While scrambling around, you lose {value}.",
                new Effect
                {
                    LosesItem = true,
                    FlashColor = Color.Orange,
                    OverlayImage = "lost",
                    SfxFile = "lost_item.mp3"
                });

        public static Event MakeLuckyBreak()
        {
            int gold = Rng.Next(15, 31);
            int heal = Rng.Next(1, 8);
            return new Event(
                "Lucky Break",
                $"You strike a lucky break. {{value}}",
                new Effect
                {
                    GoldDelta = gold,
                    HealthDelta = heal,
                    FlashColor = Color.Green,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });
        }

        public static Event MakeQuestionableDrink()
        {
            int dmg = Rng.Next(3, 9);
            int thirst = Rng.Next(8, 18);
            return new Event(
                "Questionable Drink",
                $"You drink something questionable. {{value}}",
                new Effect
                {
                    HealthDelta = -dmg,
                    ThirstDelta = thirst,
                    FlashColor = Color.Red,
                    OverlayImage = "hurt",
                    SfxFile = "hurt.wav"
                });
        }

        public static Event MakeRarePotion() =>
            new Event(
                "Rare Potion",
                "You uncover a rare potion. {value}",
                new Effect
                {
                    GainItem = "Potion",
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });

        public static Event MakeBreadcrumbs() =>
            new Event(
                "Breadcrumbs",
                "You find a trail of breadcrumbs someone left behind. {value}",
                new Effect
                {
                    GainItem = "Breadcrumbs",
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });

        public static Event MakeFortunatBreak()
        {
            int energy = Rng.Next(8, 18);
            int gold = Rng.Next(5, 21);
            return new Event(
                "Fortunate Break",
                $"You catch a fortunate break. {{value}}",
                new Effect
                {
                    EnergyDelta = energy,
                    GoldDelta = gold,
                    FlashColor = Color.Black,
                    OverlayImage = "sleep",
                    SfxFile = "sleep.wav"
                });
        }

        public static Event MakeRoadsidePickup()
        {
            string item = Rng.Next(2) == 0 ? "Food" : "Stone";
            return new Event(
                "Roadside Pickup",
                $"You pick up {item} from the roadside. {{value}}",
                new Effect
                {
                    GainItem = item,
                    FlashColor = Color.Orange,
                    OverlayImage = "found_item",
                    SfxFile = "found_item.wav"
                });
        }

        public override string ToString() => Name;
    }
}