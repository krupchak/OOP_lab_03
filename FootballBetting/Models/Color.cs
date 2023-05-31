namespace FootballBetting.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Team> PrimaryKitTeams { get; set; }
        public List<Team> SecondaryKitTeams { get; set; }
    }
}
