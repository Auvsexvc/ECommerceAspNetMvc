﻿namespace eCommerceApp.Models
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        public int ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}