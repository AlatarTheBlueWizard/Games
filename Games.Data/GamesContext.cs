using System;
//Import EntityFrameworkCore that will be used to have the 
//context class inherit the DbContext class. Using a directive.
using Microsoft.EntityFrameworkCore;
//Import Games.Domain when using the Domain classes
using Games.Domain.Games;

namespace Games.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions options) : base(options) { }
        public DbSet<Game> Games { get; set; }
    }
}
