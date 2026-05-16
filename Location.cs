using System.Drawing;

namespace He_escaped
{   // comments edited by claude
    /// <summary>
    /// Represents a named location on the board.
    /// Each Location holds a Tile (which defines gameplay behaviour) plus
    /// display information: a name, a flavour description, and a map colour.
    /// </summary>
    public class Location
    {
        // ── Properties ───────────────────────────────────────────────────────

        /// <summary>Short display name shown on the map, e.g. "Forest Clearing".</summary>
        public string Name { get; set; }

        /// <summary>Flavour text logged when the player arrives here.</summary>
        public string Description { get; set; }

        /// <summary>The tile that controls what actually happens at this location.</summary>
        public Tile Tile { get; set; }

        /// <summary>Colour used when drawing this location on the board bitmap.</summary>
        public Color MapColor { get; set; }

        // ── Constructor ───────────────────────────────────────────────────────

        public Location(string name, string description, Tile tile, Color mapColor)
        {
            Name = name;
            Description = description;
            Tile = tile;
            MapColor = mapColor;
        }

        // ── Static factory methods ────────────────────────────────────────────

        public static Location MakeChoice() =>
            new Location(
                "Crossroads",
                "You reach a crossroads and take a breath.",
                new Tile(TileKind.Choice, "You find a moment to act."),
                Color.SteelBlue);

        public static Location MakeRandomEvent() =>
            new Location(
                "Strange Ground",
                "Something feels off about this place.",
                new Tile(TileKind.RandomEvent, "Something unexpected happens here."),
                Color.DarkOrange);

        public static Location MakeLoseItem() =>
            new Location(
                "Rough Terrain",
                "The path tears at your pack.",
                new Tile(TileKind.LoseItem, "You lose an item scrambling through here."),
                Color.Firebrick);

        public static Location MakeMerchant() =>
            new Location(
                "Merchant Camp",
                "A merchant waves you over from beside the road.",
                new Tile(TileKind.Merchant, "A merchant is here. Time to spend."),
                Color.Goldenrod);

        public static Location MakeHpLoss() =>
            new Location(
                "Danger Zone",
                "You should not have stopped here.",
                new Tile(TileKind.HpLoss, "You take damage."),
                Color.DarkRed);

        public static Location MakeEmpty() =>
            new Location(
                "Open Road",
                "Nothing of note here. Keep moving.",
                new Tile(TileKind.Empty, "Nothing happens."),
                Color.DimGray);

        public static Location MakeCity() =>
            new Location(
                "The City",
                "The city looms ahead. You made it.",
                new Tile(TileKind.City, "You reach the city!"),
                Color.MediumPurple);

        // ── Helpers ───────────────────────────────────────────────────────────

        public TileKind Kind => Tile.Kind;

        public override string ToString() => $"{Name} [{Tile.Kind}]";
    }
}