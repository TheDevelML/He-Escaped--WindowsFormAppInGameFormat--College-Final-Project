using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_escaped
{
    public enum TileKind
    {
        Choice,
        RandomEvent,
        LoseItem,
        Merchant,
        HpGain,
        HpLoss,
        Empty,
        City
    }

    public class Tile
    {
        public TileKind Kind { get; set; }
        public string Description { get; set; }

        public Tile(TileKind kind, string description)
        {
            Kind = kind;
            Description = description;
        }

        public override string ToString()
        {
            return Kind.ToString();
        }
    }
}
