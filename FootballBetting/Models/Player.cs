namespace FootballBetting.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SquadNumber { get; set; }

        public int TeamId { get; set; }

        public int PositionId { get; set; }

        public bool IsInjured { get; set; }

        public Team Team { get; set; }

        public Position Position { get; set; }

        public List<PlayerStatistic> Statistic { get; set; }
    }
}
