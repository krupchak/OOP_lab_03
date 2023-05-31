namespace FootballBetting.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }

        public List<Bet> Bets { get; set; }
    }
}
