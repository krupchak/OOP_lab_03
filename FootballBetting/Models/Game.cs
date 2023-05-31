namespace FootballBetting.Models
{
    public class Game
    {
        public int Id { get; set; }
        public float AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }
        public int AwayTeamId { get; set; }
        public float DrawBetRate { get; set; }
        public float HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }
        public int HomeTeamId { get; set; }
        public string Result { get; set; }
        public DateTime DateTime { get; set; }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
