﻿namespace FootballBetting.Models
{
    public class PlayerStatistic
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public int PlayerId { get; set; }

        public int ScoredGoals { get; set; }

        public int Assists { get; set; }

        public float MinutesPlayed { get; set; }

        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}
