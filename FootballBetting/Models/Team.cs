using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Numerics;

namespace FootballBetting.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [RegularExpression(@"^[\x20-\x7E]+$")]
        public string Logo { get; set; }

        [StringLength(3)]

        public string Initials { get; set; }

        public float BudGet { get; set; }

        public int PrimaryKitColorId { get; set; }

        public int SecondaryKitColorId { get; set; }

        public int TownId { get; set; }
        public Color PrimaryKitColor { get; set; }
        public Color SecondaryKitColor { get; set; }

        public Town Town { get; set; }

        public List<Player> Players { get; set; }
        public List<Game> HomeGames { get; set; }
        public List<Game> AwayGames { get; set; }
    }
}
