namespace FootballBetting.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}
