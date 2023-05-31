using System.ComponentModel.DataAnnotations;

namespace FootballBetting.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int GameId { get; set; }
        [Required]
        public string Prediction { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }

        public Game Game { get; set; }
        public User User { get; set; }
    }
}
