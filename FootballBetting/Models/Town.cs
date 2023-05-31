using System.Diagnostics.Metrics;

namespace FootballBetting.Models
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public List<Team> Teams { get; set; }
    }
}
